Imports Microsoft.Win32.Registry
Public Class LogiN
    Private Sub CheckSes()
        Dim Session = GetValue("Hkey_Local_Machine\Software\VB Folder Protect", "SsN", Nothing)

        If Session = "1" Then
            mainForm.Show()
            Me.Close()
        Else
            If Session = "0" Then
                Me.Show()
            End If
        End If
    End Sub

    Private Sub LogiN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Cursor = Cursors.Hand

        CheckSes()

        TextPassword.UseSystemPasswordChar = True 'Text berkarakter password
        SetPlace(TextPassword, "Password") ' PlaceHolder
    End Sub

    Private Sub ButtonLOGIN(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            System.Threading.Thread.Sleep(1700) ' jeda
            Dim PwdCheck = GetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Password", Nothing) 'Check Password

            If TextPassword.Text = PwdCheck Then ' jika password yang diketik sama dengan regedit, Maka _
                mainForm.Show() ' main form Tampil
                MsgBox("Welcome " & My.Computer.Name.ToLower, MsgBoxStyle.Information, "") 'To Lower, berfungsi agar huruf menjadi Kecil. 
                '                                              Kalian bisa berexperimen dgan cara Menghilangkannya, agar megetahui proses kerja'x.
                Me.Close() ' Form Login Keluar
            ElseIf TextPassword.Text = "" Then ' jika password Kosong, Maka _
                TextPassword.BackColor = Color.Red ' TextPassword berwarna merah

                MsgBox("Password Tidak Boleh Kosong!!", MsgBoxStyle.Exclamation, "") ' Menampilkan pesan
                TextPassword.Focus() ' Cursor/IBeam . akan focus pada TextPassword
            Else
                '////////////////////////////////////////////
                '        Sama seperti di atas Cuyy
                TextPassword.BackColor = Color.Red
                MsgBox("n00bz", MsgBoxStyle.Exclamation, "")

                TextPassword.Clear()
                TextPassword.Focus()
                '////////////////////////////////////////////
            End If

        Catch x As Exception

        End Try
    End Sub

    Private Sub ClickText(sender As Object, e As EventArgs) Handles TextPassword.Click ' Text Click 
        'artinya , Jika TextPassword diclick, maka warna-nya akan berubah menjadi....
        TextPassword.BackColor = Color.WhiteSmoke

        'ho'oh.. benar sekali..
    End Sub
End Class