Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "스마트오피스파일(*.sop) |*.sop|텍스트파일(*.txt) |*.txt|모든파일(*.*)|*.*"
        SaveFileDialog1.ShowDialog()
        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        TextBox1.Text = SaveFileDialog1.FileName
        ProgressBar1.Value = 100
        MsgBox("파일이 저장되었습니다")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "스마트오피스파일(*.sop) |*.sop|텍스트파일(*.txt) |*.txt|모든파일(*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        RichTextBox1.LoadFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SelectionColor = Color.FromArgb(255, 0, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SelectionColor = Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.SelectionColor = Color.FromArgb(0, 0, 255)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.SelectionColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.SelectionColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AboutBox1.Show()
    End Sub
End Class
