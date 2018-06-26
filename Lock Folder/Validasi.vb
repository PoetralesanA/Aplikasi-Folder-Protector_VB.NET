Public Class Validasi
    Private Sub CheckPassword(sender As Object, e As EventArgs) Handles Button1.Click
        RegCheckPwd() ' <~ Sub ini Berada pada Module "Config"
    End Sub

    Private Sub Validasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.UseSystemPasswordChar = True 'Textboxt1 akan membentuk character password
    End Sub
    Private Sub ShowHidePWD(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then 'Jike checkbox1 dicentang, maka _
            TextBox1.UseSystemPasswordChar = False 'character password pada Textbox1 hilang
        Else ' jika checkbox tidak dicentang, Maka
            TextBox1.UseSystemPasswordChar = True 'textboxt1 akan menampilkan character password
        End If
    End Sub
End Class