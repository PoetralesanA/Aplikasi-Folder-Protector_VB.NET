Imports Microsoft.Win32.Registry
Public Class Welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btN_SetPwd.Click
        If PwD.TextLength And ValPwd.TextLength < 8 Then
            MessageBox.Show("Password harus 8 / lebih dari 8 karakter")
        Else
            If PwD.Text <> ValPwd.Text Then ' jika password tidak sama seperti validasi password, Maka _
                MsgBox("Password Tidak Sama", MsgBoxStyle.Exclamation, "") 'tampil pesan

                PwD.BackColor = Color.Red
                ValPwd.BackColor = Color.Red
            ElseIf ValPwd.Text = "" Or
                                PwD.Text = "" Then 'jika Validasi kosong / pwd Kosong, Maka _
                MsgBox("Password Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "") ' Tampil pesan

            Else ' sebaliknya ( jika terpenuhi )
                SetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Password", PwD.Text) 'isi Value yang diketik pada Texbox PwD
                InptAuth() ' <~ Berada Pada Module Config

                MsgBox("Set Password Berhasil", MsgBoxStyle.Information, "")
                MsgBox("Welcome.. " & My.Computer.Name, MsgBoxStyle.Information, "")

                LogiN.Show() ' tampil main form
                Me.Close() ' form sekarang, keluar
            End If
        End If
    End Sub
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LcN.Text = My.Resources.Eula

        NamePC()

        CheckUsr() ' <~ berada pada module Config

        SetPlace(PwD, "Password") ' <~ PlaceHolder
        SetPlace(ValPwd, "Validasi Passowrd") ' <~ PlaceHolder
        mainForm.hs()
        '/////////////////////////////////////////////////////////
        'Disable semua fungsi ketika dijalankan awal tampil
        '/////////////////////////////////////////////////////////
        '--------------------- False---------------------'
        btN_SetPwd.Enabled = False
        PwD.Enabled = False
        ValPwd.Enabled = False
        '-----------------------------------------------'
        '/////////////////////////////////////////////////////////
    End Sub

    Private Sub mainSiniQaqaaa(sender As Object, e As EventArgs) Handles btN_visiT.Click
        Process.Start("https://www.facebook.com/poetralesana")
    End Sub

    Private Sub Checkbox(sender As Object, e As EventArgs) Handles Cbx.CheckedChanged
        If Not Cbx.Checked = True Then ' jika Checkbox tidak dicentang, Maka..

            btN_SetPwd.Enabled = False 'btn tidak berfungsi
            PwD.Enabled = False 'text pwd tidak berfungsi
            ValPwd.Enabled = False ' text validasi pwd tidak berfungsi

        Else ' sebaliknya ( jika Checkbox Dicentang ), Maka

            btN_SetPwd.Enabled = True ' button berfungsi
            PwD.Enabled = True ' pwd berfungsi
            ValPwd.Enabled = True ' validasi berfungsi
        End If
    End Sub
    Private Sub NamePC()
        Me.Text = "Welcome beb " & My.Computer.Name.ToLower
    End Sub

    Private Sub PwD_Click(sender As Object, e As EventArgs) Handles PwD.Click
        PwD.BackColor = Color.White
        ValPwd.BackColor = Color.White
    End Sub

End Class