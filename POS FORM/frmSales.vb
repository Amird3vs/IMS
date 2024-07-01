Imports System.Globalization
Imports System.Data.OracleClient

<Obsolete>
Public Class frmSales
    Public Shared frmSales
    'Dim connection As String = "Data Source=localhost;User ID=dtpos;Password=123;Unicode=True"
    'Dim con As New OracleConnection(connection)
    'Dim cmd As OracleCommand
    'Dim dr As OracleDataReader
    'Dim da As OracleDataAdapter
    'Dim dt As New DataTable
    'Dim str As String
    Dim x As String
    Dim rand As Random = New Random()

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If DataGridView1.RowCount > 0 Then Return
        GetInvoiceNo()
        txtSearch.Enabled = True
        btnProduct.Enabled = True
        btnDiscount.Enabled = False
        btnSettle.Enabled = False

        txtSearch.Focus()
        ResetDisplay()

    End Sub

    Sub ResetDisplay()

        lblDisplayTotal.Text = "0.00"
        lblTotal.Text = "0.00"
        lblDiscount.Text = "0.00"
        lblSub.Text = "0.00"
        lblVat.Text = "0.00"
        lblDue.Text = "0.00"

    End Sub

    Sub LoadCart()
        Try

            Dim _total As Double = 0, i As Integer = 0
            cn.Open()
            DataGridView1.Rows.Clear()
            cm = New OracleCommand("Select * From TBLCART where INVOICE_NO like '" & lblInvoice.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("ID").ToString, dr.Item("INVOICE_NO").ToString, dr.Item("PRODUCT_CODE").ToString, dr.Item("DSCRTN").ToString, dr.Item("CATEGORY").ToString, dr.Item("PRICE").ToString, dr.Item("QUANTITY").ToString, dr.Item("TOTAL").ToString)
                _total += CDbl(dr.Item("TOTAL").ToString)
            End While
            dr.Close()
            cn.Close()
            lblTotal.Text = Format(_total, "#,##0.00")
            lblSub.Text = Format(CDbl(lblTotal.Text) - CDbl(lblDiscount.Text), "#,##0.00")
            lblVat.Text = Format(CDbl(lblSub.Text) * GetVat(), "#,##0.00")
            lblDue.Text = Format(CDbl(lblSub.Text) - CDbl(lblVat.Text), "#,##0.00")
            lblDisplayTotal.Text = lblDue.Text
            If DataGridView1.RowCount > 0 Then btnSettle.Enabled = True Else btnSettle.Enabled = False
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
        txtSearch.Clear()

    End Sub

    Sub GetInvoiceNo()
        For y As Integer = 2 To 7
            x = 2022
            If y = 2 Then
                x += "2022"
            End If
        Next
        For y As Integer = 1 To 7
            x += Convert.ToString(rand.Next(0, 8))
        Next

        lblInvoice.Text = x

        If lblInvoice.Text = x Then
            x = Nothing
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lblDate.Text = Now.ToString("MM-dd-yyyy")
        lblTime.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Sub SearchProduct(ByVal psearch As String)
        Try
            cn.Open()
            If psearch = String.Empty Then Return
            cm = New OracleCommand("SELECT*FROM PRDCTS where PRODUCT_CODE like '" & psearch & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                With frmQty
                    .lblDescription.Text = dr.Item("DESCTIPTION").ToString
                    .lblCategory.Text = dr.Item("CATEGORY").ToString
                    .lblPrice.Text = dr.Item("PRICE").ToString
                    .lblPCODE.Text = dr.Item("PRODUCT_CODE").ToString
                    .lblID.Text = dr.Item("ID").ToString
                    dr.Close()
                    cn.Close()
                    .ShowDialog()
                End With
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProduct(txtSearch.Text.ToUpper())
    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True


        'THIS CODE APPEND DATE TO TXTDATE
        'tmrTimer
        Dim dt As String = ""
        Dim dtfInfo As DateTimeFormatInfo
        Dim dtStyle As String = "dd-MMMM-yyyy"

        dtfInfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtStyle, dtfInfo)
        lblDate.Text = dt
    End Sub

    Private Sub btnSettle_Click(sender As Object, e As EventArgs) Handles btnSettle.Click
        With frmSettle
            txtSearch.Clear()
            .lblDue.Text = lblDue.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub frmSales_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btnNew_Click(sender, e)
            Case Keys.F2
                btnProduct_Click(sender, e)
            Case Keys.F3
                btnDiscount_Click(sender, e)
            Case Keys.F4
                btnSettle_Click(sender, e)
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colRemove" Then
            If MsgBox("Remove this item? Please confirm.", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OracleCommand("Delete from TBLCART where ID like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Item has been successfully removed.", vbInformation)
                LoadCart()
            End If
        End If
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        With frmDiscount
            .GetDiscount()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With frmProductInquiry
            .LoadCartInquiry()
            .ShowDialog()
        End With
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' The following example requires that Option Infer be set to On.

        ' Define the message you want to see inside the message box.
        Dim msg = "Do you want to continue?"

        ' Define a title for the message box.
        Dim title = "LOGOUT"

        ' Now define a style for the message box. In this example, the
        ' message box will have Yes and No buttons, the default will be
        ' the No button, and a Critical Message icon will be present.
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical

        ' Display the message box and save the response, Yes or No.
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then

            Me.Close()
        Else

        End If
    End Sub
End Class

