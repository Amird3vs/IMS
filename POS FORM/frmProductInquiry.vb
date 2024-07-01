Imports System.Data.OracleClient
<Obsolete>
Public Class frmProductInquiry
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoadCartInquiry()
        Me.Dispose()
    End Sub

    Sub LoadCartInquiry()


        Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
        cm = New OracleCommand("Select * From PRDCTS WHERE QUANTITY <> 0 and (CATEGORY LIKE '" & txtSearch.Text & "%' or PRODUCT_CODE LIKE '" & txtSearch.Text & "%')", cn)
        dr = cm.ExecuteReader
            While dr.Read
                i += 1
            DataGridView1.Rows.Add(i, dr.Item("ID").ToString, dr.Item("PRODUCT_CODE").ToString, dr.Item("DESCTIPTION").ToString, dr.Item("CATEGORY").ToString, dr.Item("PRICE").ToString, dr.Item("QUANTITY").ToString)

        End While

        dr.Close()
        cn.Close()

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                LoadCartInquiry()
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        SearchProduct(txtSearch.Text)
    End Sub

    Private Sub frmProductInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
    End Sub

    Private Sub frmProductInquiry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colCart" Then
            SearchProduct(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)

            With frmSales
                .LoadCart()

            End With
        End If
    End Sub

    Sub SearchProduct(ByVal psearch As String)
        Try

            If psearch = String.Empty Then Return
            cn.Open()
            cm = New OracleCommand("SELECT*FROM PRDCTS where ID like '" & psearch & "'", cn)
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
End Class