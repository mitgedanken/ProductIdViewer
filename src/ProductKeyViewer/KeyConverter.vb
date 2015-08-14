Public Class KeyConverter

    Public Function convert(Key As Byte()) As String
        Dim ProductId As String = Nothing
        Dim isWin8 As Integer
        Dim AllowedChars As String
        Dim i As Integer
        Dim j As Integer
        Dim Current As Integer
        Dim KeyOutput As String
        Dim Last As Integer
        Dim KeyPart As String
        Dim Insert As String
        Const KeyOffset As Integer = 52
        isWin8 = (Key(66) \ 6) And 1
        Key(66) = (Key(66) And &HF7) Or ((isWin8 And 2) * 4)
        i = 24
        AllowedChars = "BCDFGHJKMPQRTVWXY2346789"
        Do
            Current = 0
            j = 14
            Do
                Current = Current * 256
                Current = Key(j + KeyOffset) + Current
                Key(j + KeyOffset) = (Current \ 24)
                Current = Current Mod 24
                j = j - 1
            Loop While j >= 0
            i = i - 1
            KeyOutput = Mid(AllowedChars, Current + 1, 1) & KeyOutput
            Last = Current
        Loop While i >= 0
        KeyPart = Mid(KeyOutput, 2, Last)
        Insert = "N"
        KeyOutput = Replace(KeyOutput, KeyPart, KeyPart & Insert, 2, 1, 0)
        If Last = 0 Then
            KeyOutput = Insert & KeyOutput
        End If
        ProductId = Mid(KeyOutput, 1, 5) _
            & "-" & Mid(KeyOutput, 6, 5) _
            & "-" & Mid(KeyOutput, 11, 5) _
            & "-" & Mid(KeyOutput, 16, 5) _
            & "-" & Mid(KeyOutput, 21, 5)
        Return ProductId
    End Function

End Class