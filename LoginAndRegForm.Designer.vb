<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAndRegForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BtnSbmt = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TxtBxPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBxEml = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 1
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Guna2CheckBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(540, 372)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(111, 20)
        Me.Guna2CheckBox1.TabIndex = 7
        Me.Guna2CheckBox1.Text = "Show Password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 1
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(995, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 24)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'BtnSbmt
        '
        Me.BtnSbmt.Animated = True
        Me.BtnSbmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSbmt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSbmt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSbmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSbmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSbmt.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnSbmt.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.BtnSbmt.ForeColor = System.Drawing.Color.White
        Me.BtnSbmt.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnSbmt.IndicateFocus = True
        Me.BtnSbmt.Location = New System.Drawing.Point(538, 411)
        Me.BtnSbmt.Name = "BtnSbmt"
        Me.BtnSbmt.Size = New System.Drawing.Size(422, 45)
        Me.BtnSbmt.TabIndex = 5
        Me.BtnSbmt.Text = "Sign in"
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TargetControl = Me
        Me.Guna2DragControl2.UseTransparentDrag = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(538, 202)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(422, 25)
        Me.Guna2Separator1.TabIndex = 11
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(549, 139)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(67, 36)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "User"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(549, 171)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(213, 36)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "Access Module"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(537, 138)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(7, 70)
        Me.Guna2Panel1.TabIndex = 14
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = Global.SEPROJ.My.Resources.Resources._318188186_1112049969459572_8561200344101957890_n
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(677, 580)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 15
        Me.Guna2PictureBox1.TabStop = False
        '
        'TxtBxPwd
        '
        Me.TxtBxPwd.Animated = True
        Me.TxtBxPwd.BorderColor = System.Drawing.Color.Black
        Me.TxtBxPwd.BorderThickness = 0
        Me.TxtBxPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBxPwd.DefaultText = ""
        Me.TxtBxPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBxPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBxPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxPwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TxtBxPwd.FocusedState.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.TxtBxPwd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtBxPwd.ForeColor = System.Drawing.Color.Black
        Me.TxtBxPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxPwd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TxtBxPwd.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxPwd.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxPwd.IconLeft = Global.SEPROJ.My.Resources.Resources.IconPassword
        Me.TxtBxPwd.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtBxPwd.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtBxPwd.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtBxPwd.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtBxPwd.Location = New System.Drawing.Point(538, 319)
        Me.TxtBxPwd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtBxPwd.Name = "TxtBxPwd"
        Me.TxtBxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBxPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxPwd.PlaceholderText = "Password"
        Me.TxtBxPwd.SelectedText = ""
        Me.TxtBxPwd.Size = New System.Drawing.Size(422, 47)
        Me.TxtBxPwd.TabIndex = 9
        Me.TxtBxPwd.TextOffset = New System.Drawing.Point(3, 0)
        '
        'TxtBxEml
        '
        Me.TxtBxEml.Animated = True
        Me.TxtBxEml.BorderColor = System.Drawing.Color.Black
        Me.TxtBxEml.BorderThickness = 0
        Me.TxtBxEml.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBxEml.DefaultText = ""
        Me.TxtBxEml.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBxEml.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBxEml.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxEml.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxEml.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TxtBxEml.FocusedState.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.TxtBxEml.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.TxtBxEml.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtBxEml.ForeColor = System.Drawing.Color.Black
        Me.TxtBxEml.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxEml.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TxtBxEml.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxEml.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxEml.IconLeft = Global.SEPROJ.My.Resources.Resources.IconEmail
        Me.TxtBxEml.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtBxEml.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtBxEml.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtBxEml.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtBxEml.Location = New System.Drawing.Point(538, 251)
        Me.TxtBxEml.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtBxEml.Name = "TxtBxEml"
        Me.TxtBxEml.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBxEml.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtBxEml.PlaceholderText = "Email"
        Me.TxtBxEml.SelectedText = ""
        Me.TxtBxEml.Size = New System.Drawing.Size(422, 47)
        Me.TxtBxEml.TabIndex = 10
        Me.TxtBxEml.TextOffset = New System.Drawing.Point(3, 0)
        '
        'LoginAndRegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 580)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.TxtBxPwd)
        Me.Controls.Add(Me.TxtBxEml)
        Me.Controls.Add(Me.BtnSbmt)
        Me.Controls.Add(Me.Guna2CheckBox1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginAndRegForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginAndRegForm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BtnSbmt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBxPwd As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents TxtBxEml As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
