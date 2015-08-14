Imports Microsoft.Win32

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim GetProductKey As GetProductKey = New GetProductKey()
        Dim RawKey As Byte() = GetProductKey.GetKey()

        Dim KeyConverter As KeyConverter = New KeyConverter()
        Dim Key As String = KeyConverter.convert(RawKey)

        ProductKey.Text = Key
        Dim CopyToClipboard As CopyToClipboard = New CopyToClipboard()
        CopyToClipboard.copy(Key)
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class