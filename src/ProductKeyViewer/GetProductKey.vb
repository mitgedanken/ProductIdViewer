Imports Microsoft.Win32

Public Class GetProductKey

    Public Function GetKey() As Byte()
        Dim Key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
        Dim DigitalProductId As Byte() = Key.GetValue("DigitalProductId", 0)
        Key.Close()
        Return DigitalProductId
    End Function

End Class
