<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CompressionButton = New System.Windows.Forms.Button()
        Me.DecompressionButton = New System.Windows.Forms.Button()
        Me.TryCountTextBox = New System.Windows.Forms.TextBox()
        Me.TryCountLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TryTimeLabel = New System.Windows.Forms.Label()
        Me.DecompressionZipPassTextBox = New System.Windows.Forms.TextBox()
        Me.DecompressionZipPassLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CompressionButton
        '
        Me.CompressionButton.Location = New System.Drawing.Point(91, 43)
        Me.CompressionButton.Name = "CompressionButton"
        Me.CompressionButton.Size = New System.Drawing.Size(75, 31)
        Me.CompressionButton.TabIndex = 0
        Me.CompressionButton.Text = "圧縮"
        Me.CompressionButton.UseVisualStyleBackColor = True
        '
        'DecompressionButton
        '
        Me.DecompressionButton.Location = New System.Drawing.Point(91, 107)
        Me.DecompressionButton.Name = "DecompressionButton"
        Me.DecompressionButton.Size = New System.Drawing.Size(75, 31)
        Me.DecompressionButton.TabIndex = 1
        Me.DecompressionButton.Text = "解凍"
        Me.DecompressionButton.UseVisualStyleBackColor = True
        '
        'TryCountTextBox
        '
        Me.TryCountTextBox.Location = New System.Drawing.Point(198, 250)
        Me.TryCountTextBox.Name = "TryCountTextBox"
        Me.TryCountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TryCountTextBox.TabIndex = 2
        '
        'TryCountLabel
        '
        Me.TryCountLabel.AutoSize = True
        Me.TryCountLabel.Location = New System.Drawing.Point(121, 250)
        Me.TryCountLabel.Name = "TryCountLabel"
        Me.TryCountLabel.Size = New System.Drawing.Size(45, 15)
        Me.TryCountLabel.TabIndex = 3
        Me.TryCountLabel.Text = "回数："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 291)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TryTimeLabel
        '
        Me.TryTimeLabel.AutoSize = True
        Me.TryTimeLabel.Location = New System.Drawing.Point(124, 291)
        Me.TryTimeLabel.Name = "TryTimeLabel"
        Me.TryTimeLabel.Size = New System.Drawing.Size(45, 15)
        Me.TryTimeLabel.TabIndex = 5
        Me.TryTimeLabel.Text = "時間："
        '
        'DecompressionZipPassTextBox
        '
        Me.DecompressionZipPassTextBox.Location = New System.Drawing.Point(234, 153)
        Me.DecompressionZipPassTextBox.Name = "DecompressionZipPassTextBox"
        Me.DecompressionZipPassTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DecompressionZipPassTextBox.TabIndex = 6
        '
        'DecompressionZipPassLabel
        '
        Me.DecompressionZipPassLabel.AutoSize = True
        Me.DecompressionZipPassLabel.Location = New System.Drawing.Point(88, 156)
        Me.DecompressionZipPassLabel.Name = "DecompressionZipPassLabel"
        Me.DecompressionZipPassLabel.Size = New System.Drawing.Size(122, 15)
        Me.DecompressionZipPassLabel.TabIndex = 7
        Me.DecompressionZipPassLabel.Text = "解凍するZipのパス："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DecompressionZipPassLabel)
        Me.Controls.Add(Me.DecompressionZipPassTextBox)
        Me.Controls.Add(Me.TryTimeLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TryCountLabel)
        Me.Controls.Add(Me.TryCountTextBox)
        Me.Controls.Add(Me.DecompressionButton)
        Me.Controls.Add(Me.CompressionButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CompressionButton As Button
    Friend WithEvents DecompressionButton As Button
    Friend WithEvents TryCountTextBox As TextBox
    Friend WithEvents TryCountLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TryTimeLabel As Label
    Friend WithEvents DecompressionZipPassTextBox As TextBox
    Friend WithEvents DecompressionZipPassLabel As Label
End Class
