Imports System.Data.OracleClient
<Obsolete>
Public Class frmQty
    Private Sub frmQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtQty.Focus()
        txtQty.SelectionStart = 0
        txtQty.SelectionLength = txtQty.Text.Length
    End Sub

    Private Sub frmQty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                With frmSales
                    .txtSearch.Focus()
                    .txtSearch.SelectionStart = 0
                    .txtSearch.SelectionLength = .txtSearch.Text.Length
                End With
                Me.Dispose()
        End Select
    End Sub

    Function GetStockAvailable(ByVal sql As String) As Integer
        cn.Open()
        cm = New OracleCommand(sql, cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            GetStockAvailable = CInt(dr.Item("QUANTITY").ToString)
        Else
            GetStockAvailable = 0

        End If
        dr.Close()
        cn.Close()
        Return GetStockAvailable
    End Function
    Sub AddToCart()
        Try
            If txtQty.Text = String.Empty Or txtQty.Text = "0" Then Return
            Dim sdate As String = Now.ToString("dd-MM-yyyy")
            cn.Open()
            cm = New OracleCommand("Select * FROM PRDCTS WHERE ID LIKE '" & lblID.Text & "' and QUANTITY >= " & CInt(txtQty.Text) & "", cn)
            dr = cm.ExecuteReader
            dr.Read()


            If dr.HasRows Then
                With frmSales


                    Dim query As String = "INSERT INTO TBLCART (INVOICE_NO, PRODUCT_CODE, DSCRTN, CATEGORY, PRICE, QUANTITY, TOTAL, USERS, STATUS, SOLD_DATE) VALUES ('" & .lblInvoice.Text & "', '" & lblPCODE.Text & "', '" & lblDescription.Text & "', '" & lblCategory.Text & "', '" & CInt(lblPrice.Text) & "', '" & CInt(txtQty.Text) & "', '" & CInt(lblTotal.Text) & "', '" & strUser & "', '" & strSTATUS & "', '" & .lblDate.Text & "')"
                    Dim cm As OracleCommand = New OracleCommand(query, cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    cn.Open()
                    cm = New OracleCommand("UPDATE TBLCART SET TOTAL = PRICE * QUANTITY WHERE INVOICE_NO LIKE '" & .lblInvoice.Text & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    .txtSearch.Focus()
                    .txtSearch.SelectionStart = 0
                    .txtSearch.SelectionLength = .txtSearch.Text.Length

                    .LoadCart()
                    .btnDiscount.Enabled = True
                End With
                Me.Dispose()
                dr.Close()
                cn.Close()
                Return
            Else
                dr.Close()
                cn.Close()
                MsgBox("Unable to proceed. Remaining stock " & GetStockAvailable("Select * FROM PRDCTS WHERE ID LIKE '" & lblID.Text & "'") & ".", vbCritical)
                txtQty.Focus()
                txtQty.SelectionStart = 0
                txtQty.SelectionLength = txtQty.Text.Length
                Return
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        frmSales.txtSearch.Clear()
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                AddToCart()
            Case 48 To 57
            Case 8

            Case Else
                e.Handled = True
        End Select
    End Sub
End Class