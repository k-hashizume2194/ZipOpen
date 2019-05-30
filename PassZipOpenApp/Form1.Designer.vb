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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DecompressionTargetFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MinifyFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.CompressedFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
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
        Me.DecompressionZipPassTextBox.Size = New System.Drawing.Size(324, 22)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "解凍先フォルダ："
        '
        'DecompressionTargetFolderTextBox
        '
        Me.DecompressionTargetFolderTextBox.Location = New System.Drawing.Point(234, 189)
        Me.DecompressionTargetFolderTextBox.Name = "DecompressionTargetFolderTextBox"
        Me.DecompressionTargetFolderTextBox.Size = New System.Drawing.Size(324, 22)
        Me.DecompressionTargetFolderTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "圧縮するファイルのパス："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "圧縮されたファイルのパス："
        '
        'MinifyFilePathTextBox
        '
        Me.MinifyFilePathTextBox.Location = New System.Drawing.Point(402, 29)
        Me.MinifyFilePathTextBox.Name = "MinifyFilePathTextBox"
        Me.MinifyFilePathTextBox.Size = New System.Drawing.Size(339, 22)
        Me.MinifyFilePathTextBox.TabIndex = 12
        '
        'CompressedFilePathTextBox
        '
        Me.CompressedFilePathTextBox.Location = New System.Drawing.Point(402, 56)
        Me.CompressedFilePathTextBox.Name = "CompressedFilePathTextBox"
        Me.CompressedFilePathTextBox.Size = New System.Drawing.Size(339, 22)
        Me.CompressedFilePathTextBox.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "パスワード："
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(402, 84)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PasswordTextBox.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CompressedFilePathTextBox)
        Me.Controls.Add(Me.MinifyFilePathTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DecompressionTargetFolderTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DecompressionZipPassLabel)
        Me.Controls.Add(Me.DecompressionZipPassTextBox)
        Me.Controls.Add(Me.TryTimeLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TryCountLabel)
        Me.Controls.Add(Me.TryCountTextBox)
        Me.Controls.Add(Me.DecompressionButton)
        Me.Controls.Add(Me.CompressionButton)
        Me.Name = "Form1"
        Me.Text = "暗号Zip解凍アプリ"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents DecompressionTargetFolderTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MinifyFilePathTextBox As TextBox
    Friend WithEvents CompressedFilePathTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordTextBox As TextBox
End Class
