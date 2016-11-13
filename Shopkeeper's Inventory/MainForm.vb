Imports System.Security.Cryptography
Imports System.IO

Public Class MainForm
    Dim MyName As String
    Private TriDES As New TripleDESCryptoServiceProvider

    Private Sub Close_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Btn.Click
        Me.Close()
    End Sub

    Private Sub Ok_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Btn.Click
        If Me.Stock_rdbtn.Checked = True Then
            StockForm.Text = MyName & " - Stock Registry"
            StockForm.Show()
            Me.Enabled = False
            Me.Visible = False
        ElseIf Me.Inventory_RdBtn.Checked = True Then
            OptionsForm.Text = MyName + " - Inventory Options"
            OptionsForm.Tag = "I" + MyName
            OptionsForm.Edit_RdBtn.Text = "Edit/Delete existing entries"
            OptionsForm.Add_RdBtn.Text = "Add New entries"
            OptionsForm.Show()
            Me.Enabled = False
            Me.Visible = False
        ElseIf Me.Bill_RdBtn.Checked = True Then
            OptionsForm.Text = MyName + " - Billing Options"
            OptionsForm.Tag = "B" + MyName
            OptionsForm.Edit_RdBtn.Text = "Billing history and saved Invoices"
            OptionsForm.Add_RdBtn.Text = "Make new Invoice"
            OptionsForm.Show()
            Me.Enabled = False
            Me.Visible = False
        End If

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = True Then
            OptionsDialog.ShowDialog()
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/Data/Opt.sof") Then
            Dim Opt As String = FillGenPref()
            Dim GenOpt() As String = Opt.Split(vbCrLf)
            MyName = GenOpt(0).ToString
        Else
            MyName = "My Shop"
        End If
        Me.Text = MyName + "'s Inventory Managment"
    End Sub

    Public Function FillGenPref() As String
        Dim Opt As String
        Dim CryptOpt As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "/Data/Opt.sof")
        Dim Key As String = My.User.Name
        TriDES.Key = TruncHash(Key, TriDES.KeySize \ 8)
        TriDES.IV = TruncHash("", TriDES.BlockSize \ 8)
        Dim OptBytes() As Byte = Convert.FromBase64String(CryptOpt)
        Dim MS As New MemoryStream
        Dim DS As New CryptoStream(MS, TriDES.CreateDecryptor(), CryptoStreamMode.Write)
        DS.Write(OptBytes, 0, OptBytes.Length)
        Try
            DS.FlushFinalBlock()
        Catch ex As CryptographicException
            Dim Result As DialogResult
            Result = OptionsDialog.ShowDialog()
            If Result = System.Windows.Forms.DialogResult.Cancel Then
                Opt = "My Shop" + vbCrLf
                Return Opt
                Exit Function
            Else
                Opt = FillGenPref()
                Return Opt
                Exit Function
            End If
            
        End Try
        Opt = System.Text.Encoding.Unicode.GetString(MS.ToArray)
        Return Opt
    End Function

    Private Function TruncHash(ByVal key As String, ByVal lnth As Integer) As Byte()
        Dim Sha1 As New SHA1CryptoServiceProvider
        Dim KeyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = Sha1.ComputeHash(KeyBytes)
        ReDim Preserve hash(lnth - 1)
        Return hash
    End Function

    Private Sub MainForm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        Dim Se As Integer = InStr(1, Me.Text, "'s Inventory Managment")
        MyName = Microsoft.VisualBasic.Left(Me.Text, Se)
    End Sub
End Class
