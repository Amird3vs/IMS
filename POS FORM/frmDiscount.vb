Imports System.Data.OracleClient

<Obsolete>
Public Class frmDiscount
    Private Sub frmDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True


    End Sub

    Private Sub frmDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()

        End Select
    End Sub

    Sub GetDiscount()
        cn.Open()
        cm = New OracleCommand("Select * from TBLDISCOUNT", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cboDesc.Items.Add(dr.Item(1).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub cboDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDesc.SelectedIndexChanged
        cn.Open()
        cm = New OracleCommand("Select * From TBLDISCOUNT where DESC_DISC like '" & cboDesc.Text & "'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtDiscount.Text = dr.Item(2).ToString
        Else
            txtDiscount.Text = 0
        End If
        cn.Close()

    End Sub

    Private Sub cboDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDesc.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        'If IS_EMPTY(cboDesc) = True Then Return
        With frmSales
            Dim discount As Double
            discount = CDbl(.lblTotal.Text) * CDbl(txtDiscount.Text)
            .lblDiscount.Text = Format(discount, "#,##0.00")
            .LoadCart()
            Me.Dispose()
        End With
    End Sub
End Class