Imports System.Data
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Imports System.Data.OracleClient
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Products

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

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.PRDCTS' table. You can move, or remove it, as needed.
        Me.PRDCTSTableAdapter.Fill(Me.DataSet3.PRDCTS)
        'TODO: This line of code loads data into the 'DataSet3.PRDCTS' table. You can move, or remove it, as needed.
        Me.PRDCTSTableAdapter.Fill(Me.DataSet3.PRDCTS)

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

        If TxtPrdctID.Text = "" Or TxtPrdctCde.Text = "" Or TxtPrdctDescrptn.Text = "" Or TxtPrdctPrice.Text = "" Then
            BtnSave.Enabled = False
            BtnRmve.Enabled = False
        End If
    End Sub

    <Obsolete>
    Private Sub putData(Query As String)
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
        Dim command As New OracleClient.OracleCommand("Select * FROM PRDCTS", cn)
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
            If TxtPrdctCde.Text = "" Or TxtPrdctDescrptn.Text = "" Then
                Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
                Exit Sub
            Else
                Dim ql As String
                ql = "Select * From PRDCTS where PRODUCT_CODE = '" & TxtPrdctCde.Text & "'"
                cmd = New OracleClient.OracleCommand(ql, cn)
                Dim dr As OracleClient.OracleDataReader
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows = True Then
                    Me.Alert("Product already exist!!", Form_Alert.enmType.Info)
                Else
                    putData("INSERT INTO PRDCTS (PRODUCT_CODE, CATEGORY, DESCTIPTION, PRICE, QUANTITY, EXPIRY_DATE, REORDER) VALUES ('" & TxtPrdctCde.Text & "', '" & Cbxctgry.SelectedItem.ToString & "', '" & TxtPrdctDescrptn.Text & "', '" & TxtPrdctPrice.Text & "', 0, '" & txtxpry.Text & "', '" & txtOdrLvl.Text & "')")
                    Me.Alert("Product added successfully!!", Form_Alert.enmType.Success)
                    TxtPrdctID.Clear()
                    TxtPrdctCde.Clear()
                    TxtPrdctDescrptn.Clear()
                    TxtPrdctPrice.Clear()
                    txtOdrLvl.Clear()
                    Cbxctgry.SelectedIndex = -1
                    txtxpry.Clear()
                    LoadInGridview()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
        Finally
            cn.Close()
        End Try
    End Sub

    <Obsolete>
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        If TxtPrdctCde.Text = "" Or TxtPrdctDescrptn.Text = "" Or TxtPrdctPrice.Text = "" Then
            Me.Alert("Fields are currently empty!!", Form_Alert.enmType.Info)
        Else
            TxtPrdctID.Clear()
            TxtPrdctPrice.Clear()
            TxtPrdctDescrptn.Clear()
            TxtPrdctCde.Clear()
            txtOdrLvl.Clear()
            Cbxctgry.SelectedIndex = -1
            txtxpry.Clear()
            BtnRmve.Enabled = False
            BtnSave.Enabled = False
        End If
    End Sub

    <Obsolete>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()

        Try
            If TxtPrdctCde.Text = "" Or TxtPrdctDescrptn.Text = "" Then
                Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
                Exit Sub
            End If

            Dim command As New OracleClient.OracleCommand("Update PRDCTS SET PRODUCT_CODE = '" & TxtPrdctCde.Text & "', DESCTIPTION = '" & TxtPrdctDescrptn.Text & "', CATEGORY = '" & Cbxctgry.Text & "', PRICE = '" & TxtPrdctPrice.Text & "', EXPIRY_DATE = '" & txtxpry.Text & "', REORDER = '" & txtOdrLvl.Text & "' Where  ID = '" & TxtPrdctID.Text & "'", cn)
            command.ExecuteNonQuery()
            TxtSearch.Clear()
            TxtSearch.Focus()
            Me.Alert("Product info updated!", Form_Alert.enmType.Success)
            LoadInGridview()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
        Finally
            cn.Close()
        End Try
    End Sub

    <Obsolete>
    Private Sub BtnRmve_Click(sender As Object, e As EventArgs) Handles BtnRmve.Click
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()

        If TxtPrdctCde.Text = "" Or TxtPrdctDescrptn.Text = "" Or TxtPrdctPrice.Text = "" Then
            Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "CodeWithkh4n.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.No Then
            Exit Sub

        ElseIf result = DialogResult.Yes Then
            Try

                Dim command As New OracleClient.OracleCommand("Delete from PRDCTS Where ID = '" & TxtPrdctID.Text & "'", cn)
                command.ExecuteNonQuery()
                LoadInGridview()
                TxtSearch.Clear()
                TxtSearch.Focus()
                TxtPrdctID.Clear()
                TxtPrdctPrice.Clear()
                TxtPrdctDescrptn.Clear()
                TxtPrdctCde.Clear()
                txtOdrLvl.Clear()
                Cbxctgry.SelectedIndex = -1
                txtxpry.Clear()
                Me.Alert("Product removed successfully!!", Form_Alert.enmType.Success)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "CodeWithKhan")
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TxtPrdctID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtPrdctCde.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Cbxctgry.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TxtPrdctDescrptn.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TxtPrdctPrice.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtxpry.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtOdrLvl.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        BtnSave.Enabled = True
        BtnRmve.Enabled = True
    End Sub

    Private Sub TxtPrdctID_IconRightClick(sender As Object, e As EventArgs) Handles TxtPrdctID.IconRightClick
        TxtPrdctID.Clear()
    End Sub

    Private Sub TxtPrdctCde_IconRightClick(sender As Object, e As EventArgs) Handles TxtPrdctCde.IconRightClick
        TxtPrdctCde.Clear()
    End Sub

    Private Sub TxtPrdctDescrptn_IconRightClick(sender As Object, e As EventArgs) Handles TxtPrdctDescrptn.IconRightClick
        TxtPrdctDescrptn.Clear()
    End Sub

    Private Sub TxtPrdctPrice_IconRightClick(sender As Object, e As EventArgs) Handles TxtPrdctPrice.IconRightClick
        TxtPrdctPrice.Clear()
    End Sub

    <Obsolete>
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
            cn.Open()
            Dim command As New OracleClient.OracleCommand("Select * FROM PRDCTS WHERE PRODUCT_CODE LIKE '%" & TxtSearch.Text.ToUpper & "%' OR DESCTIPTION LIKE '%" & TxtSearch.Text.ToUpper & "%'", cn)
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

    <Obsolete>
    Private Sub CbxCtgrySrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCtgrySrch.SelectedIndexChanged
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Try
            If CbxCtgrySrch.SelectedIndex = 0 Then
                Dim commandd As New OracleClient.OracleCommand("Select * FROM PRDCTS", cn)
                Dim sdaa As New OracleClient.OracleDataAdapter(commandd)
                Dim ddt As New DataTable

                sdaa.Fill(ddt)
                DataGridView1.DataSource = ddt
                cn.Close()
            Else
                Dim command As New OracleClient.OracleCommand("Select * FROM PRDCTS Where CATEGORY = '" + CbxCtgrySrch.Text.ToString() + "'", cn)
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
    Private Sub TxtSearch_IconRightClick(sender As Object, e As EventArgs) Handles TxtSearch.IconRightClick
        TxtSearch.Clear()
    End Sub

    Private Sub TxtPrdctPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrdctPrice.KeyPress
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
            Me.Guna2Panel1.BackColor = Me.ColorDialog1.Color
            Me.Guna2Panel2.BackColor = Me.ColorDialog1.Color
            Me.Guna2GradientPanel2.BorderColor = Me.ColorDialog1.Color
            btnUICust.FillColor = Me.ColorDialog1.Color
            btnUICust.HoverState.FillColor = Me.ColorDialog1.Color
            DataGridView1.GridColor = Me.ColorDialog1.Color
            PanelSearch.BorderColor = Me.ColorDialog1.Color
            Label12.ForeColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub txtOdrLvl_IconRightClick(sender As Object, e As EventArgs) Handles txtOdrLvl.IconRightClick
        txtOdrLvl.Clear()
    End Sub

    Private Sub txtOdrLvl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOdrLvl.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Field will accept numbers only", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class