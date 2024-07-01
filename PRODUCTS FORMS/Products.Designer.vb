<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUICust = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BtnRmve = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtPrdctCde = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.Cbxctgry = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPrdctID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrdctPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrdctDescrptn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRle = New System.Windows.Forms.Label()
        Me.CbxCtgrySrch = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtxpry = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtOdrLvl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataSet3 = New SEPROJ.DataSet3()
        Me.PRDCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRDCTSTableAdapter = New SEPROJ.DataSet3TableAdapters.PRDCTSTableAdapter()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REORDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRDCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(46, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "PRODUCT MANAGEMENT"
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
        Me.Guna2Panel2.TabIndex = 22
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
        Me.btnUICust.Location = New System.Drawing.Point(614, 0)
        Me.btnUICust.Name = "btnUICust"
        Me.btnUICust.Size = New System.Drawing.Size(190, 36)
        Me.btnUICust.TabIndex = 61
        Me.btnUICust.Text = "UI CUSTOMIZATION"
        Me.btnUICust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUICust.TextOffset = New System.Drawing.Point(50, 0)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SEPROJ.My.Resources.Resources.products
        Me.PictureBox2.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.LightGray
        Me.Guna2GradientPanel2.BorderColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel2.BorderThickness = 1
        Me.Guna2GradientPanel2.Controls.Add(Me.txtOdrLvl)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel2.Controls.Add(Me.txtxpry)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnRmve)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnSave)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtPrdctCde)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnNew)
        Me.Guna2GradientPanel2.Controls.Add(Me.Cbxctgry)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtPrdctID)
        Me.Guna2GradientPanel2.Controls.Add(Me.BtnAdd)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label8)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtPrdctPrice)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtPrdctDescrptn)
        Me.Guna2GradientPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(413, 192)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(375, 527)
        Me.Guna2GradientPanel2.TabIndex = 23
        '
        'BtnRmve
        '
        Me.BtnRmve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRmve.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRmve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRmve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRmve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRmve.FillColor = System.Drawing.Color.DarkRed
        Me.BtnRmve.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRmve.ForeColor = System.Drawing.Color.White
        Me.BtnRmve.Location = New System.Drawing.Point(280, 453)
        Me.BtnRmve.Name = "BtnRmve"
        Me.BtnRmve.Size = New System.Drawing.Size(79, 35)
        Me.BtnRmve.TabIndex = 64
        Me.BtnRmve.Text = "Remove"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(193, 453)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(79, 35)
        Me.BtnSave.TabIndex = 63
        Me.BtnSave.Text = "Save"
        '
        'TxtPrdctCde
        '
        Me.TxtPrdctCde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrdctCde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctCde.DefaultText = ""
        Me.TxtPrdctCde.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctCde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctCde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctCde.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctCde.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctCde.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtPrdctCde.Location = New System.Drawing.Point(143, 122)
        Me.TxtPrdctCde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrdctCde.Name = "TxtPrdctCde"
        Me.TxtPrdctCde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrdctCde.PlaceholderText = ""
        Me.TxtPrdctCde.SelectedText = ""
        Me.TxtPrdctCde.Size = New System.Drawing.Size(213, 33)
        Me.TxtPrdctCde.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Product code"
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Location = New System.Drawing.Point(105, 453)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(79, 35)
        Me.BtnNew.TabIndex = 60
        Me.BtnNew.Text = "New"
        '
        'Cbxctgry
        '
        Me.Cbxctgry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbxctgry.BackColor = System.Drawing.Color.Transparent
        Me.Cbxctgry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cbxctgry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxctgry.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cbxctgry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cbxctgry.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxctgry.ForeColor = System.Drawing.Color.Black
        Me.Cbxctgry.ItemHeight = 30
        Me.Cbxctgry.Items.AddRange(New Object() {"Dairy Products", "Canned food", "Noodles", "Alcohol", "Beverages", "Snacks", "Sauces"})
        Me.Cbxctgry.Location = New System.Drawing.Point(144, 251)
        Me.Cbxctgry.Name = "Cbxctgry"
        Me.Cbxctgry.Size = New System.Drawing.Size(213, 36)
        Me.Cbxctgry.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Category"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(375, 43)
        Me.Guna2Panel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SEPROJ.My.Resources.Resources.products
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
        Me.Label10.Size = New System.Drawing.Size(184, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "PRODUCT INFORMATION"
        '
        'TxtPrdctID
        '
        Me.TxtPrdctID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrdctID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctID.DefaultText = ""
        Me.TxtPrdctID.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctID.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctID.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctID.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctID.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtPrdctID.Location = New System.Drawing.Point(144, 79)
        Me.TxtPrdctID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrdctID.Name = "TxtPrdctID"
        Me.TxtPrdctID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPrdctID.PlaceholderText = ""
        Me.TxtPrdctID.ReadOnly = True
        Me.TxtPrdctID.SelectedText = ""
        Me.TxtPrdctID.Size = New System.Drawing.Size(213, 33)
        Me.TxtPrdctID.TabIndex = 48
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.Green
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(17, 453)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 35)
        Me.BtnAdd.TabIndex = 57
        Me.BtnAdd.Text = "Add"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "ID"
        '
        'TxtPrdctPrice
        '
        Me.TxtPrdctPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrdctPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctPrice.DefaultText = ""
        Me.TxtPrdctPrice.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctPrice.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctPrice.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctPrice.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctPrice.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtPrdctPrice.Location = New System.Drawing.Point(143, 298)
        Me.TxtPrdctPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrdctPrice.Name = "TxtPrdctPrice"
        Me.TxtPrdctPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrdctPrice.PlaceholderText = ""
        Me.TxtPrdctPrice.SelectedText = ""
        Me.TxtPrdctPrice.Size = New System.Drawing.Size(213, 33)
        Me.TxtPrdctPrice.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Unit Price"
        '
        'TxtPrdctDescrptn
        '
        Me.TxtPrdctDescrptn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrdctDescrptn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctDescrptn.DefaultText = ""
        Me.TxtPrdctDescrptn.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDescrptn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctDescrptn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctDescrptn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctDescrptn.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDescrptn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctDescrptn.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctDescrptn.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDescrptn.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.TxtPrdctDescrptn.Location = New System.Drawing.Point(143, 165)
        Me.TxtPrdctDescrptn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrdctDescrptn.Multiline = True
        Me.TxtPrdctDescrptn.Name = "TxtPrdctDescrptn"
        Me.TxtPrdctDescrptn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrdctDescrptn.PlaceholderText = ""
        Me.TxtPrdctDescrptn.SelectedText = ""
        Me.TxtPrdctDescrptn.Size = New System.Drawing.Size(213, 75)
        Me.TxtPrdctDescrptn.TabIndex = 54
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.REORDERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PRDCTSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(393, 526)
        Me.DataGridView1.TabIndex = 59
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
        Me.PanelSearch.Controls.Add(Me.CbxCtgrySrch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Location = New System.Drawing.Point(12, 80)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(776, 96)
        Me.PanelSearch.TabIndex = 60
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
        Me.TxtSearch.Location = New System.Drawing.Point(69, 46)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = "Enter product code or description..."
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(443, 29)
        Me.TxtSearch.TabIndex = 55
        '
        'lblRle
        '
        Me.lblRle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRle.AutoSize = True
        Me.lblRle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRle.ForeColor = System.Drawing.Color.Black
        Me.lblRle.Location = New System.Drawing.Point(529, 44)
        Me.lblRle.Name = "lblRle"
        Me.lblRle.Size = New System.Drawing.Size(81, 19)
        Me.lblRle.TabIndex = 19
        Me.lblRle.Text = "Category"
        '
        'CbxCtgrySrch
        '
        Me.CbxCtgrySrch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxCtgrySrch.DisplayMember = "ROLE"
        Me.CbxCtgrySrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCtgrySrch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCtgrySrch.FormattingEnabled = True
        Me.CbxCtgrySrch.Items.AddRange(New Object() {"All", "Dairy Products", "Canned food", "Noodles", "Alcohol", "Beverages", "Snacks", "Sauces"})
        Me.CbxCtgrySrch.Location = New System.Drawing.Point(603, 40)
        Me.CbxCtgrySrch.Name = "CbxCtgrySrch"
        Me.CbxCtgrySrch.Size = New System.Drawing.Size(154, 29)
        Me.CbxCtgrySrch.TabIndex = 18
        Me.CbxCtgrySrch.ValueMember = "ROLE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Search"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Expiry date"
        '
        'txtxpry
        '
        Me.txtxpry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtxpry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtxpry.DefaultText = ""
        Me.txtxpry.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.txtxpry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtxpry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxpry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxpry.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.txtxpry.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxpry.ForeColor = System.Drawing.Color.Black
        Me.txtxpry.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.txtxpry.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.txtxpry.Location = New System.Drawing.Point(143, 342)
        Me.txtxpry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtxpry.Name = "txtxpry"
        Me.txtxpry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtxpry.PlaceholderText = ""
        Me.txtxpry.SelectedText = ""
        Me.txtxpry.Size = New System.Drawing.Size(213, 33)
        Me.txtxpry.TabIndex = 66
        '
        'txtOdrLvl
        '
        Me.txtOdrLvl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOdrLvl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOdrLvl.DefaultText = ""
        Me.txtOdrLvl.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.txtOdrLvl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOdrLvl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOdrLvl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOdrLvl.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.txtOdrLvl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOdrLvl.ForeColor = System.Drawing.Color.Black
        Me.txtOdrLvl.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.txtOdrLvl.IconRight = Global.SEPROJ.My.Resources.Resources.cross
        Me.txtOdrLvl.Location = New System.Drawing.Point(143, 387)
        Me.txtOdrLvl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOdrLvl.Name = "txtOdrLvl"
        Me.txtOdrLvl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdrLvl.PlaceholderText = ""
        Me.txtOdrLvl.SelectedText = ""
        Me.txtOdrLvl.Size = New System.Drawing.Size(213, 33)
        Me.txtOdrLvl.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Re-order level"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRDCTSBindingSource
        '
        Me.PRDCTSBindingSource.DataMember = "PRDCTS"
        Me.PRDCTSBindingSource.DataSource = Me.DataSet3
        '
        'PRDCTSTableAdapter
        '
        Me.PRDCTSTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PRODUCT_CODE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRODUCT CODE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DESCTIPTION"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 280
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EXPIRY_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EXPIRY DATE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'REORDERDataGridViewTextBoxColumn
        '
        Me.REORDERDataGridViewTextBoxColumn.DataPropertyName = "REORDER"
        Me.REORDERDataGridViewTextBoxColumn.HeaderText = "REORDER"
        Me.REORDERDataGridViewTextBoxColumn.Name = "REORDERDataGridViewTextBoxColumn"
        Me.REORDERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 730)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.Text = "Inventory"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRDCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cbxctgry As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrdctDescrptn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrdctPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPrdctID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPrdctCde As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnRmve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRle As Label
    Friend WithEvents CbxCtgrySrch As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DESCTIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXPIRYDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents btnUICust As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents txtOdrLvl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtxpry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents PRDCTSBindingSource As BindingSource
    Friend WithEvents PRDCTSTableAdapter As DataSet3TableAdapters.PRDCTSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents REORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
