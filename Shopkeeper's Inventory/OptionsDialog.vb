Imports System.IO
Imports System.Security.Cryptography

Public Class OptionsDialog

    Private TriDES As New TripleDESCryptoServiceProvider

    Private Sub Opt_lbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_lbx.SelectedIndexChanged
        If Me.Opt_lbx.SelectedIndex = 0 Then
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Billing_gbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Printing_gbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.General_gbx)
        ElseIf Me.Opt_lbx.SelectedIndex = 1 Then
            Me.SplitContainer1.Panel2.Controls.Remove(Me.General_gbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Printing_gbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Billing_gbx)
        ElseIf Me.Opt_lbx.SelectedIndex = 2 Then
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Billing_gbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.General_gbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Printing_gbx)
        End If
    End Sub

    Private Sub OptionsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = True Then
            My.Computer.Registry.LocalMachine.CreateSubKey("Software\Shopkeeper's Inventory")
            Me.Name_tbx.Text = "My Shop"
            Me.Currency_cbx.SelectedIndex = 0
            Me.Paper_cbx.SelectedIndex = 1
            Me.Space_cbx.SelectedIndex = 1
            Me.Auto_ckbx.Checked = True
            Me.Prefix_ckbx.Checked = True
            Me.Prefix_cbx.SelectedIndex = 1
            Me.ItmDisc_ckbx.Checked = True
            Me.Paper_cbx.SelectedIndex = 0
            Me.HeadAdd_ckbx.Checked = True
            Me.HeadDate_ckbx.Checked = True
            Me.HeadPhone_ckbx.Checked = True
            Me.FootText_tbx.Text = "Thank You!"
            Me.Opt_lbx.SelectedIndex = 0
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
            FillGenPref()
            Me.Auto_ckbx.Checked = True
            Me.Prefix_ckbx.Checked = True
            FillBillPref()
            FillPrintPref()
            Me.Opt_lbx.SelectedIndex = 0
            Me.Apply_btn.Enabled = False
        End If
    End Sub

    Private Sub Paper_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paper_cbx.SelectedIndexChanged
        If Me.Paper_cbx.SelectedIndex = 1 Then
            Me.FootPage_ckbx.Checked = True
            Me.FootPage_ckbx.Enabled = True
            Me.Template_btn.Enabled = True
        ElseIf Me.Paper_cbx.SelectedIndex = 0 Then
            Me.FootPage_ckbx.Checked = False
            Me.FootPage_ckbx.Enabled = False
            Me.Template_btn.Text = "Simple"
            Me.Template_btn.Enabled = False
        End If
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Auto_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Auto_ckbx.CheckedChanged
        If Me.Auto_ckbx.Checked Then
            Me.Prefix_ckbx.Enabled = True
            Me.Start_tbx.Enabled = True
            Me.Step_tbx.Enabled = True
        ElseIf Me.Auto_ckbx.Checked = False Then
            Me.Prefix_ckbx.Checked = False
            Me.Prefix_ckbx.Enabled = False
            Me.Start_tbx.Enabled = False
            Me.Step_tbx.Enabled = False
        End If
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Prefix_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prefix_ckbx.CheckedChanged
        If Me.Prefix_ckbx.Checked Then
            Me.Prefix_cbx.Enabled = True
            Me.Prefix_tbx.Enabled = True
        ElseIf Me.Prefix_ckbx.Checked = False Then
            Me.Prefix_cbx.Enabled = False
            Me.Prefix_tbx.Enabled = False
        End If
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Prefix_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prefix_cbx.SelectedIndexChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Prefix_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prefix_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Start_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Step_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Step_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub ItmDisc_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmDisc_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub HeadAdd_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadAdd_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub HeadPhone_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadPhone_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub HeadDate_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadDate_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub PCode_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCode_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub FootText_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FootText_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub FootPage_ckbx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FootPage_ckbx.CheckedChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Name_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Add1_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add1_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Add2_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add2_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub City_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub State_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles State_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Pin_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pin_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Phone_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Phone_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Apply_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_btn.Click
        GenPref()
        BillPref()
        PrintPref()
        Me.Apply_btn.Enabled = False
        Me.AcceptButton = Me.Ok_btn
    End Sub

    Private Sub Cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub Ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        If Me.Apply_btn.Enabled = True Then
            Me.Cursor = Cursors.WaitCursor
            GenPref()
            BillPref()
            PrintPref()
            Me.Cursor = Cursors.Default
            Me.Close()
        ElseIf Me.Apply_btn.Enabled = False Then
            Me.Close()
        End If
        
    End Sub

    Private Sub Currency_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Currency_cbx.SelectedIndexChanged
        If Me.Currency_cbx.SelectedIndex = 3 Then
            Me.Currency_tbx.Enabled = True
        Else
            Me.Currency_tbx.Enabled = False
        End If
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Currency_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Currency_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Note_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Note_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Space_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Space_cbx.SelectedIndexChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Template_btn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Template_btn.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub email_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

    Private Sub Website_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Website_tbx.TextChanged
        Me.Apply_btn.Enabled = True
    End Sub

