<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Dtl_btn = New System.Windows.Forms.Button
        Me.Size_btn = New System.Windows.Forms.Button
        Me.Mat_btn = New System.Windows.Forms.Button
        Me.Typ_btn = New System.Windows.Forms.Button
        Me.Itm_btn = New System.Windows.Forms.Button
        Me.Grp_btn = New System.Windows.Forms.Button
        Me.RefPic_pbx = New System.Windows.Forms.PictureBox
        Me.Grp_tbx = New System.Windows.Forms.TextBox
        Me.AddGrp_btn = New System.Windows.Forms.Button
        Me.Avl_lbl = New System.Windows.Forms.Label
        Me.Grp_lbl = New System.Windows.Forms.Label
        Me.Avl_lbx = New System.Windows.Forms.ListBox
        Me.Code_lbl = New System.Windows.Forms.Label
        Me.Code_tbx = New System.Windows.Forms.TextBox
        Me.Price_lbl = New System.Windows.Forms.Label
        Me.Price_tbx = New System.Windows.Forms.TextBox
        Me.Nos_lbl = New System.Windows.Forms.Label
        Me.Nos_tbx = New System.Windows.Forms.TextBox
        Me.Desc_lbl = New System.Windows.Forms.Label
        Me.Desc_tbx = New System.Windows.Forms.TextBox
        Me.AddDtl_btn = New System.Windows.Forms.Button
        Me.Ref_lbl = New System.Windows.Forms.Label
        Me.Ref_tbx = New System.Windows.Forms.TextBox
        Me.Browse_btn = New System.Windows.Forms.Button
        Me.Import_ckbx = New System.Windows.Forms.CheckBox
        Me.Siz_cbx = New System.Windows.Forms.ComboBox
        Me.MainInventoryDataSet = New Shopkeeper_Inventory.InventoryDataSet
        Me.GroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Itm_cbx = New System.Windows.Forms.ComboBox
        Me.Grp_cbx = New System.Windows.Forms.ComboBox
        Me.Itm_tbx = New System.Windows.Forms.TextBox
        Me.Siz_lbl = New System.Windows.Forms.Label
        Me.Mat_lbl = New System.Windows.Forms.Label
        Me.Siz_tbx = New System.Windows.Forms.TextBox
        Me.Mat_tbx = New System.Windows.Forms.TextBox
        Me.Typ_tbx = New System.Windows.Forms.TextBox
        Me.Typ_lbl = New System.Windows.Forms.Label
        Me.Itm_lbl = New System.Windows.Forms.Label
        Me.AddItm_btn = New System.Windows.Forms.Button
        Me.AddTyp_btn = New System.Windows.Forms.Button
        Me.AddMat_btn = New System.Windows.Forms.Button
        Me.AddSiz_btn = New System.Windows.Forms.Button
        Me.Typ_cbx = New System.Windows.Forms.ComboBox
        Me.Mat_cbx = New System.Windows.Forms.ComboBox
        Me.GroupsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.GroupsTableAdapter
        Me.ItemsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.ItemsTableAdapter
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypesTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.TypesTableAdapter
        Me.MaterialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.MaterialsTableAdapter
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.SizeTableAdapter
        Me.Details1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Details1TableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.Details1TableAdapter
        Me.RefFile_dbx = New System.Windows.Forms.OpenFileDialog
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RefPic_pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Details1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(682, 439)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(682, 486)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.StatusLabel.Text = "Ready"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.RefPic_pbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Avl_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Avl_lbx)
        Me.SplitContainer1.Size = New System.Drawing.Size(682, 439)
        Me.SplitContainer1.SplitterDistance = 120
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Dtl_btn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Size_btn, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Mat_btn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Typ_btn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Itm_btn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Grp_btn, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(116, 435)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Dtl_btn
        '
        Me.Dtl_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtl_btn.Location = New System.Drawing.Point(3, 328)
        Me.Dtl_btn.Name = "Dtl_btn"
        Me.Dtl_btn.Size = New System.Drawing.Size(110, 59)
        Me.Dtl_btn.TabIndex = 5
        Me.Dtl_btn.Text = "Add Product"
        Me.Dtl_btn.UseVisualStyleBackColor = True
        '
        'Size_btn
        '
        Me.Size_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_btn.Location = New System.Drawing.Point(3, 263)
        Me.Size_btn.Name = "Size_btn"
        Me.Size_btn.Size = New System.Drawing.Size(110, 59)
        Me.Size_btn.TabIndex = 4
        Me.Size_btn.Text = "Add Size"
        Me.Size_btn.UseVisualStyleBackColor = True
        '
        'Mat_btn
        '
        Me.Mat_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mat_btn.Location = New System.Drawing.Point(3, 198)
        Me.Mat_btn.Name = "Mat_btn"
        Me.Mat_btn.Size = New System.Drawing.Size(110, 59)
        Me.Mat_btn.TabIndex = 3
        Me.Mat_btn.Text = "Add Material"
        Me.Mat_btn.UseVisualStyleBackColor = True
        '
        'Typ_btn
        '
        Me.Typ_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Typ_btn.Location = New System.Drawing.Point(3, 133)
        Me.Typ_btn.Name = "Typ_btn"
        Me.Typ_btn.Size = New System.Drawing.Size(110, 59)
        Me.Typ_btn.TabIndex = 2
        Me.Typ_btn.Text = "Add Type"
        Me.Typ_btn.UseVisualStyleBackColor = True
        '
        'Itm_btn
        '
        Me.Itm_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Itm_btn.Location = New System.Drawing.Point(3, 68)
        Me.Itm_btn.Name = "Itm_btn"
        Me.Itm_btn.Size = New System.Drawing.Size(110, 59)
        Me.Itm_btn.TabIndex = 1
        Me.Itm_btn.Text = "Add Item"
        Me.Itm_btn.UseVisualStyleBackColor = True
        '
        'Grp_btn
        '
        Me.Grp_btn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Grp_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Grp_btn.Location = New System.Drawing.Point(3, 3)
        Me.Grp_btn.Name = "Grp_btn"
        Me.Grp_btn.Size = New System.Drawing.Size(110, 59)
        Me.Grp_btn.TabIndex = 0
        Me.Grp_btn.Text = "Add Category"
        Me.Grp_btn.UseVisualStyleBackColor = False
        '
        'RefPic_pbx
        '
        Me.RefPic_pbx.Location = New System.Drawing.Point(344, 198)
        Me.RefPic_pbx.Name = "RefPic_pbx"
        Me.RefPic_pbx.Size = New System.Drawing.Size(200, 150)
        Me.RefPic_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RefPic_pbx.TabIndex = 56
        Me.RefPic_pbx.TabStop = False
        '
        'Grp_tbx
        '
        Me.Grp_tbx.Location = New System.Drawing.Point(119, 26)
        Me.Grp_tbx.Name = "Grp_tbx"
        Me.Grp_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Grp_tbx.TabIndex = 7
        '
        'AddGrp_btn
        '
        Me.AddGrp_btn.Location = New System.Drawing.Point(285, 24)
        Me.AddGrp_btn.Name = "AddGrp_btn"
        Me.AddGrp_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddGrp_btn.TabIndex = 8
        Me.AddGrp_btn.Text = "Add"
        Me.AddGrp_btn.UseVisualStyleBackColor = True
        '
        'Avl_lbl
        '
        Me.Avl_lbl.AutoSize = True
        Me.Avl_lbl.Location = New System.Drawing.Point(344, 29)
        Me.Avl_lbl.Name = "Avl_lbl"
        Me.Avl_lbl.Size = New System.Drawing.Size(106, 13)
        Me.Avl_lbl.TabIndex = 48
        Me.Avl_lbl.Text = "Available Categories:"
        '
        'Grp_lbl
        '
        Me.Grp_lbl.AutoSize = True
        Me.Grp_lbl.Location = New System.Drawing.Point(14, 29)
        Me.Grp_lbl.Name = "Grp_lbl"
        Me.Grp_lbl.Size = New System.Drawing.Size(77, 13)
        Me.Grp_lbl.TabIndex = 2
        Me.Grp_lbl.Text = "New Category:"
        '
        'Avl_lbx
        '
        Me.Avl_lbx.FormattingEnabled = True
        Me.Avl_lbx.Location = New System.Drawing.Point(344, 45)
        Me.Avl_lbx.Name = "Avl_lbx"
        Me.Avl_lbx.Size = New System.Drawing.Size(200, 147)
        Me.Avl_lbx.TabIndex = 29
        Me.Avl_lbx.TabStop = False
        '
        'Code_lbl
        '
        Me.Code_lbl.AutoSize = True
        Me.Code_lbl.Location = New System.Drawing.Point(14, 266)
        Me.Code_lbl.Name = "Code_lbl"
        Me.Code_lbl.Size = New System.Drawing.Size(75, 13)
        Me.Code_lbl.TabIndex = 43
        Me.Code_lbl.Text = "Product Code:"
        '
        'Code_tbx
        '
        Me.Code_tbx.Location = New System.Drawing.Point(119, 263)
        Me.Code_tbx.Name = "Code_tbx"
        Me.Code_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Code_tbx.TabIndex = 21
        '
        'Price_lbl
        '
        Me.Price_lbl.AutoSize = True
        Me.Price_lbl.Location = New System.Drawing.Point(14, 301)
        Me.Price_lbl.Name = "Price_lbl"
        Me.Price_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Price_lbl.TabIndex = 44
        Me.Price_lbl.Text = "Price (Rs.):"
        '
        'Price_tbx
        '
        Me.Price_tbx.Location = New System.Drawing.Point(119, 297)
        Me.Price_tbx.Name = "Price_tbx"
        Me.Price_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Price_tbx.TabIndex = 22
        '
        'Nos_lbl
        '
        Me.Nos_lbl.AutoSize = True
        Me.Nos_lbl.Location = New System.Drawing.Point(14, 336)
        Me.Nos_lbl.Name = "Nos_lbl"
        Me.Nos_lbl.Size = New System.Drawing.Size(78, 13)
        Me.Nos_lbl.TabIndex = 45
        Me.Nos_lbl.Text = "Available Nos.:"
        '
        'Nos_tbx
        '
        Me.Nos_tbx.Location = New System.Drawing.Point(119, 331)
        Me.Nos_tbx.Name = "Nos_tbx"
        Me.Nos_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Nos_tbx.TabIndex = 23
        '
        'Desc_lbl
        '
        Me.Desc_lbl.AutoSize = True
        Me.Desc_lbl.Location = New System.Drawing.Point(14, 371)
        Me.Desc_lbl.Name = "Desc_lbl"
        Me.Desc_lbl.Size = New System.Drawing.Size(63, 13)
        Me.Desc_lbl.TabIndex = 46
        Me.Desc_lbl.Text = "Description:"
        '
        'Desc_tbx
        '
        Me.Desc_tbx.Location = New System.Drawing.Point(119, 368)
        Me.Desc_tbx.Name = "Desc_tbx"
        Me.Desc_tbx.Size = New System.Drawing.Size(328, 20)
        Me.Desc_tbx.TabIndex = 24
        '
        'AddDtl_btn
        '
        Me.AddDtl_btn.Location = New System.Drawing.Point(285, 261)
        Me.AddDtl_btn.Name = "AddDtl_btn"
        Me.AddDtl_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddDtl_btn.TabIndex = 28
        Me.AddDtl_btn.Text = "Add"
        Me.AddDtl_btn.UseVisualStyleBackColor = True
        '
        'Ref_lbl
        '
        Me.Ref_lbl.AutoSize = True
        Me.Ref_lbl.Location = New System.Drawing.Point(14, 401)
        Me.Ref_lbl.Name = "Ref_lbl"
        Me.Ref_lbl.Size = New System.Drawing.Size(60, 13)
        Me.Ref_lbl.TabIndex = 55
        Me.Ref_lbl.Text = "Reference:"
        '
        'Ref_tbx
        '
        Me.Ref_tbx.Location = New System.Drawing.Point(119, 398)
        Me.Ref_tbx.Name = "Ref_tbx"
        Me.Ref_tbx.Size = New System.Drawing.Size(328, 20)
        Me.Ref_tbx.TabIndex = 25
        '
        'Browse_btn
        '
        Me.Browse_btn.Location = New System.Drawing.Point(453, 395)
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Size = New System.Drawing.Size(80, 23)
        Me.Browse_btn.TabIndex = 27
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'Import_ckbx
        '
        Me.Import_ckbx.AutoSize = True
        Me.Import_ckbx.Location = New System.Drawing.Point(119, 425)
        Me.Import_ckbx.Name = "Import_ckbx"
        Me.Import_ckbx.Size = New System.Drawing.Size(168, 17)
        Me.Import_ckbx.TabIndex = 26
        Me.Import_ckbx.Text = "Import File to Reference folder"
        Me.Import_ckbx.UseVisualStyleBackColor = True
        '
        'Siz_cbx
        '
        Me.Siz_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Siz_cbx.FormattingEnabled = True
        Me.Siz_cbx.Location = New System.Drawing.Point(119, 206)
        Me.Siz_cbx.Name = "Siz_cbx"
        Me.Siz_cbx.Size = New System.Drawing.Size(160, 21)
        Me.Siz_cbx.TabIndex = 18
        '
        'MainInventoryDataSet
        '
        Me.MainInventoryDataSet.DataSetName = "InventoryDataSet"
        Me.MainInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBindingSource
        '
        Me.GroupBindingSource.DataMember = "Groups"
        Me.GroupBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'Itm_cbx
        '
        Me.Itm_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Itm_cbx.FormattingEnabled = True
        Me.Itm_cbx.Location = New System.Drawing.Point(119, 71)
        Me.Itm_cbx.Name = "Itm_cbx"
        Me.Itm_cbx.Size = New System.Drawing.Size(160, 21)
        Me.Itm_cbx.TabIndex = 9
        '
        'Grp_cbx
        '
        Me.Grp_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grp_cbx.FormattingEnabled = True
        Me.Grp_cbx.Location = New System.Drawing.Point(119, 26)
        Me.Grp_cbx.Name = "Grp_cbx"
        Me.Grp_cbx.Size = New System.Drawing.Size(160, 21)
        Me.Grp_cbx.TabIndex = 6
        '
        'Itm_tbx
        '
        Me.Itm_tbx.Location = New System.Drawing.Point(119, 72)
        Me.Itm_tbx.Name = "Itm_tbx"
        Me.Itm_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Itm_tbx.TabIndex = 10
        '
        'Siz_lbl
        '
        Me.Siz_lbl.AutoSize = True
        Me.Siz_lbl.Location = New System.Drawing.Point(14, 213)
        Me.Siz_lbl.Name = "Siz_lbl"
        Me.Siz_lbl.Size = New System.Drawing.Size(55, 13)
        Me.Siz_lbl.TabIndex = 42
        Me.Siz_lbl.Text = "New Size:"
        '
        'Mat_lbl
        '
        Me.Mat_lbl.AutoSize = True
        Me.Mat_lbl.Location = New System.Drawing.Point(14, 167)
        Me.Mat_lbl.Name = "Mat_lbl"
        Me.Mat_lbl.Size = New System.Drawing.Size(72, 13)
        Me.Mat_lbl.TabIndex = 41
        Me.Mat_lbl.Text = "New Material:"
        '
        'Siz_tbx
        '
        Me.Siz_tbx.Location = New System.Drawing.Point(119, 210)
        Me.Siz_tbx.Name = "Siz_tbx"
        Me.Siz_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Siz_tbx.TabIndex = 19
        '
        'Mat_tbx
        '
        Me.Mat_tbx.Location = New System.Drawing.Point(119, 164)
        Me.Mat_tbx.Name = "Mat_tbx"
        Me.Mat_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Mat_tbx.TabIndex = 16
        '
        'Typ_tbx
        '
        Me.Typ_tbx.Location = New System.Drawing.Point(119, 118)
        Me.Typ_tbx.Name = "Typ_tbx"
        Me.Typ_tbx.Size = New System.Drawing.Size(160, 20)
        Me.Typ_tbx.TabIndex = 13
        '
        'Typ_lbl
        '
        Me.Typ_lbl.AutoSize = True
        Me.Typ_lbl.Location = New System.Drawing.Point(14, 121)
        Me.Typ_lbl.Name = "Typ_lbl"
        Me.Typ_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Typ_lbl.TabIndex = 4
        Me.Typ_lbl.Text = "New Type:"
        '
        'Itm_lbl
        '
        Me.Itm_lbl.AutoSize = True
        Me.Itm_lbl.Location = New System.Drawing.Point(14, 75)
        Me.Itm_lbl.Name = "Itm_lbl"
        Me.Itm_lbl.Size = New System.Drawing.Size(55, 13)
        Me.Itm_lbl.TabIndex = 3
        Me.Itm_lbl.Text = "New Item:"
        '
        'AddItm_btn
        '
        Me.AddItm_btn.Location = New System.Drawing.Point(285, 70)
        Me.AddItm_btn.Name = "AddItm_btn"
        Me.AddItm_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddItm_btn.TabIndex = 11
        Me.AddItm_btn.Text = "Add"
        Me.AddItm_btn.UseVisualStyleBackColor = True
        '
        'AddTyp_btn
        '
        Me.AddTyp_btn.Location = New System.Drawing.Point(285, 116)
        Me.AddTyp_btn.Name = "AddTyp_btn"
        Me.AddTyp_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddTyp_btn.TabIndex = 14
        Me.AddTyp_btn.Text = "Add"
        Me.AddTyp_btn.UseVisualStyleBackColor = True
        '
        'AddMat_btn
        '
        Me.AddMat_btn.Location = New System.Drawing.Point(285, 162)
        Me.AddMat_btn.Name = "AddMat_btn"
        Me.AddMat_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddMat_btn.TabIndex = 17
        Me.AddMat_btn.Text = "Add"
        Me.AddMat_btn.UseVisualStyleBackColor = True
        '
        'AddSiz_btn
        '
        Me.AddSiz_btn.Location = New System.Drawing.Point(285, 208)
        Me.AddSiz_btn.Name = "AddSiz_btn"
        Me.AddSiz_btn.Size = New System.Drawing.Size(53, 23)
        Me.AddSiz_btn.TabIndex = 20
        Me.AddSiz_btn.Text = "Add"
        Me.AddSiz_btn.UseVisualStyleBackColor = True
        '
        'Typ_cbx
        '
        Me.Typ_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Typ_cbx.FormattingEnabled = True
        Me.Typ_cbx.Location = New System.Drawing.Point(119, 116)
        Me.Typ_cbx.Name = "Typ_cbx"
        Me.Typ_cbx.Size = New System.Drawing.Size(160, 21)
        Me.Typ_cbx.TabIndex = 12
        '
        'Mat_cbx
        '
        Me.Mat_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mat_cbx.FormattingEnabled = True
        Me.Mat_cbx.Location = New System.Drawing.Point(119, 161)
        Me.Mat_cbx.Name = "Mat_cbx"
        Me.Mat_cbx.Size = New System.Drawing.Size(160, 21)
        Me.Mat_cbx.TabIndex = 15
        '
        'GroupsTableAdapter
        '
        Me.GroupsTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'TypesBindingSource
        '
        Me.TypesBindingSource.DataMember = "Types"
        Me.TypesBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'TypesTableAdapter
        '
        Me.TypesTableAdapter.ClearBeforeFill = True
        '
        'MaterialsBindingSource
        '
        Me.MaterialsBindingSource.DataMember = "Materials"
        Me.MaterialsBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'MaterialsTableAdapter
        '
        Me.MaterialsTableAdapter.ClearBeforeFill = True
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'Details1BindingSource
        '
        Me.Details1BindingSource.DataMember = "Details1"
        Me.Details1BindingSource.DataSource = Me.MainInventoryDataSet
        '
        'Details1TableAdapter
        '
        Me.Details1TableAdapter.ClearBeforeFill = True
        '
        'AddInventoryForm
        '
        Me.AcceptButton = Me.AddGrp_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 486)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(690, 520)
        Me.MinimumSize = New System.Drawing.Size(690, 520)
        Me.Name = "AddInventoryForm"
        Me.Text = "Add Inventory"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RefPic_pbx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Details1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Dtl_btn As System.Windows.Forms.Button
    Friend WithEvents Size_btn As System.Windows.Forms.Button
    Friend WithEvents Mat_btn As System.Windows.Forms.Button
    Friend WithEvents Typ_btn As System.Windows.Forms.Button
    Friend WithEvents Itm_btn As System.Windows.Forms.Button
    Friend WithEvents Grp_btn As System.Windows.Forms.Button
    Friend WithEvents Typ_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Itm_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Typ_lbl As System.Windows.Forms.Label
    Friend WithEvents Itm_lbl As System.Windows.Forms.Label
    Friend WithEvents Grp_lbl As System.Windows.Forms.Label
    Friend WithEvents Avl_lbx As System.Windows.Forms.ListBox
    Friend WithEvents Grp_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Siz_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Mat_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Mat_lbl As System.Windows.Forms.Label
    Friend WithEvents Desc_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Nos_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Price_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Code_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Desc_lbl As System.Windows.Forms.Label
    Friend WithEvents Nos_lbl As System.Windows.Forms.Label
    Friend WithEvents Price_lbl As System.Windows.Forms.Label
    Friend WithEvents Code_lbl As System.Windows.Forms.Label
    Friend WithEvents Siz_lbl As System.Windows.Forms.Label
    Friend WithEvents AddGrp_btn As System.Windows.Forms.Button
    Friend WithEvents Avl_lbl As System.Windows.Forms.Label
    Friend WithEvents AddItm_btn As System.Windows.Forms.Button
    Friend WithEvents AddDtl_btn As System.Windows.Forms.Button
    Friend WithEvents AddSiz_btn As System.Windows.Forms.Button
    Friend WithEvents AddMat_btn As System.Windows.Forms.Button
    Friend WithEvents AddTyp_btn As System.Windows.Forms.Button
    Friend WithEvents Grp_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Itm_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Siz_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Mat_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Typ_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents MainInventoryDataSet As Shopkeeper_Inventory.InventoryDataSet
    Friend WithEvents GroupsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.GroupsTableAdapter
    Friend WithEvents GroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ItemsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypesTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.TypesTableAdapter
    Friend WithEvents MaterialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.MaterialsTableAdapter
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents Details1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Details1TableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.Details1TableAdapter
    Friend WithEvents Browse_btn As System.Windows.Forms.Button
    Friend WithEvents Ref_lbl As System.Windows.Forms.Label
    Friend WithEvents Ref_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Import_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents RefFile_dbx As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RefPic_pbx As System.Windows.Forms.PictureBox
End Class
