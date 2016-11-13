<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewForm
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
        Me.Billing_pd = New System.Drawing.Printing.PrintDocument
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Billing_ppc = New System.Windows.Forms.PrintPreviewControl
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Per_lbl = New System.Windows.Forms.Label
        Me.PageSet_btn = New System.Windows.Forms.Button
        Me.SavPrnt_btn = New System.Windows.Forms.Button
        Me.Prnt_btn = New System.Windows.Forms.Button
        Me.Sav_btn = New System.Windows.Forms.Button
        Me.Zoom_lbl = New System.Windows.Forms.Label
        Me.Zoom_cbx = New System.Windows.Forms.ComboBox
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Billing_pd
        '
        Me.Billing_pd.DocumentName = "Document"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(637, 486)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(637, 486)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Billing_ppc)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(637, 486)
        Me.SplitContainer1.SplitterDistance = 449
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 1
        '
        'Billing_ppc
        '
        Me.Billing_ppc.AutoZoom = False
        Me.Billing_ppc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Billing_ppc.Document = Me.Billing_pd
        Me.Billing_ppc.Location = New System.Drawing.Point(0, 0)
        Me.Billing_ppc.Name = "Billing_ppc"
        Me.Billing_ppc.Size = New System.Drawing.Size(633, 445)
        Me.Billing_ppc.TabIndex = 1
        Me.Billing_ppc.Zoom = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Per_lbl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PageSet_btn, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SavPrnt_btn, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Prnt_btn, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Sav_btn, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Zoom_lbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Zoom_cbx, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(633, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Per_lbl
        '
        Me.Per_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Per_lbl.AutoSize = True
        Me.Per_lbl.Location = New System.Drawing.Point(103, 9)
        Me.Per_lbl.Name = "Per_lbl"
        Me.Per_lbl.Size = New System.Drawing.Size(14, 13)
        Me.Per_lbl.TabIndex = 6
        Me.Per_lbl.Text = "%"
        '
        'PageSet_btn
        '
        Me.PageSet_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PageSet_btn.Location = New System.Drawing.Point(279, 3)
        Me.PageSet_btn.Name = "PageSet_btn"
        Me.PageSet_btn.Size = New System.Drawing.Size(79, 25)
        Me.PageSet_btn.TabIndex = 2
        Me.PageSet_btn.Text = "Page Setup"
        Me.PageSet_btn.UseVisualStyleBackColor = True
        '
        'SavPrnt_btn
        '
        Me.SavPrnt_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SavPrnt_btn.Enabled = False
        Me.SavPrnt_btn.Location = New System.Drawing.Point(534, 3)
        Me.SavPrnt_btn.Name = "SavPrnt_btn"
        Me.SavPrnt_btn.Size = New System.Drawing.Size(79, 25)
        Me.SavPrnt_btn.TabIndex = 0
        Me.SavPrnt_btn.Text = "Save & Print"
        Me.SavPrnt_btn.UseMnemonic = False
        Me.SavPrnt_btn.UseVisualStyleBackColor = True
        '
        'Prnt_btn
        '
        Me.Prnt_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Prnt_btn.Location = New System.Drawing.Point(449, 3)
        Me.Prnt_btn.Name = "Prnt_btn"
        Me.Prnt_btn.Size = New System.Drawing.Size(79, 25)
        Me.Prnt_btn.TabIndex = 1
        Me.Prnt_btn.Text = "Print"
        Me.Prnt_btn.UseVisualStyleBackColor = True
        '
        'Sav_btn
        '
        Me.Sav_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sav_btn.Enabled = False
        Me.Sav_btn.Location = New System.Drawing.Point(364, 3)
        Me.Sav_btn.Name = "Sav_btn"
        Me.Sav_btn.Size = New System.Drawing.Size(79, 25)
        Me.Sav_btn.TabIndex = 3
        Me.Sav_btn.Text = "Save"
        Me.Sav_btn.UseMnemonic = False
        Me.Sav_btn.UseVisualStyleBackColor = True
        '
        'Zoom_lbl
        '
        Me.Zoom_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Zoom_lbl.AutoSize = True
        Me.Zoom_lbl.Location = New System.Drawing.Point(4, 9)
        Me.Zoom_lbl.Name = "Zoom_lbl"
        Me.Zoom_lbl.Size = New System.Drawing.Size(37, 13)
        Me.Zoom_lbl.TabIndex = 4
        Me.Zoom_lbl.Text = "Zoom:"
        '
        'Zoom_cbx
        '
        Me.Zoom_cbx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Zoom_cbx.FormattingEnabled = True
        Me.Zoom_cbx.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100", "150", "200", "250", "300", "350", "400"})
        Me.Zoom_cbx.Location = New System.Drawing.Point(48, 5)
        Me.Zoom_cbx.Name = "Zoom_cbx"
        Me.Zoom_cbx.Size = New System.Drawing.Size(49, 21)
        Me.Zoom_cbx.TabIndex = 5
        '
        'PageSetupDialog
        '
        Me.PageSetupDialog.Document = Me.Billing_pd
        '
        'PreviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 486)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "PreviewForm"
        Me.Text = "Preview"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Billing_pd As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SavPrnt_btn As System.Windows.Forms.Button
    Friend WithEvents Prnt_btn As System.Windows.Forms.Button
    Friend WithEvents Billing_ppc As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PageSet_btn As System.Windows.Forms.Button
    Friend WithEvents Sav_btn As System.Windows.Forms.Button
    Friend WithEvents Zoom_lbl As System.Windows.Forms.Label
    Friend WithEvents Zoom_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Per_lbl As System.Windows.Forms.Label
End Class
