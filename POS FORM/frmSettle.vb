
Imports System.Data.OracleClient
Imports System.Drawing.Printing
<Obsolete>
Public Class frmSettle
    'PRINT RECEIPT VARIABLE
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'PRINT SIZE
    Sub changelongpaper()
        Dim rowcount As Integer
        With frmSales
            longpaper = 0
            rowcount = .DataGridView1.Rows.Count
            longpaper = rowcount * 15
            longpaper = longpaper + 200
        End With

    End Sub

    Private Sub frmSettle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Keys.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select

    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                SettlePay()
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Sub SettlePay()
        Try
            Dim sdate As String = Now.ToString("dd-MMMM-yyyy")

            'THIS IS TO A VALIDATION IF CASH IS LESS THAN TO TOTAL AMOUNT DUE.
            If CDbl(lblDue.Text) > CDbl(txtCash.Text) Then
                MsgBox("Insufficient cash! Please input correct amount.", vbExclamation)
                txtCash.Clear()
                Return
            End If
            If MsgBox(" Are you sure you want to save this payment?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = Nothing


                'THIS PART IS TO INSERT THE DATA TO TBLCART/SALES 
                With frmSales
                    Dim query As String = "INSERT INTO TBLPAYMENT (INVOICE_NO, AMOUNTDUE, SOLD_DATE, USERS, DISCOUNT, VAT, SUBTOTAL) VALUES ('" & .lblInvoice.Text & "', '" & CDbl(.lblDue.Text) & "', '" & sdate & "', '" & strUser & "', '" & CDbl(.lblDiscount.Text) & "', '" & CDbl(.lblVat.Text) & "', '" & CDbl(.lblSub.Text) & "')"
                    Dim cm As OracleCommand = New OracleCommand(query, cn)
                    cm.ExecuteNonQuery()

                    cn.Close()

                    MinusStockQty()

                    MsgBox("Payment has been Successfully saved.", vbInformation)
                    '.lblInvoice.Text = .GetInvoiceNo
                    .LoadCart()
                    .txtSearch.Focus()

                    'print
                    changelongpaper()
                    PPD.Document = PD
                    PPD.ShowDialog()

                    'Close settle form
                    Me.Dispose()

                    'Reset Summary
                    ResetDisplay()



                End With

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try



    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim change As Double = CDbl(txtCash.Text) - CDbl(lblDue.Text)
            If change < 0 Then
                lblChange.Text = "0.00"
            Else
                lblChange.Text = Format(change, "#,##0.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    'THE PURPOSE OF THIS PART IS TO STOCK OUT THE QUANTITY FROM PRODUCT
    Sub MinusStockQty()
        With frmSales
            For i = 0 To .DataGridView1.Rows.Count - 1
                cn.Open()
                cm = New OracleCommand("UPDATE PRDCTS SET QUANTITY = QUANTITY - " & CInt(.DataGridView1.Rows(i).Cells(7).Value.ToString) & "where PRODUCT_CODE like '" & .DataGridView1.Rows(i).Cells(3).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            Next

            cn.Open()
            cm = New OracleCommand("UPDATE TBLCART SET STATUS = 'Sold' WHERE INVOICE_NO LIKE '" & Trim(.lblInvoice.Text) & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

        End With
    End Sub

    Sub ResetDisplay()
        With frmSales
            .DataGridView1.Rows.Clear()
            .lblTotal.Text = "0.00"
            .lblDiscount.Text = "0.00"
            .lblSub.Text = "0.00"
            .lblVat.Text = "0.00"
            .lblDue.Text = "0.00"
            .btnProduct.Enabled = False
            .btnDiscount.Enabled = False
            .btnSettle.Enabled = False
        End With
    End Sub

    Private Sub frmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape

                Me.Dispose()
        End Select
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim sdate As String = Now.ToString("MMMM dd, yyyy")
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"

        'range from top
        e.Graphics.DrawString("Company Name", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Address of Company", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Telephone of Company", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Transac No", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(frmSales.lblInvoice.Text, f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Casher", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(strUser, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 85)

        e.Graphics.DrawString(sdate & " | " & frmSales.lblTime.Text, f8, Brushes.Black, 0, 95)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 105)

        Dim height As Integer 'DGV Position
        Dim i As Long
        With frmSales
            '.DataGridView1.AllowUserToAddRows = False
            If .DataGridView1.CurrentCell.Value Is Nothing Then
                Exit Sub
            Else
                For row As Integer = 0 To .DataGridView1.RowCount - 1
                    height += 15
                    e.Graphics.DrawString(.DataGridView1.Rows(row).Cells(7).Value.ToString, f8, Brushes.Black, 0, 100 + height)
                    e.Graphics.DrawString(.DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 25, 100 + height)


                    i = .DataGridView1.Rows(row).Cells(8).Value
                    .DataGridView1.Rows(row).Cells(8).Value = Format(i, "#,##0.00")

                    'This is the Total of Price
                    e.Graphics.DrawString(.DataGridView1.Rows(row).Cells(8).Value.ToString, f8, Brushes.Black, rightmargin, 100 + height, right)
                Next
            End If

            Dim height2 As Integer
            height2 = 110 + height

            Dim height3 As Integer
            height3 = 115 + height

            Dim height4 As Integer
            height4 = 125 + height

            Dim totalAmount As Double
            totalAmount = CDbl(lblDue.Text)

            Dim Payment As Double
            Payment = CDbl(txtCash.Text)

            Dim change As Double
            change = CDbl(lblChange.Text)


            e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
            e.Graphics.DrawString("Total: " & Format(totalAmount, "#,##0.00"), f10b, Brushes.Black, rightmargin, 20 + height2, right)
            e.Graphics.DrawString("Payment: " & Format(Payment, "#,##0.00"), f10b, Brushes.Black, rightmargin, 18 + height4, right)
            e.Graphics.DrawString("Change: " & Format(change, "#,##0.00"), f10b, Brushes.Black, rightmargin, 30 + height4, right)
            e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 80 + height2, center)
            e.Graphics.DrawString("~ Company Name ~", f10, Brushes.Black, centermargin, 95 + height2, center)
        End With
    End Sub
End Class