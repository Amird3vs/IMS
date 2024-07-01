Imports System.Data
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Imports System.Data.OracleClient
Imports System.Configuration
Imports System.Data.SqlClient
Public Class Users

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

    <Obsolete>
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.STAFF' table. You can move, or remove it, as needed.
        Me.STAFFTableAdapter.Fill(Me.DataSet2.STAFF)

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
        CbxRleSrch.SelectedIndex = 0

        If TxtID.Text = "" And TxtFname.Text = "" And TxtLname.Text = "" And TxtEml.Text = "" And TxtPsswrd.Text = "" And TxtAddr.Text = "" And TxtCntct.Text = "" Then
            BtnUpdt.Enabled = False
            BtnDlt.Enabled = False
        End If
    End Sub

    <Obsolete>
    Private Sub putdata(Query As String)
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        cmd = New OracleClient.OracleCommand(Query, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    <Obsolete>
    Private Sub LoadInGridview()
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Dim command As New OracleClient.OracleCommand("Select * FROM Staff", cn)
        Dim sda As New OracleClient.OracleDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    <Obsolete>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            If TxtFname.Text = "" Or TxtLname.Text = "" Then
                Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
                Exit Sub
            Else
                Dim ql As String
                ql = "Select * From Staff where FIRSTNAME = '" & TxtFname.Text & "' and LASTNAME = '" & TxtLname.Text & "'"
                cmd = New OracleClient.OracleCommand(ql, cn)
                Dim dr As OracleClient.OracleDataReader
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows = True Then
                    Me.Alert("User already exist!!", Form_Alert.enmType.Info)
                Else
                    putdata("INSERT INTO Staff (Firstname, Lastname, Address, ContactNum, Role, Email, Password) VALUES ('" & TxtFname.Text & "', '" & TxtLname.Text & "', '" & TxtAddr.Text & "', '" & TxtCntct.Text & "', '" & CbxRle.SelectedItem.ToString & "', '" & TxtEml.Text & "', '" & TxtPsswrd.Text & "')")
                    Me.Alert("Product added successfully!!", Form_Alert.enmType.Success)
                    TxtID.Clear()
                    TxtFname.Clear()
                    TxtLname.Clear()
                    TxtAddr.Clear()
                    TxtCntct.Clear()
                    CbxRle.Items.Clear()
                    TxtEml.Clear()
                    TxtPsswrd.Clear()
                    LoadInGridview()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKh4n.")
        Finally
            cn.Close()
        End Try
    End Sub

    <Obsolete>
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        If TxtFname.Text = "" Or TxtLname.Text = "" Or TxtEml.Text = "" Or TxtPsswrd.Text = "" Or TxtAddr.Text = "" Or TxtCntct.Text = "" Then
            Me.Alert("Fields are currently empty!!", Form_Alert.enmType.Info)
        Else
            TxtID.Clear()
            TxtFname.Clear()
            TxtLname.Clear()
            TxtAddr.Clear()
            TxtCntct.Clear()
            CbxRle.SelectedIndex = -1
            TxtEml.Clear()
            TxtPsswrd.Clear()
            BtnUpdt.Enabled = False
            BtnDlt.Enabled = False
        End If
    End Sub

    <Obsolete>
    Private Sub BtnUpdt_Click(sender As Object, e As EventArgs) Handles BtnUpdt.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()

        Try

            If TxtFname.Text = "" Or TxtLname.Text = "" Then
                Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
                Exit Sub
            End If

            Dim command As New OracleClient.OracleCommand("Update Staff SET ID = '" & TxtID.Text & "', Firstname = '" & TxtFname.Text & "', Lastname = '" & TxtLname.Text & "', Address = '" & TxtAddr.Text & "', ContactNum = '" & TxtCntct.Text & "', Role = '" & CbxRle.SelectedItem.ToString & "', Email = '" & TxtEml.Text & "', Password = '" & TxtPsswrd.Text & "' Where  ID = '" & TxtID.Text & "'", cn)
            command.ExecuteNonQuery()
            Me.Alert("User info updated!", Form_Alert.enmType.Success)
            LoadInGridview()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub

    <Obsolete>
    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()

        If TxtFname.Text = "" Or TxtLname.Text = "" Then
            Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "CodeWithkh4n.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Try

                Dim command As New OracleClient.OracleCommand("Delete from Staff Where ID = '" & TxtID.Text & "'", cn)
                command.ExecuteNonQuery()
                Me.Alert("Product removed successfully!!", Form_Alert.enmType.Success)
                LoadInGridview()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    <Obsolete>
    Private Sub CbxRleSrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxRleSrch.SelectedIndexChanged
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            If CbxRleSrch.SelectedIndex = 0 Then
                Dim commandd As New OracleClient.OracleCommand("Select * FROM Staff", cn)
                Dim sdaa As New OracleClient.OracleDataAdapter(commandd)
                Dim ddt As New DataTable

                sdaa.Fill(ddt)
                DataGridView1.DataSource = ddt
                cn.Close()
            Else
                Dim command As New OracleClient.OracleCommand("Select * FROM Staff Where Role = '" + CbxRleSrch.Text.ToString() + "'", cn)
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TxtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtFname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TxtLname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TxtAddr.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TxtCntct.Text = DataGridView1.CurrentRow.Cells(4).Value
        CbxRle.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TxtEml.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        TxtPsswrd.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        BtnUpdt.Enabled = True
        BtnDlt.Enabled = True
    End Sub

    Private Sub TxtPsswrd_IconRightClick(sender As Object, e As EventArgs) Handles TxtPsswrd.IconRightClick
        TxtPsswrd.Clear()
    End Sub

    Private Sub TxtFname_IconRightClick(sender As Object, e As EventArgs) Handles TxtFname.IconRightClick
        TxtFname.Clear()
    End Sub

    Private Sub TxtLname_IconRightClick(sender As Object, e As EventArgs) Handles TxtLname.IconRightClick
        TxtLname.Clear()
    End Sub

    Private Sub TxtEml_IconRightClick(sender As Object, e As EventArgs) Handles TxtEml.IconRightClick
        TxtEml.Clear()
    End Sub

    Private Sub TxtAddr_IconRightClick(sender As Object, e As EventArgs) Handles TxtAddr.IconRightClick
        TxtAddr.Clear()
    End Sub

    Private Sub TxtCntct_IconRightClick(sender As Object, e As EventArgs) Handles TxtCntct.IconRightClick
        TxtCntct.Clear()
    End Sub

    <Obsolete>
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
            cn.Open()
            Dim command As New OracleClient.OracleCommand("Select * FROM Staff WHERE FIRSTNAME LIKE '%" & TxtSearch.Text & "%' OR LASTNAME LIKE '%" & TxtSearch.Text & "%'", cn)
            Dim da As New OracleClient.OracleDataAdapter(command)
            Dim dt As New DataTable

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No record found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtSearch_IconRightClick(sender As Object, e As EventArgs) Handles TxtSearch.IconRightClick
        TxtSearch.Clear()
    End Sub

    Private Sub TxtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Field will accept letters only", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TxtLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Field will accept letters only", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUICust_Click(sender As Object, e As EventArgs) Handles btnUICust.Click
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.OK Then
            Me.Guna2Panel2.BackColor = Me.ColorDialog1.Color
            Me.Guna2GradientPanel2.BorderColor = Me.ColorDialog1.Color
            btnUICust.FillColor = Me.ColorDialog1.Color
            btnUICust.HoverState.FillColor = Me.ColorDialog1.Color
            DataGridView1.GridColor = Me.ColorDialog1.Color
            PanelSearch.BorderColor = Me.ColorDialog1.Color
            Label12.ForeColor = Me.ColorDialog1.Color
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Me.ColorDialog1.Color
            Me.PanelForm.BackColor = Me.ColorDialog1.Color
            DataGridView1.GridColor = Me.ColorDialog1.Color
        End If
    End Sub
End Class