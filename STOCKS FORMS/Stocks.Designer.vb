<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stocks
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCTIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPIRYDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REORDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet4 = New SEPROJ.DataSet4()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PanelSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrdctDscrptn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrdctCde = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUICust = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PRDCTSTableAdapter = New SEPROJ.DataSet4TableAdapters.PRDCTSTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRDCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PRODUCTCODEDataGridViewTextBoxColumn, Me.DESCTIPTIONDataGridViewTextBoxColumn, Me.CATEGORYDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.EXPIRYDATEDataGridViewTextBoxColumn, Me.REORDERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PRDCTSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(409, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'PRODUCTCODEDataGridViewTextBoxColumn
        '
        Me.PRODUCTCODEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.HeaderText = "PRODUCT CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.Name = "PRODUCTCODEDataGridViewTextBoxColumn"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUCTCODEDataGridViewTextBoxColumn.Width = 125
        '
        'DESCTIPTIONDataGridViewTextBoxColumn
        '
        Me.DESCTIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCTIPTION"
        Me.DESCTIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DESCTIPTIONDataGridViewTextBoxColumn.Name = "DESCTIPTIONDataGridViewTextBoxColumn"
        Me.DESCTIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCTIPTIONDataGridViewTextBoxColumn.Width = 250
        '
        'CATEGORYDataGridViewTextBoxColumn
        '
        Me.CATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.Name = "CATEGORYDataGridViewTextBoxColumn"
        Me.CATEGORYDataGridViewTextBoxColumn.ReadOnly = True
        Me.CATEGORYDataGridViewTextBoxColumn.Visible = False
        '
        'PRICEDataGridViewTextBoxColumn
        '
        Me.PRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.Name = "PRICEDataGridViewTextBoxColumn"
        Me.PRICEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRICEDataGridViewTextBoxColumn.Visible = False
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EXPIRYDATEDataGridViewTextBoxColumn
        '
        Me.EXPIRYDATEDataGridViewTextBoxColumn.DataPropertyName = "EXPIRY_DATE"
        Me.EXPIRYDATEDataGridViewTextBoxColumn.HeaderText = "EXPIRY_DATE"
        Me.EXPIRYDATEDataGridViewTextBoxColumn.Name = "EXPIRYDATEDataGridViewTextBoxColumn"
        Me.EXPIRYDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.EXPIRYDATEDataGridViewTextBoxColumn.Visible = False
        '
        'REORDERDataGridViewTextBoxColumn
        '
        Me.REORDERDataGridViewTextBoxColumn.DataPropertyName = "REORDER"
        Me.REORDERDataGridViewTextBoxColumn.HeaderText = "REORDER"
        Me.REORDERDataGridViewTextBoxColumn.Name = "REORDERDataGridViewTextBoxColumn"
        Me.REORDERDataGridViewTextBoxColumn.ReadOnly = True
        Me.REORDERDataGridViewTextBoxColumn.Visible = False
        '
        'PRDCTSBindingSource
        '
        Me.PRDCTSBindingSource.DataMember = "PRDCTS"
        Me.PRDCTSBindingSource.DataSource = Me.DataSet4
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column2, Me.Column3, Me.QUANTITY, Me.Column4, Me.DELETE})
        Me.DataGridView2.Location = New System.Drawing.Point(11, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(322, 350)
        Me.DataGridView2.TabIndex = 1
        '
        'PanelSearch
        '
        Me.PanelSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearch.BorderColor = System.Drawing.Color.Teal
        Me.PanelSearch.BorderThickness = 1
        Me.PanelSearch.Controls.Add(Me.txtDate)
        Me.PanelSearch.Controls.Add(Me.Label8)
        Me.PanelSearch.Controls.Add(Me.Label7)
        Me.PanelSearch.Controls.Add(Me.TxtBxID)
        Me.PanelSearch.Controls.Add(Me.Btnclear)
        Me.PanelSearch.Controls.Add(Me.BtnAdd)
        Me.PanelSearch.Controls.Add(Me.TxtQuantity)
        Me.PanelSearch.Controls.Add(Me.Label6)
        Me.PanelSearch.Controls.Add(Me.TxtPrdctDscrptn)
        Me.PanelSearch.Controls.Add(Me.Label4)
        Me.PanelSearch.Controls.Add(Me.TxtPrdctCde)
        Me.PanelSearch.Controls.Add(Me.Label5)
        Me.PanelSearch.Controls.Add(Me.Guna2Panel4)
        Me.PanelSearch.Location = New System.Drawing.Point(9, 51)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(783, 127)
        Me.PanelSearch.TabIndex = 57
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.DefaultText = ""
        Me.txtDate.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.txtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.txtDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.txtDate.Location = New System.Drawing.Point(618, 30)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.PlaceholderText = ""
        Me.txtDate.ReadOnly = True
        Me.txtDate.SelectedText = ""
        Me.txtDate.Size = New System.Drawing.Size(24, 31)
        Me.txtDate.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(517, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 18)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Stock in Date: "
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 18)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "ID:"
        '
        'TxtBxID
        '
        Me.TxtBxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBxID.DefaultText = ""
        Me.TxtBxID.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtBxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBxID.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtBxID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxID.ForeColor = System.Drawing.Color.Black
        Me.TxtBxID.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtBxID.Location = New System.Drawing.Point(43, 81)
        Me.TxtBxID.Name = "TxtBxID"
        Me.TxtBxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBxID.PlaceholderText = ""
        Me.TxtBxID.ReadOnly = True
        Me.TxtBxID.SelectedText = ""
        Me.TxtBxID.Size = New System.Drawing.Size(113, 33)
        Me.TxtBxID.TabIndex = 71
        '
        'Btnclear
        '
        Me.Btnclear.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnclear.Enabled = False
        Me.Btnclear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.White
        Me.Btnclear.Location = New System.Drawing.Point(659, 36)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(107, 33)
        Me.Btnclear.TabIndex = 70
        Me.Btnclear.Text = "New"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.FillColor = System.Drawing.Color.Green
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(659, 79)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(107, 33)
        Me.BtnAdd.TabIndex = 69
        Me.BtnAdd.Text = "Add stock"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtQuantity.DefaultText = ""
        Me.TxtQuantity.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtQuantity.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.ForeColor = System.Drawing.Color.Black
        Me.TxtQuantity.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtQuantity.Location = New System.Drawing.Point(110, 32)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtQuantity.PlaceholderText = ""
        Me.TxtQuantity.ReadOnly = True
        Me.TxtQuantity.SelectedText = ""
        Me.TxtQuantity.Size = New System.Drawing.Size(124, 33)
        Me.TxtQuantity.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Add Quantity:"
        '
        'TxtPrdctDscrptn
        '
        Me.TxtPrdctDscrptn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrdctDscrptn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctDscrptn.DefaultText = ""
        Me.TxtPrdctDscrptn.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDscrptn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctDscrptn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctDscrptn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctDscrptn.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDscrptn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctDscrptn.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctDscrptn.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctDscrptn.Location = New System.Drawing.Point(278, 81)
        Me.TxtPrdctDscrptn.Name = "TxtPrdctDscrptn"
        Me.TxtPrdctDscrptn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrdctDscrptn.PlaceholderText = ""
        Me.TxtPrdctDscrptn.ReadOnly = True
        Me.TxtPrdctDscrptn.SelectedText = ""
        Me.TxtPrdctDscrptn.Size = New System.Drawing.Size(364, 33)
        Me.TxtPrdctDscrptn.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(179, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Description:"
        '
        'TxtPrdctCde
        '
        Me.TxtPrdctCde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtPrdctCde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrdctCde.DefaultText = ""
        Me.TxtPrdctCde.DisabledState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrdctCde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctCde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrdctCde.FocusedState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrdctCde.ForeColor = System.Drawing.Color.Black
        Me.TxtPrdctCde.HoverState.BorderColor = System.Drawing.Color.Teal
        Me.TxtPrdctCde.Location = New System.Drawing.Point(369, 32)
        Me.TxtPrdctCde.Name = "TxtPrdctCde"
        Me.TxtPrdctCde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrdctCde.PlaceholderText = ""
        Me.TxtPrdctCde.ReadOnly = True
        Me.TxtPrdctCde.SelectedText = ""
        Me.TxtPrdctCde.Size = New System.Drawing.Size(120, 33)
        Me.TxtPrdctCde.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(266, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Product code:"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel4.Controls.Add(Me.Label10)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(783, 23)
        Me.Guna2Panel4.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "STOCK INFORMATION"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Teal
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.TxtSearch)
        Me.Guna2Panel1.Location = New System.Drawing.Point(9, 197)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(435, 431)
        Me.Guna2Panel1.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(0, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "STOCKS"
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
        Me.Guna2Panel2.TabIndex = 59
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
        Me.btnUICust.TabIndex = 62
        Me.btnUICust.Text = "UI CUSTOMIZATION"
        Me.btnUICust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUICust.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(42, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(201, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "INVENTORY MANAGEMENT"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Teal
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.BtnConfirm)
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.Controls.Add(Me.DataGridView2)
        Me.Guna2Panel3.Location = New System.Drawing.Point(450, 197)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(342, 431)
        Me.Guna2Panel3.TabIndex = 59
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnConfirm.Enabled = False
        Me.BtnConfirm.FillColor = System.Drawing.Color.Green
        Me.BtnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(223, 384)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(107, 33)
        Me.BtnConfirm.TabIndex = 71
        Me.BtnConfirm.Text = "Confirm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(0, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "CART REVIEW"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'PRDCTSTableAdapter
        '
        Me.PRDCTSTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.SEPROJ.My.Resources.Resources.icons8_trash_16px
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SEPROJ.My.Resources.Resources.Inventory2
        Me.PictureBox2.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
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
        Me.TxtSearch.Location = New System.Drawing.Point(72, 18)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = "Enter product code or description..."
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(350, 29)
        Me.TxtSearch.TabIndex = 55
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCT CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 135
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 270
        '
        'QUANTITY
        '
        Me.QUANTITY.HeaderText = "QUANTITY"
        Me.QUANTITY.Name = "QUANTITY"
        Me.QUANTITY.ReadOnly = True
        Me.QUANTITY.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QUANTITY.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Stock in Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 155
        '
        'DELETE
        '
        Me.DELETE.HeaderText = ""
        Me.DELETE.Image = Global.SEPROJ.My.Resources.Resources.icons8_trash_16px
        Me.DELETE.Name = "DELETE"
        Me.DELETE.ReadOnly = True
        Me.DELETE.Width = 25
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PanelSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stocks"
        Me.Text = "Stocks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRDCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPrdctCde As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPrdctDscrptn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Public WithEvents btnUICust As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DataSet4 As DataSet4
    Friend WithEvents PRDCTSBindingSource As BindingSource
    Friend WithEvents PRDCTSTableAdapter As DataSet4TableAdapters.PRDCTSTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCTIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXPIRYDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtDate As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DELETE As DataGridViewImageColumn
End Class
