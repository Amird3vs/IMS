<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelNav = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelCover = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_show = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_hide = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BtnUsrs = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSls = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPOS = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnProducts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDash = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.mainpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AdminClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnLogout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PanelNav.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PanelNav
        '
        Me.PanelNav.BackColor = System.Drawing.Color.White
        Me.PanelNav.Controls.Add(Me.PanelCover)
        Me.PanelNav.Controls.Add(Me.Guna2GradientButton1)
        Me.PanelNav.Controls.Add(Me.Guna2Panel3)
        Me.PanelNav.Controls.Add(Me.btn_show)
        Me.PanelNav.Controls.Add(Me.btn_hide)
        Me.PanelNav.Controls.Add(Me.BtnLogout)
        Me.PanelNav.Controls.Add(Me.Guna2Separator1)
        Me.PanelNav.Controls.Add(Me.BtnUsrs)
        Me.PanelNav.Controls.Add(Me.BtnSls)
        Me.PanelNav.Controls.Add(Me.BtnPOS)
        Me.PanelNav.Controls.Add(Me.BtnProducts)
        Me.PanelNav.Controls.Add(Me.BtnDash)
        Me.Guna2Transition1.SetDecoration(Me.PanelNav, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(237, 730)
        Me.PanelNav.TabIndex = 0
        '
        'PanelCover
        '
        Me.Guna2Transition1.SetDecoration(Me.PanelCover, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelCover.Location = New System.Drawing.Point(10, 682)
        Me.PanelCover.Name = "PanelCover"
        Me.PanelCover.Size = New System.Drawing.Size(28, 36)
        Me.PanelCover.TabIndex = 0
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Teal
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(2, 199)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(235, 45)
        Me.Guna2GradientButton1.TabIndex = 9
        Me.Guna2GradientButton1.Text = "Inventory"
        Me.Guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(237, 68)
        Me.Guna2Panel3.TabIndex = 8
        '
        'btn_show
        '
        Me.btn_show.Animated = True
        Me.btn_show.BackColor = System.Drawing.Color.Transparent
        Me.btn_show.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btn_show.CustomImages.Image = Global.SEPROJ.My.Resources.Resources.right
        Me.Guna2Transition1.SetDecoration(Me.btn_show, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_show.FillColor = System.Drawing.Color.White
        Me.btn_show.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Location = New System.Drawing.Point(24, 572)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_show.Size = New System.Drawing.Size(35, 35)
        Me.btn_show.TabIndex = 4
        Me.btn_show.UseTransparentBackground = True
        Me.btn_show.Visible = False
        '
        'btn_hide
        '
        Me.btn_hide.Animated = True
        Me.btn_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn_hide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btn_hide.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2Transition1.SetDecoration(Me.btn_hide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_hide.FillColor = System.Drawing.Color.White
        Me.btn_hide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_hide.ForeColor = System.Drawing.Color.White
        Me.btn_hide.Location = New System.Drawing.Point(214, 572)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_hide.Size = New System.Drawing.Size(35, 35)
        Me.btn_hide.TabIndex = 2
        Me.btn_hide.UseTransparentBackground = True
        '
        'Guna2Separator1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.Location = New System.Drawing.Point(10, 585)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(197, 10)
        Me.Guna2Separator1.TabIndex = 6
        '
        'BtnUsrs
        '
        Me.BtnUsrs.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.BtnUsrs.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnUsrs.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Transition1.SetDecoration(Me.BtnUsrs, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUsrs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsrs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsrs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsrs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsrs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUsrs.FillColor = System.Drawing.Color.Empty
        Me.BtnUsrs.FillColor2 = System.Drawing.Color.Empty
        Me.BtnUsrs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnUsrs.ForeColor = System.Drawing.Color.Black
        Me.BtnUsrs.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnUsrs.HoverState.FillColor2 = System.Drawing.Color.White
        Me.BtnUsrs.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsrs.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnUsrs.IndicateFocus = True
        Me.BtnUsrs.Location = New System.Drawing.Point(2, 343)
        Me.BtnUsrs.Name = "BtnUsrs"
        Me.BtnUsrs.Size = New System.Drawing.Size(235, 45)
        Me.BtnUsrs.TabIndex = 5
        Me.BtnUsrs.Text = "User accounts"
        Me.BtnUsrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnUsrs.TextOffset = New System.Drawing.Point(50, 0)
        '
        'BtnSls
        '
        Me.BtnSls.CustomImages.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.BtnSls.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSls.CustomImages.ImageSize = New System.Drawing.Size(28, 28)
        Me.Guna2Transition1.SetDecoration(Me.BtnSls, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSls.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSls.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSls.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSls.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSls.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSls.FillColor = System.Drawing.Color.Empty
        Me.BtnSls.FillColor2 = System.Drawing.Color.Empty
        Me.BtnSls.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnSls.ForeColor = System.Drawing.Color.Black
        Me.BtnSls.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnSls.HoverState.FillColor2 = System.Drawing.Color.White
        Me.BtnSls.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSls.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnSls.Location = New System.Drawing.Point(2, 247)
        Me.BtnSls.Name = "BtnSls"
        Me.BtnSls.Size = New System.Drawing.Size(235, 45)
        Me.BtnSls.TabIndex = 4
        Me.BtnSls.Text = "Sales"
        Me.BtnSls.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSls.TextOffset = New System.Drawing.Point(50, 0)
        '
        'BtnPOS
        '
        Me.BtnPOS.CustomImages.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.BtnPOS.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPOS.CustomImages.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnPOS.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Transition1.SetDecoration(Me.BtnPOS, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPOS.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPOS.FillColor = System.Drawing.Color.Empty
        Me.BtnPOS.FillColor2 = System.Drawing.Color.Empty
        Me.BtnPOS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPOS.ForeColor = System.Drawing.Color.Black
        Me.BtnPOS.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnPOS.HoverState.FillColor2 = System.Drawing.Color.White
        Me.BtnPOS.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPOS.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnPOS.Location = New System.Drawing.Point(2, 295)
        Me.BtnPOS.Name = "BtnPOS"
        Me.BtnPOS.Size = New System.Drawing.Size(235, 45)
        Me.BtnPOS.TabIndex = 3
        Me.BtnPOS.Text = "Point of sale"
        Me.BtnPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPOS.TextOffset = New System.Drawing.Point(50, 0)
        '
        'BtnProducts
        '
        Me.BtnProducts.CustomImages.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.BtnProducts.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProducts.CustomImages.ImageOffset = New System.Drawing.Point(-4, 0)
        Me.BtnProducts.CustomImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Guna2Transition1.SetDecoration(Me.BtnProducts, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnProducts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnProducts.FillColor = System.Drawing.Color.Empty
        Me.BtnProducts.FillColor2 = System.Drawing.Color.Empty
        Me.BtnProducts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnProducts.ForeColor = System.Drawing.Color.Black
        Me.BtnProducts.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnProducts.HoverState.FillColor2 = System.Drawing.Color.White
        Me.BtnProducts.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProducts.Location = New System.Drawing.Point(2, 151)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(235, 45)
        Me.BtnProducts.TabIndex = 2
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProducts.TextOffset = New System.Drawing.Point(50, 0)
        '
        'BtnDash
        '
        Me.BtnDash.Animated = True
        Me.BtnDash.CustomImages.Image = Global.SEPROJ.My.Resources.Resources.CART__2_
        Me.BtnDash.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnDash.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Transition1.SetDecoration(Me.BtnDash, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDash.DisabledState.BorderColor = System.Drawing.Color.White
        Me.BtnDash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnDash.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnDash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDash.FillColor = System.Drawing.Color.Empty
        Me.BtnDash.FillColor2 = System.Drawing.Color.Empty
        Me.BtnDash.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDash.ForeColor = System.Drawing.Color.Black
        Me.BtnDash.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnDash.HoverState.FillColor2 = System.Drawing.Color.GhostWhite
        Me.BtnDash.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDash.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnDash.IndicateFocus = True
        Me.BtnDash.Location = New System.Drawing.Point(2, 103)
        Me.BtnDash.Name = "BtnDash"
        Me.BtnDash.Size = New System.Drawing.Size(235, 45)
        Me.BtnDash.TabIndex = 1
        Me.BtnDash.Text = "Dashboard"
        Me.BtnDash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnDash.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel2
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.AdminClose)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(237, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1110, 29)
        Me.Guna2Panel2.TabIndex = 5
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.mainpanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(237, 29)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1110, 701)
        Me.mainpanel.TabIndex = 6
        '
        'AdminClose
        '
        Me.AdminClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.AdminClose, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AdminClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AdminClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AdminClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AdminClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AdminClose.FillColor = System.Drawing.Color.Transparent
        Me.AdminClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AdminClose.ForeColor = System.Drawing.Color.White
        Me.AdminClose.Image = Global.SEPROJ.My.Resources.Resources.cross
        Me.AdminClose.ImageOffset = New System.Drawing.Point(1, 0)
        Me.AdminClose.ImageSize = New System.Drawing.Size(23, 23)
        Me.AdminClose.Location = New System.Drawing.Point(1080, 5)
        Me.AdminClose.Name = "AdminClose"
        Me.AdminClose.Size = New System.Drawing.Size(24, 19)
        Me.AdminClose.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.SEPROJ.My.Resources.Resources._318117930_1185359898728285_7499900976132733848_n
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(237, 68)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'BtnLogout
        '
        Me.BtnLogout.CustomImages.Image = Global.SEPROJ.My.Resources.Resources.IconLogout
        Me.BtnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnLogout.CustomImages.ImageOffset = New System.Drawing.Point(-40, 2)
        Me.BtnLogout.CustomImages.ImageSize = New System.Drawing.Size(28, 28)
        Me.Guna2Transition1.SetDecoration(Me.BtnLogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogout.FillColor = System.Drawing.Color.Empty
        Me.BtnLogout.FillColor2 = System.Drawing.Color.Empty
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.HoverState.FillColor = System.Drawing.Color.Teal
        Me.BtnLogout.HoverState.FillColor2 = System.Drawing.Color.White
        Me.BtnLogout.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout.Image = Global.SEPROJ.My.Resources.Resources.IconLogout
        Me.BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.BtnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnLogout.IndicateFocus = True
        Me.BtnLogout.Location = New System.Drawing.Point(1, 678)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(236, 45)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "SIGN OUT"
        Me.BtnLogout.TextOffset = New System.Drawing.Point(10, 0)
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1347, 730)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.PanelNav)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelNav.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PanelNav As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BtnDash As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUsrs As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSls As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPOS As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnProducts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnLogout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btn_show As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_hide As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents mainpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents AdminClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelCover As Guna.UI2.WinForms.Guna2Panel
End Class
