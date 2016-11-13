Public Class OptionsForm

    Dim MyName As String

    Private Sub Close_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Btn.Click
        Me.Close()
        MainForm.Enabled = True
        MainForm.Visible = True
    End Sub

    Private Sub Ok_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Btn.Click
        If Me.Tag = "I" Then
            If Me.Edit_RdBtn.Checked = True Then
                Me.Dispose()
                EditInventoryForm.Text = MyName + " - Edit Inventory"
                EditInventoryForm.Show()
            ElseIf Me.Add_RdBtn.Checked = True Then
                Me.Dispose()
                AddInventoryForm.Text = MyName + " - Add Inventory"
                AddInventoryForm.Show()
            End If
        ElseIf Me.Tag = "B" Then
            If Me.Edit_RdBtn.Checked = True Then
                Me.Dispose()
                HistoryForm.Text = MyName + " - Billing History"
                HistoryForm.Show()
            ElseIf Me.Add_RdBtn.Checked = True Then
                Me.Dispose()
                BillingForm.Text = MyName + " - Billing"
                BillingForm.Show()
            End If
        End If

    End Sub

    Private Sub InventoryOptions_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
        MainForm.Visible = True
    End Sub

    Private Sub OptionsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyName = Microsoft.VisualBasic.Mid(Me.Tag, 2)
        Me.Tag = Microsoft.VisualBasic.Left(Me.Tag, 1)
    End Sub
End Class