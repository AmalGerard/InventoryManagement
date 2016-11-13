<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Opt_Lbl = New System.Windows.Forms.Label
        Me.Inventory_RdBtn = New System.Windows.Forms.RadioButton
        Me.Bill_RdBtn = New System.Windows.Forms.RadioButton
        Me.Ok_Btn = New System.Windows.Forms.Button
        Me.Close_Btn = New System.Windows.Forms.Button
        Me.Stock_rdbtn = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Opt_Lbl
        '
        Me.Opt_Lbl.AutoSize = True
        Me.Opt_Lbl.Location = New System.Drawing.Point(12, 24)
        Me.Opt_Lbl.Name = "Opt_Lbl"
        Me.Opt_Lbl.Size = New System.Drawing.Size(133, 13)
        Me.Opt_Lbl.TabIndex = 0
        Me.Opt_Lbl.Text = "What would you like to do:"
        '
        'Inventory_RdBtn
        '
        Me.Inventory_RdBtn.AutoSize = True
        Me.Inventory_RdBtn.Location = New System.Drawing.Point(153, 47)
        Me.Inventory_RdBtn.Name = "Inventory_RdBtn"
        Me.Inventory_RdBtn.Size = New System.Drawing.Size(111, 17)
        Me.Inventory_RdBtn.TabIndex = 1
        Me.Inventory_RdBtn.Text = "Manage Inventory"
        Me.Inventory_RdBtn.UseVisualStyleBackColor = True
        '
        'Bill_RdBtn
        '
        Me.Bill_RdBtn.AutoSize = True
        Me.Bill_RdBtn.Location = New System.Drawing.Point(153, 70)
        Me.Bill_RdBtn.Name = "Bill_RdBtn"
        Me.Bill_RdBtn.Size = New System.Drawing.Size(78, 17)
        Me.Bill_RdBtn.TabIndex = 2
        Me.Bill_RdBtn.Text = "Prepare Bill"
        Me.Bill_RdBtn.UseVisualStyleBackColor = True
        '
        'Ok_Btn
        '
        Me.Ok_Btn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Ok_Btn.Location = New System.Drawing.Point(285, 107)
        Me.Ok_Btn.Name = "Ok_Btn"
        Me.Ok_Btn.Size = New System.Drawing.Size(64, 23)
        Me.Ok_Btn.TabIndex = 3
        Me.Ok_Btn.Text = "Ok"
        Me.Ok_Btn.UseVisualStyleBackColor = True
        '
        'Close_Btn
        '
        Me.Close_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close_Btn.Location = New System.Drawing.Point(355, 107)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(64, 23)
        Me.Close_Btn.TabIndex = 4
        Me.Close_Btn.Text = "Exit"
        Me.Close_Btn.UseVisualStyleBackColor = True
        '
        'Stock_rdbtn
        '
        Me.Stock_rdbtn.AutoSize = True
        Me.Stock_rdbtn.Checked = True
        Me.Stock_rdbtn.Location = New System.Drawing.Point(153, 24)
        Me.Stock_rdbtn.Name = "Stock_rdbtn"
        Me.Stock_rdbtn.Size = New System.Drawing.Size(95, 17)
        Me.Stock_rdbtn.TabIndex = 5
        Me.Stock_rdbtn.TabStop = True
        Me.Stock_rdbtn.Text = "Manage Stock"
        Me.Stock_rdbtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.Ok_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Close_Btn
        Me.ClientSize = New System.Drawing.Size(432, 141)
        Me.Controls.Add(Me.Stock_rdbtn)
        Me.Controls.Add(Me.Close_Btn)
        Me.Controls.Add(Me.Ok_Btn)
        Me.Controls.Add(Me.Bill_RdBtn)
        Me.Controls.Add(Me.Inventory_RdBtn)
        Me.Controls.Add(Me.Opt_Lbl)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 175)
        Me.MinimumSize = New System.Drawing.Size(440, 175)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShopKeeper's Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Opt_Lbl As System.Windows.Forms.Label
    Friend WithEvents Inventory_RdBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Bill_RdBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Ok_Btn As System.Windows.Forms.Button
    Friend WithEvents Close_Btn As System.Windows.Forms.Button
    Friend WithEvents Stock_rdbtn As System.Windows.Forms.RadioButton

End Class
