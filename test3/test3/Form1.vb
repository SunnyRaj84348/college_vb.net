Public Class Form1
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        Dim BoldFont As New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.Font = BoldFont
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        Dim ItalicFont As New Font(RichTextBox1.Font, FontStyle.Italic)
        RichTextBox1.Font = ItalicFont
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        Dim UnderlineFont As New Font(RichTextBox1.Font, FontStyle.Underline)
        RichTextBox1.Font = UnderlineFont
    End Sub

    Private Sub StrikeoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikeoutToolStripMenuItem.Click
        Dim StrikeoutFont As New Font(RichTextBox1.Font, FontStyle.Strikeout)
        RichTextBox1.Font = StrikeoutFont
    End Sub
End Class
