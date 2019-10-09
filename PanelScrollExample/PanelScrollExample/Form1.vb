Public Class Form1

    Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim hScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaHScrollBar1, True)
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, True)
        Dim r As New Random
        For i As Integer = 0 To 40
            Dim lbl As Label = New Label
            lbl.AutoSize = True
            lbl.Text = "Label " & i.ToString & " ================================================================"
            lbl.Location = New Point(6, i * lbl.Height)
            Panel1.Controls.Add(lbl)
        Next
        vScrollHelper.UpdateScrollBar()
        hScrollHelper.UpdateScrollBar()
    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        If vScrollHelper IsNot Nothing Then vScrollHelper.UpdateScrollBar()
        If hScrollHelper IsNot Nothing Then hScrollHelper.UpdateScrollBar()
    End Sub


End Class
