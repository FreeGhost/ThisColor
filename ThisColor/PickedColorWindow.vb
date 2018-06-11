Public Class PickedColorWindow

    Dim ShapeContainer1 As Object

    Private Sub GetTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetTimer.Tick
        GetTimer.Stop()
        Show()
    End Sub

    Private Sub CopyBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyBUT.Click
        Clipboard.SetText(HexTextBox.Text)
    End Sub
End Class