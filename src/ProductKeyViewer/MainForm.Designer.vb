<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.MessageCopiedStatus = New System.Windows.Forms.TextBox()
        Me.ProductKey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'MessageCopiedStatus
        '
        Me.MessageCopiedStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.MessageCopiedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageCopiedStatus.CausesValidation = False
        resources.ApplyResources(Me.MessageCopiedStatus, "MessageCopiedStatus")
        Me.MessageCopiedStatus.ForeColor = System.Drawing.Color.Black
        Me.MessageCopiedStatus.Name = "MessageCopiedStatus"
        Me.MessageCopiedStatus.ReadOnly = True
        '
        'ProductKey
        '
        Me.ProductKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductKey.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.ProductKey, "ProductKey")
        Me.ProductKey.Name = "ProductKey"
        Me.ProductKey.ReadOnly = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.CloseBtn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseBtn
        Me.CausesValidation = False
        Me.Controls.Add(Me.ProductKey)
        Me.Controls.Add(Me.MessageCopiedStatus)
        Me.Controls.Add(Me.CloseBtn)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseBtn As Button
    Friend WithEvents MessageCopiedStatus As TextBox
    Friend WithEvents ProductKey As TextBox
End Class
