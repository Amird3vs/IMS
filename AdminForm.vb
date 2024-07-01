<Obsolete>
Public Class AdminForm
    Public Shared AdminForm
    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        PanelCover.Visible = True
        btn_show.Visible = False
        btn_hide.Visible = True
        PanelNav.Visible = False
        PanelNav.Width = 237
        Guna2Transition1.ShowSync(PanelNav)
    End Sub

    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        PanelNav.Visible = False
        btn_hide.Visible = False
        btn_show.Visible = True
        PanelNav.Width = 47
        Guna2Transition1.ShowSync(PanelNav)
        PanelCover.Visible = False
    End Sub

    Public Sub loadform(ByVal form As Object)
        If Me.mainpanel.Controls.Count > 0 Then Me.mainpanel.Controls.RemoveAt(0)
        Dim f As Form = TryCast(form, Form)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        Me.mainpanel.Controls.Add(f)
        Me.mainpanel.Tag = f
        f.Show()
    End Sub

    Private Sub BtnDash_Click(sender As Object, e As EventArgs) Handles BtnDash.Click
        loadform(New Dashboard())
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        loadform(New Products())
    End Sub

    Private Sub BtnSls_Click(sender As Object, e As EventArgs) Handles BtnSls.Click
        loadform(New Sales())
    End Sub

    Private Sub BtnPOS_Click(sender As Object, e As EventArgs) Handles BtnPOS.Click
        frmSales.Show()
    End Sub

    Private Sub BtnUsrs_Click(sender As Object, e As EventArgs) Handles BtnUsrs.Click
        loadform(New Users())
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim LoginAndRegForm As New LoginAndRegForm
        LoginAndRegForm.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        loadform(New Stocks())
    End Sub

    Private Sub AdminClose_Click(sender As Object, e As EventArgs) Handles AdminClose.Click
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.OK Then
            Me.BackColor = Me.ColorDialog1.Color
            Me.BackColor = Me.ColorDialog1.Color
            Me.PanelNav.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadform(New Dashboard())
    End Sub
End Class
