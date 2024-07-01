Imports System.Data
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Imports System.Configuration
Imports MySql.Data.MySqlClient


Public Class LoginAndRegForm

    Dim cn As MySqlConnection

    Dim cmd As MySqlCommand

    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Public Sub Alert(ByVal msg As String, ByVal type As Form_Alert.enmType)
        Dim frm As Form_Alert = New Form_Alert()
        frm.showAlert(msg, type)
    End Sub

    <Obsolete>
    Private Sub BtnSbmt_Click(sender As Object, e As EventArgs) Handles BtnSbmt.Click
        Dim cn As MySqlConnection = New MySqlConnection("server=localhost;database=test;uid=root;pwd=;")
        cn.Open()

        If TxtBxEml.Text = "" Or TxtBxPwd.Text = "" Then
            Me.Alert("Please fill out the empty fields!!", Form_Alert.enmType.Info)
            Exit Sub
        End If

        Try
            Dim ql As String
            ql = "Select * From tbl_users where Email = '" & TxtBxEml.Text & "' and Password = '" & TxtBxPwd.Text & "'"
            cmd = New MySqlCommand(ql, cn)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows = True Then
                Dim Role As String = dr("Role").ToString

                If Role = "Administrator" Then
                    Dim AdminForm As New AdminForm
                    AdminForm.Show()
                    Me.TxtBxEml.Clear()
                    Me.TxtBxPwd.Clear()
                    Me.Close()
                    Me.Alert("Logged in as admin. Welcome!!", Form_Alert.enmType.Success)

                ElseIf Role = "Cashier" Then
                    frmSales.Show()
                    Me.Close()
                    Me.Alert("Logged in as cashier. Welcome!!", Form_Alert.enmType.Success)
                End If
            Else
                Me.Alert("Invalid username or password", Form_Alert.enmType.Error)
                TxtBxEml.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LoginAndRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBxPwd.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.CheckState = CheckState.Checked Then
            TxtBxPwd.UseSystemPasswordChar = False
        Else
            TxtBxPwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtBxEml_IconRightClick(sender As Object, e As EventArgs) Handles TxtBxEml.IconRightClick
        TxtBxEml.Clear()
    End Sub

    Private Sub TxtBxPwd_IconRightClick(sender As Object, e As EventArgs) Handles TxtBxPwd.IconRightClick
        TxtBxPwd.Clear()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class