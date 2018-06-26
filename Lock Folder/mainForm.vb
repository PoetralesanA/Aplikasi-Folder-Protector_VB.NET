Imports System.IO ' Library untuk membaca path Drive & File
Imports System.Security.AccessControl ' Library untuk Membuat "batas" penggunaan Folder & juga menghapus "batas" penggunaan folder _
'                                       singkatnya "me-manage" seluruh Premision
Public Class mainForm
    Dim spasi = vbNewLine
    Private Sub CoderMessage(sender As Object, e As EventArgs) Handles CoderToolStripMenuItem.Click
        MsgBox("Easy Folder Locker" & spasi _
               & "n00b author : PoetralesanA." & spasi _
               & spasi & "Thanks For Gugun", MsgBoxStyle.Information, "n00bz_")
    End Sub

    Private Sub KunciFolder(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim DirSec As DirectorySecurity = Directory.GetAccessControl(TextBox2.Text)

            Dim AksesControl As FileSystemAccessRule =
                             New FileSystemAccessRule _
                                (Environment.UserName,
                                 FileSystemRights.FullControl,
                                 AccessControlType.Deny)

            '----------------------------------------------- Penjelasan -----------------------------------------------'
            '1. Environment.UserName = letak lokasi User ( Nama User Kita )
            '2. FileSystemRights.FullControl =  Jika "Environment.UserName" telah ditemukan, Kemudian Akan mencentang "seluruh aksesnya".
            '3. AccessControlType.Deny = akses yang dicentang pada nomor 2, akan memilih premision / hak akses yang "tidak diperbolehkan" _ 
            '                            (mencentang keseluruhannya)/(Full)
            '----------------------------------------------- Penjelasan -----------------------------------------------'

            DirSec.AddAccessRule(AksesControl) 'Menambah User baru & premision baru yang telah kita manipulasi di atas

            Directory.SetAccessControl(TextBox2.Text, DirSec) ' letak folder yang akan kita Block aksesnya

            LoadingProgress.Start() ' ...

            status.Text = Button1.Text 'untuk memanipulasi progressbar. agar Pesan yang ditampilkan, sesuai dengan yang terjadi _
            '                           Teman2 bisa cek pada coding PrgsBarTime/LoadingProgress agar lebih mengerti alurnya

        Catch ex As Exception ' ksalahan
            MsgBox("Perintah ditolak, Path belum ditentukan" & spasi &
                  "Klik button Browse untuk menetukan folder yang akan di Protect", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub PrgsBarTime(sender As Object, e As EventArgs) Handles LoadingProgress.Tick
        '--------------------------------- L O G ---------------------------------'
        ProgressBar1.Value += 4
        If ProgressBar1.Value = 100 Then
            LoadingProgress.Stop()

            ListBox1.Items.Add("=====================")
            ListBox1.Items.Add(KelEnder.Text)
            If status.Text = cRt_Folder.Text Then ' Kunci Folder
                MsgBox("Folder berhasil Dibuat pada path " _
                       & TextBox2.Text, MsgBoxStyle.Information, "")

                ListBox1.Items.Add("Path Folder " & TextBox1.Text)

            ElseIf status.Text = Button1.Text Then ' button Kunci
                MsgBox("Folder berhasil dikunci pada path " _
                    & TextBox2.Text, MsgBoxStyle.Information, "")

                ListBox1.Items.Add(My.Resources.mSgKunci & TextBox2.Text)

            ElseIf status.Text = Button2.Text Then
                MsgBox("Folder berhasil dibuka pada path" & spasi _
                         & TextBox2.Text, MsgBoxStyle.Information, "")

                ListBox1.Items.Add(My.Resources.mSgBuka & TextBox2.Text)
                '--------------------------------------------------------------------------'
            End If
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub BuatFolder(sender As Object, e As EventArgs) Handles cRt_Folder.Click
        Dim path = TextBox1.Text
        If IO.Directory.Exists(path) Then
            MsgBox("Folder Sudah Ada Pada Lokasi : " & spasi &
                   TextBox1.Text, MsgBoxStyle.Exclamation, "")
        Else
            Directory.CreateDirectory(TextBox1.Text) ' <~~ Pemilihan Default C:/Folder Lock _
            '                                              Buat File / Folder, Kemudian

            TextBox2.Text = TextBox1.Text

            LoadingProgress.Start()
            status.Text = cRt_Folder.Text
        End If

    End Sub

    Private Sub Search(sender As Object, e As EventArgs) Handles findFile.Click
        BrowseFolder.ShowDialog() 'Cari File
        TextBox2.Text = BrowseFolder.SelectedPath 'Path Browse akan tersimpan pada Textboxt2

        ProgressBar1.Value = 0 ' mereset progressbar kembali ke nol
    End Sub
    Private Sub BukaKunci(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            '-------------------------------------------------------------------------------'
            Dim DirSec As DirectorySecurity = Directory.GetAccessControl(TextBox2.Text)

            Dim AksesControl As FileSystemAccessRule =
                             New FileSystemAccessRule(
                                                    Environment.UserName,
                                                    FileSystemRights.FullControl,
                                                    AccessControlType.Deny)
            '     ~>  Penjelasan dari kseluruhan syntax ini sama sprti di atas ( syntax Kunci Folder )
            '    -------------------------------------------------------------------------------'




            DirSec.RemoveAccessRule(AksesControl) 'menghapus seluruh premission control

            Directory.SetAccessControl(TextBox2.Text, DirSec) ' membuat akses control pada lokasi Textbox2
            status.Text = Button2.Text

            LoadingProgress.Start() ' sama kyk di atas ( Syntax Kunci Folder ) . :p

        Catch ex As Exception
            MsgBox("Perintah ditolak, Path belum ditentukan" & spasi &
                   "Klik button Browse untuk menetukan folder yang akan di Unprotect", MsgBoxStyle.Critical, "")
        End Try

    End Sub
    Private Sub Load_BacaLog(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Visible = False 'label pada Form main tidak akan terlihat ketika di runging
        Try
            Dim LogPath() = File.ReadAllLines("C:\AppLocker.log") ' ("C:\AppLocker.log") ialah letak Jejak/Log pengguna'an Aplikasi ini .. _
            ' File.ReadAllLines = membukafile.laluMembaca setiap Line

            ListBox1.Items.AddRange(LogPath) ' mengambil Logpath pada AppLocker.log

        Catch oazayakann As Exception
        End Try

        TrueSes() ' <~ Check Module Config, agar Lebih Jelas.
    End Sub
#Region "QuCyngQmoe"

#End Region
    Private Sub SaveLog()
        Try

            Dim Write As New StreamWriter("C:\AppLocker.log") 'lokasi yang akan digunakan untuk menulis & menyimpan data dari Listbox

            For Each listBx In ListBox1.Items ' <~ menggunakan for each, agar bisa membaca keseluruhan data pada Listbox1 dan kemudian (setelah terbaca ) _
                Write.WriteLine(listBx) ' maka akan menulis seluruh line pada Listbox1
            Next
            Write.Close() ' penulisan akan di hentikan

        Catch x As Exception

        End Try

    End Sub
    Public Sub keluar(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed ' Event Exit/Close pada Form
        SaveLog()
    End Sub
    Public Sub hs()
        abc()
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Validasi.Show() 'menampilkan form validasi
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True

        Else
            TextBox1.Enabled = False
            TextBox1.Text = "C:\Locker Folder"
        End If
    End Sub

    Private Sub SoftwareVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareVersionToolStripMenuItem.Click
        MessageBox.Show(" v1.0 ") ' Menampilkan pesan versi
    End Sub

    Private Sub ClearLog(sender As Object, e As EventArgs) Handles ClearLogToolStripMenuItem.Click
        ListBox1.Items.Clear() 'menghapus seluruh Log
    End Sub
    Private Sub LogoutBt(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        FalseSes() ' keluarkan sesi
        SaveLog() ' simpan log Listbox

        LogiN.Show() 'tampilkan login
        Me.Close() 'keluarkan mainForm
    End Sub
End Class