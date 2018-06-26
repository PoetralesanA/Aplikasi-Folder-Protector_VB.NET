Module wtm
    Private Declare Function GetWindow Lib "user32.dll" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Private Declare Auto Function wtm Lib "user32.dll" Alias "SendMessageA" _
                (ByVal hwnd As Integer, ByVal wMsg As Integer,
                 ByVal wParam As Integer, ByVal lParam As String) As Integer

    Const GW_CHILD = 5
    Const EM_SETCUEBANNER = &H1501

    Public Sub SetPlace(ByVal Ctl As TextBox, ByVal Txt As String)
        Try
            wtm(Ctl.Handle, EM_SETCUEBANNER, 1, Txt)
        Catch ex As Exception
        End Try
    End Sub
End Module
