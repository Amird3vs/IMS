<Obsolete>
Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TBLCART._TBLCART' table. You can move, or remove it, as needed.
        Me.TBLCARTTableAdapter.Fill(Me.TBLCART._TBLCART)

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

        CbxCtgrySrch.SelectedIndex = 0
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
            cn.Open()
            Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART WHERE PRODUCT_CODE LIKE '%" & TxtSearch.Text.ToUpper & "%' OR DSCRTN LIKE '%" & TxtSearch.Text.ToUpper & "%'", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
        End Try
    End Sub

    Private Sub CbxCtgrySrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCtgrySrch.SelectedIndexChanged
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            If CbxCtgrySrch.SelectedIndex = 0 Then
                Dim commandd As New OracleClient.OracleCommand("Select * FROM TBLCART", cn)
                Dim sdaa As New OracleClient.OracleDataAdapter(commandd)
                Dim ddt As New DataTable

                sdaa.Fill(ddt)
                DataGridView1.DataSource = ddt
                cn.Close()
            Else
                Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART Where CATEGORY = '" + CbxCtgrySrch.Text.ToString() + "'", cn)
                Dim sda As New OracleClient.OracleDataAdapter(command)
                Dim dt As New DataTable

                sda.Fill(dt)
                DataGridView1.DataSource = dt
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CbxSttsSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSttsSearch.SelectedIndexChanged
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim commandd As New OracleClient.OracleCommand("Select * FROM TBLCART Where STATUS = '" + CbxSttsSearch.Text.ToString() + "'", cn)
            Dim sdaa As New OracleClient.OracleDataAdapter(commandd)
            Dim ddt As New DataTable

            sdaa.Fill(ddt)
            DataGridView1.DataSource = ddt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim command As New OracleClient.OracleCommand("SELECT * FROM TBLCART WHERE SOLD_DATE = '" & Format(Me.Guna2DateTimePicker1.Value, "dd-MMMM-yyyy") & "'", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btntdy_Click(sender As Object, e As EventArgs) Handles btntdy.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART WHERE SOLD_DATE = trunc(sysdate)", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnwkly_Click(sender As Object, e As EventArgs) Handles btnwkly.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART WHERE SOLD_DATE BETWEEN trunc(sysdate - 7) and trunc(sysdate)", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btmnth_Click(sender As Object, e As EventArgs) Handles btmnth.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART WHERE SOLD_DATE BETWEEN trunc(sysdate-30) AND trunc(sysdate)", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnUICust_Click(sender As Object, e As EventArgs) Handles btnUICust.Click
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.OK Then
            Me.Guna2Panel2.BackColor = Me.ColorDialog1.Color
            btnUICust.FillColor = Me.ColorDialog1.Color
            btnUICust.HoverState.FillColor = Me.ColorDialog1.Color
            DataGridView1.GridColor = Me.ColorDialog1.Color
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Me.ColorDialog1.Color
            PanelSearch.BorderColor = Me.ColorDialog1.Color
            Label12.ForeColor = Me.ColorDialog1.Color
            btntdy.FillColor = Me.ColorDialog1.Color
            btnwkly.FillColor = Me.ColorDialog1.Color
            btmnth.FillColor = Me.ColorDialog1.Color
            Me.Guna2DateTimePicker1.FillColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            Dim command As New OracleClient.OracleCommand("Select * FROM TBLCART", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class