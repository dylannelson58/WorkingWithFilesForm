Public Class WorkingWithFilesForm
    Private Sub WorkingWithFilesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileDemoRead()
    End Sub

    'Private Sub FileDemo()
    '    FileOpen(1, "FileDemo.txt", OpenMode.Append)

    '    WriteLine(1, "Hello")

    '    FileClose(1)

    'End Sub

    Sub FileDemoRead()
        Try
            FileOpen(1, "someTextFile.txt", OpenMode.Input)

        Catch ex As Exception

        End Try

        FileClose(1)
    End Sub
End Class
