<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUICust = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLCARTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLCART = New SEPROJ.TBLCART()
        Me.PanelSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.btntdy = New Guna.UI2.WinForms.Guna2Button()
        Me.btnwkly = New Guna.UI2.WinForms.Guna2Button()
        Me.btmnth = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbxSttsSearch = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRle = New System.Windows.Forms.Label()
        Me.CbxCtgrySrch = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBLCARTTableAdapter = New SEPROJ.TBLCARTTableAdapters.TBLCARTTableAdapter()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCARTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCART, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(950, 36)
        Me.Guna2Panel2.TabIndex = 23
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
        Me.btnUICust.Location = New System.Drawing.Point(763, 0)
        Me.btnUICust.Name = "btnUICust"
        Me.btnUICust.Size = New System.Drawing.Size(190, 36)
        Me.btnUICust.TabIndex = 63
        Me.btnUICust.Text = "UI CUSTOMIZATION"
        Me.btnUICust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUICust.TextOffset = New System.Drawing.Point(50, 0)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SEPROJ.My.Resources.Resources.Sales
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
        Me.Label11.Size = New System.Drawing.Size(161, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "SALES MANAGEMENT"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DataGridView1.DataSource = Me.TBLCARTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 208)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(926, 510)
        Me.DataGridView1.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INVOICE_NO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "INVOICE NO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRODUCT_CODE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRODUCT CODE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DSCRTN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn7.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "USERS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "USERS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn10.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SOLD_DATE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SOLD DATE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'TBLCARTBindingSource
        '
        Me.TBLCARTBindingSource.DataMember = "TBLCART"
        Me.TBLCARTBindingSource.DataSource = Me.TBLCART
        '
        'TBLCART
        '
        Me.TBLCART.DataSetName = "TBLCART"
        Me.TBLCART.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelSearch
        '
        Me.PanelSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearch.BorderColor = System.Drawing.Color.Teal
        Me.PanelSearch.BorderThickness = 1
        Me.PanelSearch.Controls.Add(Me.Guna2Button1)
        Me.PanelSearch.Controls.Add(Me.btntdy)
        Me.PanelSearch.Controls.Add(Me.btnwkly)
        Me.PanelSearch.Controls.Add(Me.btmnth)
        Me.PanelSearch.Controls.Add(Me.Guna2DateTimePicker1)
        Me.PanelSearch.Controls.Add(Me.Label6)
        Me.PanelSearch.Controls.Add(Me.CbxSttsSearch)
        Me.PanelSearch.Controls.Add(Me.Label12)
        Me.PanelSearch.Controls.Add(Me.TxtSearch)
        Me.PanelSearch.Controls.Add(Me.lblRle)
        Me.PanelSearch.Controls.Add(Me.CbxCtgrySrch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Location = New System.Drawing.Point(12, 60)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(926, 135)
        Me.PanelSearch.TabIndex = 61
        '
        'btntdy
        '
        Me.btntdy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btntdy.BorderRadius = 5
        Me.btntdy.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btntdy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btntdy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btntdy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btntdy.FillColor = System.Drawing.Color.Teal
        Me.btntdy.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btntdy.ForeColor = System.Drawing.Color.White
        Me.btntdy.Location = New System.Drawing.Point(379, 31)
        Me.btntdy.Name = "btntdy"
        Me.btntdy.Size = New System.Drawing.Size(167, 36)
        Me.btntdy.TabIndex = 62
        Me.btntdy.Text = "Today"
        '
        'btnwkly
        '
        Me.btnwkly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnwkly.BorderRadius = 5
        Me.btnwkly.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnwkly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnwkly.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnwkly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnwkly.FillColor = System.Drawing.Color.Teal
        Me.btnwkly.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnwkly.ForeColor = System.Drawing.Color.White
        Me.btnwkly.Location = New System.Drawing.Point(197, 31)
        Me.btnwkly.Name = "btnwkly"
        Me.btnwkly.Size = New System.Drawing.Size(167, 36)
        Me.btnwkly.TabIndex = 61
        Me.btnwkly.Text = "Last one week"
        '
        'btmnth
        '
        Me.btmnth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btmnth.BorderRadius = 5
        Me.btmnth.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btmnth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btmnth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btmnth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btmnth.FillColor = System.Drawing.Color.Teal
        Me.btmnth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmnth.ForeColor = System.Drawing.Color.White
        Me.btmnth.Location = New System.Drawing.Point(18, 31)
        Me.btmnth.Name = "btmnth"
        Me.btmnth.Size = New System.Drawing.Size(167, 36)
        Me.btmnth.TabIndex = 60
        Me.btmnth.Text = "Last one month"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2DateTimePicker1.Animated = True
        Me.Guna2DateTimePicker1.BorderRadius = 5
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.CustomFormat = ""
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.Teal
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(740, 31)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(174, 36)
        Me.Guna2DateTimePicker1.TabIndex = 59
        Me.Guna2DateTimePicker1.Value = New Date(2022, 5, 15, 6, 57, 44, 643)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(769, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Status"
        '
        'CbxSttsSearch
        '
        Me.CbxSttsSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxSttsSearch.DisplayMember = "ROLE"
        Me.CbxSttsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxSttsSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSttsSearch.FormattingEnabled = True
        Me.CbxSttsSearch.Items.AddRange(New Object() {"Pending", "Sold"})
        Me.CbxSttsSearch.Location = New System.Drawing.Point(818, 86)
        Me.CbxSttsSearch.Name = "CbxSttsSearch"
        Me.CbxSttsSearch.Size = New System.Drawing.Size(96, 29)
        Me.CbxSttsSearch.TabIndex = 57
        Me.CbxSttsSearch.ValueMember = "ROLE"
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
        Me.TxtSearch.Location = New System.Drawing.Point(76, 86)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = "Enter product code or description..."
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(439, 29)
        Me.TxtSearch.TabIndex = 55
        '
        'lblRle
        '
        Me.lblRle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRle.AutoSize = True
        Me.lblRle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRle.ForeColor = System.Drawing.Color.Black
        Me.lblRle.Location = New System.Drawing.Point(523, 90)
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
        Me.CbxCtgrySrch.Location = New System.Drawing.Point(597, 86)
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
        Me.Label9.Location = New System.Drawing.Point(14, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Search"
        '
        'TBLCARTTableAdapter
        '
        Me.TBLCARTTableAdapter.ClearBeforeFill = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(560, 31)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(167, 36)
        Me.Guna2Button1.TabIndex = 63
        Me.Guna2Button1.Text = "All"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(950, 730)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCARTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCART, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CbxSttsSearch As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRle As Label
    Friend WithEvents CbxCtgrySrch As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVOICENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DSCRTNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SOLDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btmnth As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btntdy As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnwkly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TBLCART As TBLCART
    Friend WithEvents TBLCARTBindingSource As BindingSource
    Friend WithEvents TBLCARTTableAdapter As TBLCARTTableAdapters.TBLCARTTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Public WithEvents btnUICust As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
