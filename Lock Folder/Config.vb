Imports Microsoft.Win32.Registry
Module Config
    '-------------------------------------------------------------------------------------------------------------------'
    Public Sub InptAuth()
        Try
            SetValue("Hkey_Local_Machine\Software\VB Folder Protect",
                     "Auth", "1") ' Akan mengisi session 1 pada Regedit
        Catch ex As Exception
        End Try
    End Sub
    Public Sub TrueSes()
        Try
            SetValue("Hkey_Local_Machine\Software\VB Folder Protect",
                     "SsN", "1") ' Akan mengisi session 1 pada Regedit
        Catch ex As Exception
        End Try
    End Sub
    Public Sub FalseSes()
        Try
            SetValue("Hkey_Local_Machine\Software\VB Folder Protect",
                     "SsN", "0") ' Akan mengisi session 0 pada Regedit
        Catch ex As Exception
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------------'
    Public Sub CheckUsr() ' Fungsi ini untuk meng-check Apakah user sudah pernah Login/belum
        Dim Auth = GetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Auth", Nothing)
        If Auth = "1" Then
            LogiN.Show()
            Welcome.Close()
        Else
            Welcome.Show()
        End If
    End Sub
    Public Sub RegPWInsert()
        ' Mengapa saya memberi try catch? _
        ' jika tidak diberi Try Catch maka akan menampilkan pesan error dalam penginputan value
        Try
            System.Threading.Thread.Sleep(1500) ' jeda dikit jos :D , biar lebih sistematis :D
            My.Computer.Registry.SetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Password",
                                          Chnge_Pwd.TextBox1.Text)

            '----------------------------------------- PENJELASAN -----------------------------------------'
            ' My.Computer.Registry.SetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Password", Chnge_Pwd.TextBox1.Text) _
            ' adalah Path untuk menuju & menginput sekaligus membuat folder pada Lokasi Regedit

            ' Chnge_Pwd.TextBox1.Text adalah, Password yang kita input & nantinya akan tersimpan di regedit
            '----------------------------------------------------------------------------------------------'
        Catch fuck As Exception
            ' bypass error
        End Try
    End Sub
    Public Sub RegCheckPwd()
        Try
            System.Threading.Thread.Sleep(1500) ' jeda dikit jos :D , biar lebih sistematis :D | _
            '                                     facemu tak bruteforce :p ,, 
            '                                     sbenarnya  untuk keamanan juga sih.. _
            '                                     biar jika ada yang jail (melakukan percobaan password berulang2) , akan memakan waktu lama akibat jeda. xD

            Dim check = GetValue("Hkey_Local_Machine\Software\VB Folder Protect", "Password",
                                           Validasi.TextBox1.Text) ' mengambil value dari Password

            If check <> Validasi.TextBox1.Text Then ' Jika password validasi ( <> )tidak sama dgan Textboxt1, Maka akan _
                MsgBox("Password yang anda masukan Salah", MsgBoxStyle.Critical, "") ' Tampil pesan

                Validasi.TextBox1.Clear() ' kemudian text dihapus
                Validasi.TextBox1.Focus() ' lalu Focus pada textbox1
            Else ' Jika benar, Maka _
                Chnge_Pwd.Show() ' form Change Password, Tampil.
                Validasi.Close() ' form validasi, Close
            End If
        Catch ex As Exception
            ' bypass error
        End Try
    End Sub
#Region ""
    Public WithEvents mySP As Timer = New Timer()
    Public Sub abc() Handles mySP.Tick
        mySP.Interval = 3
        If Not Welcome.Label1.Text = "© PoetralesanA [ C.S.D Team ]" Then
            MessageBox.Show("kamu baik. tapi mudah untuk melupakan :(", "Trap")
            mySP.Start()
        End If
    End Sub
    '// Yah.... Ktahuan . :(
#End Region
End Module