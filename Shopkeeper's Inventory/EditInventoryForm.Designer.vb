<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInventoryForm
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Size_btn = New System.Windows.Forms.Button
        Me.Mat_btn = New System.Windows.Forms.Button
        Me.Typ_btn = New System.Windows.Forms.Button
        Me.Itm_btn = New System.Windows.Forms.Button
        Me.Grp_btn = New System.Windows.Forms.Button
        Me.DelGrp_btn = New System.Windows.Forms.Button
        Me.Grp_cbx = New System.Windows.Forms.ComboBox
        Me.EditGrp_btn = New System.Windows.Forms.Button
        Me.Grp_lbl = New System.Windows.Forms.Label
        Me.DelSiz_btn = New System.Windows.Forms.Button
        Me.DelMat_btn = New System.Windows.Forms.Button
        Me.DelTyp_btn = New System.Windows.Forms.Button
        Me.DelItm_btn = New System.Windows.Forms.Button
        Me.Siz_cbx = New System.Windows.Forms.ComboBox
        Me.EditSiz_btn = New System.Windows.Forms.Button
        Me.Siz_lbl = New System.Windows.Forms.Label
        Me.Mat_cbx = New System.Windows.Forms.ComboBox
        Me.EditMat_btn = New System.Windows.Forms.Button
        Me.Mat_lbl = New System.Windows.Forms.Label
        Me.Typ_cbx = New System.Windows.Forms.ComboBox
        Me.EditTyp_btn = New System.Windows.Forms.Button
        Me.Typ_lbl = New System.Windows.Forms.Label
        Me.Itm_cbx = New System.Windows.Forms.ComboBox
        Me.EditItm_btn = New System.Windows.Forms.Button
        Me.Itm_lbl = New System.Windows.Forms.Label
        Me.Grp_tbx = New System.Windows.Forms.TextBox
        Me.Itm_tbx = New System.Windows.Forms.TextBox
        Me.Typ_tbx = New System.Windows.Forms.TextBox
        Me.Mat_tbx = New System.Windows.Forms.TextBox
        Me.Siz_tbx = New System.Windows.Forms.TextBox
        Me.MainInventoryDataSet = New Shopkeeper_Inventory.InventoryDataSet
        Me.GroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.GroupsTableAdapter
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.ItemsTableAdapter
        Me.TypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypesTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.TypesTableAdapter
        Me.MaterialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialsTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.MaterialsTableAdapter
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeTableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.SizeTableAdapter
        Me.Details1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Details1TableAdapter = New Shopkeeper_Inventory.InventoryDataSetTableAdapters.Details1TableAdapter
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MainInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(522, 269)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(522, 291)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(522, 22)
        Me.StatusStrip.TabIndex = 0
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_lbl)
        Me.SplitContainer1.Size = New System.Drawing.Size(522, 269)
        Me.SplitContainer1.SplitterDistance = 120
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Size_btn, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Mat_btn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Typ_btn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Itm_btn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Grp_btn, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(116, 265)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Size_btn
        '
        Me.Size_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_btn.Location = New System.Drawing.Point(3, 203)
        Me.Size_btn.Name = "Size_btn"
        Me.Size_btn.Size = New System.Drawing.Size(110, 44)
        Me.Size_btn.TabIndex = 4
        Me.Size_btn.Text = "Edit Size"
        Me.Size_btn.UseVisualStyleBackColor = True
        '
        'Mat_btn
        '
        Me.Mat_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mat_btn.Location = New System.Drawing.Point(3, 153)
        Me.Mat_btn.Name = "Mat_btn"
        Me.Mat_btn.Size = New System.Drawing.Size(110, 44)
        Me.Mat_btn.TabIndex = 3
        Me.Mat_btn.Text = "Edit Material"
        Me.Mat_btn.UseVisualStyleBackColor = True
        '
        'Typ_btn
        '
        Me.Typ_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Typ_btn.Location = New System.Drawing.Point(3, 103)
        Me.Typ_btn.Name = "Typ_btn"
        Me.Typ_btn.Size = New System.Drawing.Size(110, 44)
        Me.Typ_btn.TabIndex = 2
        Me.Typ_btn.Text = "Edit Type"
        Me.Typ_btn.UseVisualStyleBackColor = True
        '
        'Itm_btn
        '
        Me.Itm_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Itm_btn.Location = New System.Drawing.Point(3, 53)
        Me.Itm_btn.Name = "Itm_btn"
        Me.Itm_btn.Size = New System.Drawing.Size(110, 44)
        Me.Itm_btn.TabIndex = 1
        Me.Itm_btn.Text = "Edit Item"
        Me.Itm_btn.UseVisualStyleBackColor = True
        '
        'Grp_btn
        '
        Me.Grp_btn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Grp_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grp_btn.Location = New System.Drawing.Point(3, 3)
        Me.Grp_btn.Name = "Grp_btn"
        Me.Grp_btn.Size = New System.Drawing.Size(110, 44)
        Me.Grp_btn.TabIndex = 0
        Me.Grp_btn.Text = "Edit Category"
        Me.Grp_btn.UseVisualStyleBackColor = False
        '
        'DelGrp_btn
        '
        Me.DelGrp_btn.Location = New System.Drawing.Point(329, 14)
        Me.DelGrp_btn.Name = "DelGrp_btn"
        Me.DelGrp_btn.Size = New System.Drawing.Size(53, 23)
        Me.DelGrp_btn.TabIndex = 7
        Me.DelGrp_btn.Text = "Delete"
        Me.DelGrp_btn.UseVisualStyleBackColor = True
        '
        'Grp_cbx
        '
        Me.Grp_cbx.BackColor = System.Drawing.SystemColors.Info
        Me.Grp_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grp_cbx.FormattingEnabled = True
        Me.Grp_cbx.Location = New System.Drawing.Point(114, 16)
        Me.Grp_cbx.Name = "Grp_cbx"
        Me.Grp_cbx.Size = New System.Drawing.Size(150, 21)
        Me.Grp_cbx.TabIndex = 5
        '
        'EditGrp_btn
        '
        Me.EditGrp_btn.Location = New System.Drawing.Point(270, 14)
        Me.EditGrp_btn.Name = "EditGrp_btn"
        Me.EditGrp_btn.Size = New System.Drawing.Size(53, 23)
        Me.EditGrp_btn.TabIndex = 6
        Me.EditGrp_btn.Text = "Edit"
        Me.EditGrp_btn.UseVisualStyleBackColor = True
        '
        'Grp_lbl
        '
        Me.Grp_lbl.AutoSize = True
        Me.Grp_lbl.Location = New System.Drawing.Point(14, 19)
        Me.Grp_lbl.Name = "Grp_lbl"
        Me.Grp_lbl.Size = New System.Drawing.Size(94, 13)
        Me.Grp_lbl.TabIndex = 2
        Me.Grp_lbl.Text = "Select a Category:"
        '
        'DelSiz_btn
        '
        Me.DelSiz_btn.Location = New System.Drawing.Point(329, 214)
        Me.DelSiz_btn.Name = "DelSiz_btn"
        Me.DelSiz_btn.Size = New System.Drawing.Size(53, 23)
        Me.DelSiz_btn.TabIndex = 19
        Me.DelSiz_btn.Text = "Delete"
        Me.DelSiz_btn.UseVisualStyleBackColor = True
        '
        'DelMat_btn
        '
        Me.DelMat_btn.Location = New System.Drawing.Point(329, 164)
        Me.DelMat_btn.Name = "DelMat_btn"
        Me.DelMat_btn.Size = New System.Drawing.Size(53, 23)
        Me.DelMat_btn.TabIndex = 16
        Me.DelMat_btn.Text = "Delete"
        Me.DelMat_btn.UseVisualStyleBackColor = True
        '
        'DelTyp_btn
        '
        Me.DelTyp_btn.Location = New System.Drawing.Point(329, 114)
        Me.DelTyp_btn.Name = "DelTyp_btn"
        Me.DelTyp_btn.Size = New System.Drawing.Size(53, 23)
        Me.DelTyp_btn.TabIndex = 13
        Me.DelTyp_btn.Text = "Delete"
        Me.DelTyp_btn.UseVisualStyleBackColor = True
        '
        'DelItm_btn
        '
        Me.DelItm_btn.Location = New System.Drawing.Point(329, 64)
        Me.DelItm_btn.Name = "DelItm_btn"
        Me.DelItm_btn.Size = New System.Drawing.Size(53, 23)
        Me.DelItm_btn.TabIndex = 10
        Me.DelItm_btn.Text = "Delete"
        Me.DelItm_btn.UseVisualStyleBackColor = True
        '
        'Siz_cbx
        '
        Me.Siz_cbx.BackColor = System.Drawing.SystemColors.Info
        Me.Siz_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Siz_cbx.FormattingEnabled = True
        Me.Siz_cbx.Location = New System.Drawing.Point(114, 216)
        Me.Siz_cbx.Name = "Siz_cbx"
        Me.Siz_cbx.Size = New System.Drawing.Size(150, 21)
        Me.Siz_cbx.TabIndex = 17
        '
        'EditSiz_btn
        '
        Me.EditSiz_btn.Location = New System.Drawing.Point(270, 214)
        Me.EditSiz_btn.Name = "EditSiz_btn"
        Me.EditSiz_btn.Size = New System.Drawing.Size(53, 23)
        Me.EditSiz_btn.TabIndex = 18
        Me.EditSiz_btn.Text = "Edit"
        Me.EditSiz_btn.UseVisualStyleBackColor = True
        '
        'Siz_lbl
        '
        Me.Siz_lbl.AutoSize = True
        Me.Siz_lbl.Location = New System.Drawing.Point(14, 219)
        Me.Siz_lbl.Name = "Siz_lbl"
        Me.Siz_lbl.Size = New System.Drawing.Size(72, 13)
        Me.Siz_lbl.TabIndex = 59
        Me.Siz_lbl.Text = "Select a Size:"
        '
        'Mat_cbx
        '
        Me.Mat_cbx.BackColor = System.Drawing.SystemColors.Info
        Me.Mat_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mat_cbx.FormattingEnabled = True
        Me.Mat_cbx.Location = New System.Drawing.Point(114, 166)
        Me.Mat_cbx.Name = "Mat_cbx"
        Me.Mat_cbx.Size = New System.Drawing.Size(150, 21)
        Me.Mat_cbx.TabIndex = 14
        '
        'EditMat_btn
        '
        Me.EditMat_btn.Location = New System.Drawing.Point(270, 164)
        Me.EditMat_btn.Name = "EditMat_btn"
        Me.EditMat_btn.Size = New System.Drawing.Size(53, 23)
        Me.EditMat_btn.TabIndex = 15
        Me.EditMat_btn.Text = "Edit"
        Me.EditMat_btn.UseVisualStyleBackColor = True
        '
        'Mat_lbl
        '
        Me.Mat_lbl.AutoSize = True
        Me.Mat_lbl.Location = New System.Drawing.Point(14, 169)
        Me.Mat_lbl.Name = "Mat_lbl"
        Me.Mat_lbl.Size = New System.Drawing.Size(89, 13)
        Me.Mat_lbl.TabIndex = 56
        Me.Mat_lbl.Text = "Select a Material:"
        '
        'Typ_cbx
        '
        Me.Typ_cbx.BackColor = System.Drawing.SystemColors.Info
        Me.Typ_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Typ_cbx.FormattingEnabled = True
        Me.Typ_cbx.Location = New System.Drawing.Point(114, 116)
        Me.Typ_cbx.Name = "Typ_cbx"
        Me.Typ_cbx.Size = New System.Drawing.Size(150, 21)
        Me.Typ_cbx.TabIndex = 11
        '
        'EditTyp_btn
        '
        Me.EditTyp_btn.Location = New System.Drawing.Point(270, 114)
        Me.EditTyp_btn.Name = "EditTyp_btn"
        Me.EditTyp_btn.Size = New System.Drawing.Size(53, 23)
        Me.EditTyp_btn.TabIndex = 12
        Me.EditTyp_btn.Text = "Edit"
        Me.EditTyp_btn.UseVisualStyleBackColor = True
        '
        'Typ_lbl
        '
        Me.Typ_lbl.AutoSize = True
        Me.Typ_lbl.Location = New System.Drawing.Point(14, 119)
        Me.Typ_lbl.Name = "Typ_lbl"
        Me.Typ_lbl.Size = New System.Drawing.Size(76, 13)
        Me.Typ_lbl.TabIndex = 53
        Me.Typ_lbl.Text = "Select a Type:"
        '
        'Itm_cbx
        '
        Me.Itm_cbx.BackColor = System.Drawing.SystemColors.Info
        Me.Itm_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Itm_cbx.FormattingEnabled = True
        Me.Itm_cbx.Location = New System.Drawing.Point(114, 66)
        Me.Itm_cbx.Name = "Itm_cbx"
        Me.Itm_cbx.Size = New System.Drawing.Size(150, 21)
        Me.Itm_cbx.TabIndex = 8
        '
        'EditItm_btn
        '
        Me.EditItm_btn.Location = New System.Drawing.Point(270, 64)
        Me.EditItm_btn.Name = "EditItm_btn"
        Me.EditItm_btn.Size = New System.Drawing.Size(53, 23)
        Me.EditItm_btn.TabIndex = 9
        Me.EditItm_btn.Text = "Edit"
        Me.EditItm_btn.UseVisualStyleBackColor = True
        '
        'Itm_lbl
        '
        Me.Itm_lbl.AutoSize = True
        Me.Itm_lbl.Location = New System.Drawing.Point(14, 69)
        Me.Itm_lbl.Name = "Itm_lbl"
        Me.Itm_lbl.Size = New System.Drawing.Size(78, 13)
        Me.Itm_lbl.TabIndex = 50
        Me.Itm_lbl.Text = "Select an Item:"
        '
        'Grp_tbx
        '
        Me.Grp_tbx.Location = New System.Drawing.Point(114, 16)
        Me.Grp_tbx.Name = "Grp_tbx"
        Me.Grp_tbx.Size = New System.Drawing.Size(150, 20)
        Me.Grp_tbx.TabIndex = 67
        '
        'Itm_tbx
        '
        Me.Itm_tbx.Location = New System.Drawing.Point(114, 66)
        Me.Itm_tbx.Name = "Itm_tbx"
        Me.Itm_tbx.Size = New System.Drawing.Size(150, 20)
        Me.Itm_tbx.TabIndex = 68
        '
        'Typ_tbx
        '
        Me.Typ_tbx.Location = New System.Drawing.Point(114, 116)
        Me.Typ_tbx.Name = "Typ_tbx"
        Me.Typ_tbx.Size = New System.Drawing.Size(150, 20)
        Me.Typ_tbx.TabIndex = 69
        '
        'Mat_tbx
        '
        Me.Mat_tbx.Location = New System.Drawing.Point(114, 166)
        Me.Mat_tbx.Name = "Mat_tbx"
        Me.Mat_tbx.Size = New System.Drawing.Size(150, 20)
        Me.Mat_tbx.TabIndex = 70
        '
        'Siz_tbx
        '
        Me.Siz_tbx.Location = New System.Drawing.Point(114, 216)
        Me.Siz_tbx.Name = "Siz_tbx"
        Me.Siz_tbx.Size = New System.Drawing.Size(150, 20)
        Me.Siz_tbx.TabIndex = 71
        '
        'MainInventoryDataSet
        '
        Me.MainInventoryDataSet.DataSetName = "InventoryDataSet"
        Me.MainInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupsBindingSource
        '
        Me.GroupsBindingSource.DataMember = "Groups"
        Me.GroupsBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'GroupsTableAdapter
        '
        Me.GroupsTableAdapter.ClearBeforeFill = True
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.MainInventoryDataSet
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
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
        'EditInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 291)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(530, 325)
        Me.MinimumSize = New System.Drawing.Size(530, 325)
        Me.Name = "EditInventoryForm"
        Me.Text = "Edit Inventory"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.MainInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Details1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Size_btn As System.Windows.Forms.Button
    Friend WithEvents Mat_btn As System.Windows.Forms.Button
    Friend WithEvents Typ_btn As System.Windows.Forms.Button
    Friend WithEvents Itm_btn As System.Windows.Forms.Button
    Friend WithEvents Grp_btn As System.Windows.Forms.Button
    Friend WithEvents EditGrp_btn As System.Windows.Forms.Button
    Friend WithEvents Grp_lbl As System.Windows.Forms.Label
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Siz_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents EditSiz_btn As System.Windows.Forms.Button
    Friend WithEvents Siz_lbl As System.Windows.Forms.Label
    Friend WithEvents Mat_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents EditMat_btn As System.Windows.Forms.Button
    Friend WithEvents Mat_lbl As System.Windows.Forms.Label
    Friend WithEvents Typ_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents EditTyp_btn As System.Windows.Forms.Button
    Friend WithEvents Typ_lbl As System.Windows.Forms.Label
    Friend WithEvents Itm_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents EditItm_btn As System.Windows.Forms.Button
    Friend WithEvents Itm_lbl As System.Windows.Forms.Label
    Friend WithEvents Grp_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents DelSiz_btn As System.Windows.Forms.Button
    Friend WithEvents DelMat_btn As System.Windows.Forms.Button
    Friend WithEvents DelTyp_btn As System.Windows.Forms.Button
    Friend WithEvents DelItm_btn As System.Windows.Forms.Button
    Friend WithEvents DelGrp_btn As System.Windows.Forms.Button
    Friend WithEvents Siz_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Mat_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Typ_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Itm_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Grp_tbx As System.Windows.Forms.TextBox
    Friend WithEvents MainInventoryDataSet As Shopkeeper_Inventory.InventoryDataSet
    Friend WithEvents GroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.GroupsTableAdapter
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypesTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.TypesTableAdapter
    Friend WithEvents MaterialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialsTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.MaterialsTableAdapter
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents Details1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Details1TableAdapter As Shopkeeper_Inventory.InventoryDataSetTableAdapters.Details1TableAdapter
End Class
