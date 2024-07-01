Public Class Stocks

    <Obsolete>
    Dim cn As OracleClient.OracleConnection
    <Obsolete>
    Dim cmd As OracleClient.OracleCommand
    <Obsolete>
    Dim da As OracleClient.OracleDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet

    Public Sub Alert(ByVal msg As String, ByVal type As Form_Alert.enmType)
        Dim frm As Form_Alert = New Form_Alert()
        frm.showAlert(msg, type)
    End Sub

    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4.PRDCTS' table. You can move, or remove it, as needed.
        Me.PRDCTSTableAdapter.Fill(Me.DataSet4.PRDCTS)

        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.GridColor = Color.Teal
        DataGridView1.DefaultCellStyle.Font = New Font("Century Gothic", 8)
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 128)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.RowsDefaultCellStyle.ForeColor = Color.Black
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        DataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.GridColor = Color.Teal
        DataGridView2.DefaultCellStyle.Font = New Font("Century Gothic", 8)
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 128)
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Timer1.Enabled = True
    End Sub

    <Obsolete>
    Private Sub LoadInGridview()
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Dim command As New OracleClient.OracleCommand("Select * FROM PRDCTS", cn)
        Dim sda As New OracleClient.OracleDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub clearall()
        TxtPrdctDscrptn.Clear()
        TxtPrdctCde.Clear()
        TxtQuantity.Clear()
        TxtBxID.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TxtPrdctCde.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TxtPrdctDscrptn.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TxtBxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        BtnAdd.Enabled = True
        Btnclear.Enabled = True
        TxtQuantity.ReadOnly = False
        TxtQuantity.Focus()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtQuantity.Text = "" Then
            TxtQuantity.Focus()
            Me.Alert("Please fill out quantity field!!", Form_Alert.enmType.Info)
            Exit Sub
        End If

        If (DataGridView2.Rows.Count > 0) Then
            For i = 0 To DataGridView2.Rows.Count - 1
                If (DataGridView2.Rows(i).Cells("ID").Value = TxtBxID.Text) Then
                    DataGridView2.Rows(i).Cells("QUANTITY").Value += CInt(TxtQuantity.Text)
                    clearall()
                    Exit Sub
                End If
            Next
        End If

        DataGridView2.Rows.Add(TxtBxID.Text, TxtPrdctCde.Text, TxtPrdctDscrptn.Text, TxtQuantity.Text, txtDate.Text)
        clearall()
        BtnAdd.Enabled = False
        Btnclear.Enabled = False
        BtnConfirm.Enabled = True
        TxtQuantity.ReadOnly = True
    End Sub

    <Obsolete>
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()

        Dim result As DialogResult = MessageBox.Show("Do you sure you want to proceed?", "CodeWithkh4n.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Try
                Dim i As Integer
                For i = 0 To DataGridView2.Rows.Count - 1

                    Dim command As New OracleClient.OracleCommand("UPDATE PRDCTS SET QUANTITY = QUANTITY + '" & DataGridView2.Rows(i).Cells(3).Value & "' WHERE ID = '" & DataGridView2.Rows(i).Cells(0).Value & "'", cn)
                    command.ExecuteNonQuery()

                    Dim cmd As New OracleClient.OracleCommand("INSERT INTO STOCK_INS (PRODUCT_CODE, DESCRIPTION, STOCK_IN_DATE, QUANTITY) VALUES('" & DataGridView2.Rows(i).Cells(1).Value & "', '" & DataGridView2.Rows(i).Cells(2).Value & "', '" & DataGridView2.Rows(i).Cells(4).Value & "', '" & DataGridView2.Rows(i).Cells(3).Value & "')", cn)
                    cmd.ExecuteNonQuery()

                Next
                DataGridView2.Rows.Clear()
                LoadInGridview()
                BtnConfirm.Enabled = False
                Me.Alert("Product/s quantity updated!", Form_Alert.enmType.Success)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        clearall()
        BtnAdd.Enabled = False
        Btnclear.Enabled = False
    End Sub

    <Obsolete>
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
            cn.Open()
            Dim command As New OracleClient.OracleCommand("Select * FROM PRDCTS WHERE PRODUCT_CODE Like '%" & TxtSearch.Text.ToUpper & "%' OR DESCTIPTION LIKE '%" & TxtSearch.Text.ToUpper & "%'", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                Me.Alert("No record found", Form_Alert.enmType.Info)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
        End Try
    End Sub

    Private Sub TxtSearch_IconRightClick(sender As Object, e As EventArgs) Handles TxtSearch.IconRightClick
        TxtSearch.Clear()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
        If colName = "DELETE" Then
            DataGridView2.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub TxtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Field will accept numbers only", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUICust_Click(sender As Object, e As EventArgs) Handles btnUICust.Click
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.OK Then
            Me.Guna2Panel1.BorderColor = Me.ColorDialog1.Color
            Me.Guna2Panel2.BackColor = Me.ColorDialog1.Color
            Me.Guna2Panel3.BorderColor = Me.ColorDialog1.Color
            Me.Label2.ForeColor = Me.ColorDialog1.Color
            Me.Label1.ForeColor = Me.ColorDialog1.Color
            btnUICust.FillColor = Me.ColorDialog1.Color
            btnUICust.HoverState.FillColor = Me.ColorDialog1.Color
            DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Me.ColorDialog1.Color
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Me.ColorDialog1.Color
            PanelSearch.BorderColor = Me.ColorDialog1.Color
            Guna2Panel4.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDate.Text = Date.Now.ToString("dd-MMM-yyyy")
    End Sub

    <Obsolete>
    Private Sub btnStockIns_Click(sender As Object, e As EventArgs) 
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim cmdd As New OracleClient.OracleCommand("DELETE FROM STOCK_INS WHERE PRODUCT_CODE IS NULL", cn)
            cmdd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
End Class