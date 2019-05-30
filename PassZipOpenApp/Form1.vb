Public Class Form1
    ''' <summary>
    ''' 圧縮ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CompressionButton_Click(sender As Object, e As EventArgs) Handles CompressionButton.Click
        '作成するZIP書庫のパス 
        'ファイルが既に存在している場合は、上書きされる 
        'Dim zipFileName As String = "C:\test.zip"
        Dim zipFileName As String = Me.CompressedFilePathTextBox.Text
        '圧縮するフォルダのパス 
        Dim sourceDirectory As String = Me.MinifyFilePathTextBox.Text
        'サブディレクトリも圧縮するかどうか 
        Dim recurse As Boolean = True

        'FastZipオブジェクトの作成 
        Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()
        '空のフォルダも書庫に入れるか。デフォルトはfalse 
        fastZip.CreateEmptyDirectories = True
        'ZIP64を使うか。デフォルトはDynamicで、状況に応じてZIP64を使う 
        '（大きなファイルはZIP64でしか圧縮できないが、対応していないアーカイバもある） 
        fastZip.UseZip64 = ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic
        ''パスワードを設定するには次のようにする 
        ''fastZip.Password = "password"
        fastZip.Password = Me.PasswordTextBox.Text

        '圧縮してZIP書庫を作成 
        fastZip.CreateZip(zipFileName, sourceDirectory, recurse, Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' 解凍ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DecompressionButton_Click(sender As Object, e As EventArgs) Handles DecompressionButton.Click
        '展開するZIP書庫のパス 
        Dim zipFileName As String = Me.DecompressionZipPassTextBox.Text
        '展開したファイルを保存するフォルダ（存在しないと作成される） 
        Dim targetDirectory As String = Me.DecompressionTargetFolderTextBox.Text
        '展開するファイルのフィルタ 
        Dim fileFilter As String = ""

        'FastZipオブジェクトの作成 
        Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()
        '属性を復元するか。デフォルトはfalse 
        fastZip.RestoreAttributesOnExtract = True
        'ファイル日時を復元するか。デフォルトはfalse 
        fastZip.RestoreDateTimeOnExtract = True
        '空のフォルダも作成するか。デフォルトはfalse 
        fastZip.CreateEmptyDirectories = True

        'パスワードが設定されているとき 
        'パスワードが設定されている書庫をパスワードを指定せずに展開しようとすると、 
        '　例外ZipExceptionがスローされる 
        'fastZip.Password = "password"
        'fastZip.Password = "1111"

        Dim numbers = Enumerable.Range(0, 10000)

        '0000から9999を順にパスワードに当てはめる
        For Each num As Integer In numbers
            Console.WriteLine(num.ToString("0000"))

            'パスワードに当てはめる
            fastZip.Password = num.ToString("0000")
            Try
                'ZIP書庫を展開する
                fastZip.ExtractZip(zipFileName, targetDirectory, fileFilter)
                MessageBox.Show("ロック解除成功!!!" & vbCrLf &
                                    "パスワードは" & num.ToString("0000") & "です。")
                '成功したらぬける
                Exit Sub
            Catch ex As Exception
                'パスワードの違いは許容
                If ex.Message = "Invalid password" Then
                    Continue For
                End If
                'System.IO.File.Delete(zipFileName)
            Finally
            End Try
        Next
    End Sub

    ''' <summary>
    ''' メインフォーム初期表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '仮の値(記述例)をいれる
        Me.DecompressionZipPassTextBox.Text = "C:\Users\k-has\Desktop\test.zip"
        Me.DecompressionTargetFolderTextBox.Text = "C:\Users\k-has\Desktop\test2"
        Me.MinifyFilePathTextBox.Text = "C:\Users\k-has\Desktop\tenpu"
        Me.CompressedFilePathTextBox.Text = "C:\Users\k-has\Desktop\test.zip"
    End Sub
End Class