#Region "Methods"

    Private Sub GenPref()
        'If Me.Name_tbx.Text = "" Then
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ShopName", "My Shop", Microsoft.Win32.RegistryValueKind.String)
        'ElseIf Me.Name_tbx.Text <> "" Then
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ShopName", Me.Name_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'End If
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Address1", Me.Add1_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Address2", Me.Add2_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "City", Me.City_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "State", Me.State_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Pin", Me.Pin_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Phone", Me.Phone_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)
        Dim Key As String = My.User.Name
        Dim Opt As String = (Me.Name_tbx.Text & vbCrLf & Me.Add1_tbx.Text & vbCrLf & Me.Add2_tbx.Text & vbCrLf & Me.City_tbx.Text & vbCrLf & Me.State_tbx.Text & vbCrLf & Me.Pin_tbx.Text & vbCrLf & Me.Phone_tbx.Text & vbCrLf & Me.email_tbx.Text & vbCrLf & Me.Website_tbx.Text).ToString

        TriDES.Key = TruncHash(Key, TriDES.KeySize \ 8)
        TriDES.IV = TruncHash("", TriDES.BlockSize \ 8)
        Dim OptBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Opt)
        Dim MS As New MemoryStream
        Dim ES As New CryptoStream(MS, TriDES.CreateEncryptor(), CryptoStreamMode.Write)
        ES.Write(OptBytes, 0, OptBytes.Length)
        ES.FlushFinalBlock()
        Dim CryptOpt As String = Convert.ToBase64String(MS.ToArray)

        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "/Data/Opt.sof", CryptOpt, False)

        If Me.Currency_cbx.SelectedIndex = 0 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", Me.Currency_cbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        ElseIf Me.Currency_cbx.SelectedIndex = 1 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", Me.Currency_cbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        ElseIf Me.Currency_cbx.SelectedIndex = 2 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", Me.Currency_cbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        ElseIf Me.Currency_cbx.SelectedIndex = 3 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", Me.Currency_tbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        End If

    End Sub

    Private Sub FillGenPref()
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/Data/Opt.sof") Then
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
            Catch ex As Exception
                Exit Sub
            End Try
            Dim Opt As String = System.Text.Encoding.Unicode.GetString(MS.ToArray)
            Dim GenOpt() As String = Opt.Split(vbCrLf)
            Me.Name_tbx.Text = GenOpt(0).ToString
            Me.Add1_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2)
            Me.Add2_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2)
            Me.City_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(3).ToString, 2)
            Me.State_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(4).ToString, 2)
            Me.Pin_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(5).ToString, 2)
            Me.Phone_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(6).ToString, 2)
            Me.email_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(7).ToString, 2)
            Me.Website_tbx.Text = Microsoft.VisualBasic.Mid(GenOpt(8).ToString, 2)
        End If
        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        If Currency = "Rs." Then
            Me.Currency_cbx.SelectedIndex = 0
        ElseIf Currency = "$" Then
            Me.Currency_cbx.SelectedIndex = 1
        ElseIf Currency = "€" Then
            Me.Currency_cbx.SelectedIndex = 2
        Else
            Me.Currency_cbx.SelectedIndex = 3
            Me.Currency_tbx.Enabled = True
            Me.Currency_tbx.Text = Currency
        End If
    End Sub

    Private Sub BillPref()
        If Me.Auto_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.Auto_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.Prefix_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifPrePrefix", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.Prefix_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifPrePrefix", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.ItmDisc_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.ItmDisc_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Me.Prefix_cbx.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "OPrefix", Me.Prefix_tbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", Me.Start_tbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Step", Me.Step_tbx.Text.ToString(), Microsoft.Win32.RegistryValueKind.String)

    End Sub

    Private Sub FillBillPref()
        Dim Checked As Integer = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1))
        If Checked = 0 Then
            Me.Auto_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.Auto_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifPrePrefix", 1))
        If Checked = 0 Then
            Me.Prefix_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.Prefix_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 1))
        If Checked = 0 Then
            Me.ItmDisc_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.ItmDisc_ckbx.Checked = True
        End If
        Me.Prefix_cbx.SelectedIndex = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", 1))
        Me.Prefix_tbx.Text = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "OPrefix", "")).ToString
        Me.Start_tbx.Text = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "00001")).ToString
        Me.Step_tbx.Text = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Step", "1")).ToString
    End Sub

    Private Sub PrintPref()
        If Me.HeadAdd_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadAdd", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.HeadAdd_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadAdd", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.HeadPhone_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadPhone", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf HeadPhone_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadPhone", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.HeadDate_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadDate", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.HeadDate_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadDate", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.PCode_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.PCode_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If Me.FootPage_ckbx.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "FootPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
        ElseIf Me.FootPage_ckbx.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "FootPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PaperS", Me.Paper_cbx.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Spacing", Me.Space_cbx.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Footer", Me.FootText_tbx.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
    End Sub

    Private Sub FillPrintPref()
        Dim Checked As Integer = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadAdd", 1))
        If Checked = 0 Then
            Me.HeadAdd_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.HeadAdd_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadPhone", 1))
        If Checked = 0 Then
            Me.HeadPhone_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.HeadPhone_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "HeadDate", 1))
        If Checked = 0 Then
            Me.HeadDate_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.HeadDate_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0))
        If Checked = 0 Then
            Me.PCode_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.PCode_ckbx.Checked = True
        End If
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "FootPage", 1))
        If Checked = 0 Then
            Me.FootPage_ckbx.Checked = False
        ElseIf Checked = 1 Then
            Me.FootPage_ckbx.Checked = True
        End If
        Me.Paper_cbx.SelectedIndex = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PaperS", 1))
        Me.Space_cbx.SelectedIndex = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Spacing", 1))
        Me.FootText_tbx.Text = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Footer", "")).ToString
    End Sub

    Private Function TruncHash(ByVal key As String, ByVal lnth As Integer) As Byte()
        Dim Sha1 As New SHA1CryptoServiceProvider
        Dim KeyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = Sha1.ComputeHash(KeyBytes)
        ReDim Preserve hash(lnth - 1)
        Return hash
    End Function

#End Region

End Class