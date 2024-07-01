<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TxtCntct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtAddr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtEml = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPsswrd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CbxRle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnDlt = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdt = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRle = New System.Windows.Forms.Label()
        Me.CbxRleSrch = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUICust = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DataSet2 = New SEPROJ.DataSet2()
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFFTableAdapter = New SEPROJ.DataSet2TableAdapters.STAFFTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.LightGray
        Me.Guna2GradientPanel2.BorderColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel2.BorderThickness = 1
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtCntct)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtAddr)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtEml)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtLname)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtPsswrd)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtFname)
        Me.Guna2GradientPanel2.Controls.Add(Me.CbxRle)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtID)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnDlt)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnUpdt)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnNew)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnAdd)
        Me.Guna2GradientPanel2.Controls.Add(Me.PanelForm)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label8)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(386, 167)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(403, 551)
        Me.Guna2GradientPanel2.TabIndex = 6
        '
        'TxtCntct
        '
        Me.TxtCntct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCntct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCntct.DefaultText = ""
        Me.TxtCntct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCntct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCntct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCntct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCntct.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtCntct.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCntct.ForeColor = System.Drawing.Color.Black
        Me.TxtCntct.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtCntct.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtCntct.Location = New System.Drawing.Point(125, 431)
        Me.TxtCntct.Name = "TxtCntct"
        Me.TxtCntct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCntct.PlaceholderText = ""
        Me.TxtCntct.SelectedText = ""
        Me.TxtCntct.Size = New System.Drawing.Size(261, 33)
        Me.TxtCntct.TabIndex = 53
        '
        'TxtAddr
        '
        Me.TxtAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddr.DefaultText = ""
        Me.TxtAddr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAddr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAddr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddr.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtAddr.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddr.ForeColor = System.Drawing.Color.Black
        Me.TxtAddr.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtAddr.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtAddr.Location = New System.Drawing.Point(125, 367)
        Me.TxtAddr.Multiline = True
        Me.TxtAddr.Name = "TxtAddr"
        Me.TxtAddr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddr.PlaceholderText = ""
        Me.TxtAddr.SelectedText = ""
        Me.TxtAddr.Size = New System.Drawing.Size(261, 51)
        Me.TxtAddr.TabIndex = 52
        '
        'TxtEml
        '
        Me.TxtEml.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEml.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEml.DefaultText = ""
        Me.TxtEml.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEml.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEml.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEml.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEml.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtEml.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEml.ForeColor = System.Drawing.Color.Black
        Me.TxtEml.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtEml.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtEml.Location = New System.Drawing.Point(125, 269)
        Me.TxtEml.Name = "TxtEml"
        Me.TxtEml.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEml.PlaceholderText = ""
        Me.TxtEml.SelectedText = ""
        Me.TxtEml.Size = New System.Drawing.Size(261, 33)
        Me.TxtEml.TabIndex = 51
        '
        'TxtLname
        '
        Me.TxtLname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLname.DefaultText = ""
        Me.TxtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLname.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtLname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLname.ForeColor = System.Drawing.Color.Black
        Me.TxtLname.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtLname.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtLname.Location = New System.Drawing.Point(125, 221)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLname.PlaceholderText = ""
        Me.TxtLname.SelectedText = ""
        Me.TxtLname.Size = New System.Drawing.Size(261, 33)
        Me.TxtLname.TabIndex = 50
        '
        'TxtPsswrd
        '
        Me.TxtPsswrd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPsswrd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPsswrd.DefaultText = ""
        Me.TxtPsswrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPsswrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPsswrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPsswrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPsswrd.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPsswrd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPsswrd.ForeColor = System.Drawing.Color.Black
        Me.TxtPsswrd.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPsswrd.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtPsswrd.Location = New System.Drawing.Point(125, 319)
        Me.TxtPsswrd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPsswrd.Name = "TxtPsswrd"
        Me.TxtPsswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPsswrd.PlaceholderText = ""
        Me.TxtPsswrd.SelectedText = ""
        Me.TxtPsswrd.Size = New System.Drawing.Size(261, 33)
        Me.TxtPsswrd.TabIndex = 48
        '
        'TxtFname
        '
        Me.TxtFname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFname.DefaultText = ""
        Me.TxtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFname.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtFname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFname.ForeColor = System.Drawing.Color.Black
        Me.TxtFname.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtFname.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtFname.Location = New System.Drawing.Point(125, 173)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFname.PlaceholderText = ""
        Me.TxtFname.SelectedText = ""
        Me.TxtFname.Size = New System.Drawing.Size(261, 33)
        Me.TxtFname.TabIndex = 49
        '
        'CbxRle
        '
        Me.CbxRle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbxRle.BackColor = System.Drawing.Color.Transparent
        Me.CbxRle.DisplayMember = "ROLE"
        Me.CbxRle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxRle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxRle.FocusedColor = System.Drawing.Color.Teal
        Me.CbxRle.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.CbxRle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRle.ForeColor = System.Drawing.Color.Black
        Me.CbxRle.ItemHeight = 30
        Me.CbxRle.Items.AddRange(New Object() {"Administrator", "Cashier"})
        Me.CbxRle.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Teal
        Me.CbxRle.Location = New System.Drawing.Point(125, 123)
        Me.CbxRle.Name = "CbxRle"
        Me.CbxRle.Size = New System.Drawing.Size(261, 36)
        Me.CbxRle.TabIndex = 47
        Me.CbxRle.ValueMember = "ROLE"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Firstname: "
        '
        'TxtID
        '
        Me.TxtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtID.DefaultText = ""
        Me.TxtID.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtID.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.ForeColor = System.Drawing.Color.Black
        Me.TxtID.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtID.Location = New System.Drawing.Point(125, 76)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtID.PlaceholderText = ""
        Me.TxtID.ReadOnly = True
        Me.TxtID.SelectedText = ""
        Me.TxtID.Size = New System.Drawing.Size(261, 33)
        Me.TxtID.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lastname: "
        '
        'BtnDlt
        '
        Me.BtnDlt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDlt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDlt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDlt.FillColor = System.Drawing.Color.DarkRed
        Me.BtnDlt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDlt.ForeColor = System.Drawing.Color.White
        Me.BtnDlt.Location = New System.Drawing.Point(306, 486)
        Me.BtnDlt.Name = "BtnDlt"
        Me.BtnDlt.Size = New System.Drawing.Size(79, 35)
        Me.BtnDlt.TabIndex = 12
        Me.BtnDlt.Text = "Delete"
        '
        'BtnUpdt
        '
        Me.BtnUpdt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUpdt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdt.ForeColor = System.Drawing.Color.White
        Me.BtnUpdt.Location = New System.Drawing.Point(212, 486)
        Me.BtnUpdt.Name = "BtnUpdt"
        Me.BtnUpdt.Size = New System.Drawing.Size(79, 35)
        Me.BtnUpdt.TabIndex = 11
        Me.BtnUpdt.Text = "Save"
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNew.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Location = New System.Drawing.Point(117, 486)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(79, 35)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.Text = "New"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.Green
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(21, 486)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 35)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.Teal
        Me.PanelForm.Controls.Add(Me.PictureBox1)
        Me.PanelForm.Controls.Add(Me.Label10)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(403, 43)
        Me.PanelForm.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SEPROJ.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(47, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "USER REGISTRATION FORM"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID: "
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Password: "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address: "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contact No."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Role"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email: "
        '
        'lblRle
        '
        Me.lblRle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRle.AutoSize = True
        Me.lblRle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRle.ForeColor = System.Drawing.Color.Black
        Me.lblRle.Location = New System.Drawing.Point(495, 42)
        Me.lblRle.Name = "lblRle"
        Me.lblRle.Size = New System.Drawing.Size(46, 19)
        Me.lblRle.TabIndex = 19
        Me.lblRle.Text = "Role:"
        '
        'CbxRleSrch
        '
        Me.CbxRleSrch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxRleSrch.DisplayMember = "ROLE"
        Me.CbxRleSrch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRleSrch.FormattingEnabled = True
        Me.CbxRleSrch.Items.AddRange(New Object() {"All", "Administrator", "Cashier"})
        Me.CbxRleSrch.Location = New System.Drawing.Point(548, 38)
        Me.CbxRleSrch.Name = "CbxRleSrch"
        Me.CbxRleSrch.Size = New System.Drawing.Size(219, 29)
        Me.CbxRleSrch.TabIndex = 18
        Me.CbxRleSrch.ValueMember = "ROLE"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel2.Controls.Add(Me.btnUICust)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.Label11)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(800, 36)
        Me.Guna2Panel2.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SEPROJ.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(46, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "USER MANAGEMENT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Search"
        '
        'PanelSearch
        '
        Me.PanelSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearch.BorderColor = System.Drawing.Color.Teal
        Me.PanelSearch.BorderThickness = 1
        Me.PanelSearch.Controls.Add(Me.Label12)
        Me.PanelSearch.Controls.Add(Me.TxtSearch)
        Me.PanelSearch.Controls.Add(Me.lblRle)
        Me.PanelSearch.Controls.Add(Me.CbxRleSrch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Location = New System.Drawing.Point(13, 52)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(776, 97)
        Me.PanelSearch.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(0, -4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 17)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "ADVANCED SEARCH"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtSearch.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtSearch.Location = New System.Drawing.Point(69, 38)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = "Enter first name or last name..."
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(395, 29)
        Me.TxtSearch.TabIndex = 55
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CONTACTNUMDataGridViewTextBoxColumn, Me.ROLEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.STAFFBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(13, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(367, 551)
        Me.DataGridView1.TabIndex = 20
        '
        'btnUICust
        '
        Me.btnUICust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUICust.BorderRadius = 10
        Me.btnUICust.CustomImages.Image = Global.SEPROJ.My.Resources.Resources.icons8_adjustment_104px
        Me.btnUICust.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUICust.CustomImages.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.btnUICust.CustomImages.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnUICust.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUICust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUICust.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUICust.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUICust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUICust.FillColor = System.Drawing.Color.Teal
        Me.btnUICust.FillColor2 = System.Drawing.Color.LightSeaGreen
        Me.btnUICust.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUICust.ForeColor = System.Drawing.Color.White
        Me.btnUICust.HoverState.FillColor = System.Drawing.Color.Teal
        Me.btnUICust.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnUICust.HoverState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUICust.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUICust.IndicateFocus = True
        Me.btnUICust.Location = New System.Drawing.Point(612, 0)
        Me.btnUICust.Name = "btnUICust"
        Me.btnUICust.Size = New System.Drawing.Size(190, 36)
        Me.btnUICust.TabIndex = 64
        Me.btnUICust.Text = "UI CUSTOMIZATION"
        Me.btnUICust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUICust.TextOffset = New System.Drawing.Point(50, 0)
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFFBindingSource
        '
        Me.STAFFBindingSource.DataMember = "STAFF"
        Me.STAFFBindingSource.DataSource = Me.DataSet2
        '
        'STAFFTableAdapter
        '
        Me.STAFFTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTNUMDataGridViewTextBoxColumn
        '
        Me.CONTACTNUMDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNUM"
        Me.CONTACTNUMDataGridViewTextBoxColumn.HeaderText = "CONTACTNUM"
        Me.CONTACTNUMDataGridViewTextBoxColumn.Name = "CONTACTNUMDataGridViewTextBoxColumn"
        Me.CONTACTNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ROLEDataGridViewTextBoxColumn
        '
        Me.ROLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE"
        Me.ROLEDataGridViewTextBoxColumn.HeaderText = "ROLE"
        Me.ROLEDataGridViewTextBoxColumn.Name = "ROLEDataGridViewTextBoxColumn"
        Me.ROLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMAILDataGridViewTextBoxColumn.Width = 150
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 730)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.PanelSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDlt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CbxRleSrch As ComboBox
    Friend WithEvents lblRle As Label
    Friend WithEvents PanelForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CbxRle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtCntct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtAddr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtEml As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPsswrd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Public WithEvents btnUICust As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents STAFFTableAdapter As DataSet2TableAdapters.STAFFTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ROLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
