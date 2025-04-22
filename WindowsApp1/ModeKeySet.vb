Public Class ModeKeySet

    Private Sub ModeKeySet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddKeyItem_LA2(cmbModeKey1)
        AddKeyItem_LA2(cmbModeKey2)
        cmbModeKey1.Text = "["
        cmbModeKey2.Text = "]"
    End Sub

    Dim strKey2() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "[", "]", ",", ".", ";", "'", "-", "="}

    Public Sub AddKeyItem_LA2(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey2.Length - 1
            cbo.Items.Add(strKey2(i))
        Next
        cbo.SelectedIndex = 0
    End Sub

    Private Sub cmbModeKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModeKey1.SelectedIndexChanged, cmbModeKey2.SelectedIndexChanged
        If cmbModeKey1.Text.Length > 0 And cmbModeKey2.Text.Length > 0 Then
            Form1.mkeyL = cmbModeKey1.Text
            Form1.mkeyR = cmbModeKey2.Text
        End If
    End Sub

End Class