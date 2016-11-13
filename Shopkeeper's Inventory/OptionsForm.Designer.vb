<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Me.Close_Btn = New System.Windows.Forms.Button
        Me.Ok_Btn = New System.Windows.Forms.Button
        Me.Add_RdBtn = New System.Windows.Forms.RadioButton
        Me.Edit_RdBtn = New System.Windows.Forms.RadioButton
        Me.InvOpt_Lbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Close_Btn
        '
        Me.Close_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close_Btn.Location = New System.Drawing.Point(355, 107)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(64, 23)
        Me.Close_Btn.TabIndex = 9
        Me.Close_Btn.Text = "Close"
        Me.Close_Btn.UseVisualStyleBackColor = True
        '
        'Ok_Btn
        '
        Me.Ok_Btn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Ok_Btn.Location = New System.Drawing.Point(285, 107)
        Me.Ok_Btn.Name = "Ok_Btn"
        Me.Ok_Btn.Size = New System.Drawing.Size(64, 23)
        Me.Ok_Btn.TabIndex = 8
        Me.Ok_Btn.Text = "Ok"
        Me.Ok_Btn.UseVisualStyleBackColor = True
        '
        'Add_RdBtn
        '
        Me.Add_RdBtn.AutoSize = True
        Me.Add_RdBtn.Checked = True
        Me.Add_RdBtn.Location = New System.Drawing.Point(153, 47)
        Me.Add_RdBtn.Name = "Add_RdBtn"
        Me.Add_RdBtn.Size = New System.Drawing.Size(101, 17)
        Me.Add_RdBtn.TabIndex = 7
        Me.Add_RdBtn.TabStop = True
        Me.Add_RdBtn.Text = "Add new entries"
        Me.Add_RdBtn.UseVisualStyleBackColor = True
        '
        'Edit_RdBtn
        '
        Me.Edit_RdBtn.AutoSize = True
        Me.Edit_RdBtn.Location = New System.Drawing.Point(153, 70)
        Me.Edit_RdBtn.Name = "Edit_RdBtn"
        Me.Edit_RdBtn.Size = New System.Drawing.Size(151, 17)
        Me.Edit_RdBtn.TabIndex = 6
        Me.Edit_RdBtn.Text = "Edit/Delete existing entries"
        Me.Edit_RdBtn.UseVisualStyleBackColor = True
        '
        'InvOpt_Lbl
        '
        Me.InvOpt_Lbl.AutoSize = True
        Me.InvOpt_Lbl.Location = New System.Drawing.Point(12, 24)
        Me.InvOpt_Lbl.Name = "InvOpt_Lbl"
        Me.InvOpt_Lbl.Size = New System.Drawing.Size(133, 13)
        Me.InvOpt_Lbl.TabIndex = 5
        Me.InvOpt_Lbl.Text = "What would you like to do:"
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.Ok_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 141)
        Me.Controls.Add(Me.Close_Btn)
        Me.Controls.Add(Me.Ok_Btn)
        Me.Controls.Add(Me.Add_RdBtn)
        Me.Controls.Add(Me.Edit_RdBtn)
        Me.Controls.Add(Me.InvOpt_Lbl)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 175)
        Me.MinimumSize = New System.Drawing.Size(440, 175)
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close_Btn As System.Windows.Forms.Button
    Friend WithEvents Ok_Btn As System.Windows.Forms.Button
    Friend WithEvents Add_RdBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Edit_RdBtn As System.Windows.Forms.RadioButton
    Friend WithEvents InvOpt_Lbl As System.Windows.Forms.Label
End Class
