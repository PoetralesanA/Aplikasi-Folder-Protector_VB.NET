Imports Microsoft.Win32.Registry
Public Class Chnge_Pwd

    Private Sub CheckUncheckPWD(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("data tidak boleh kosong")
        Else
            If TextBox1.Text = TextBox2.Text Then
                RegPWInsert()
                MsgBox("Password Berhasil Di Ubah", MsgBoxStyle.Information, "")
            Else
                MsgBox("Username dan Password Tidak Sama", MsgBoxStyle.Exclamation, "")
                TextBox2.Clear()
                TextBox2.Focus()
            End If
        End If
    End Sub
End Class