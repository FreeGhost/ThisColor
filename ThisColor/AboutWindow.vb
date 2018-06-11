Public Class AboutWindow

    Private Sub TermsAndConditionsLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TermsAndConditionsLabel.Click
        Process.Start("https://mousa.alfhaily.me/Apps/LICENSE")
    End Sub

    Private Sub YouTubeLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YouTubeLabel.Click
        Process.Start("https://www.youtube.com/channel/UCWeRjXP-I7OmAwKKF8xHCFQ")
    End Sub

    Private Sub TwitterLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TwitterLabel.Click
        Process.Start("https://twitter.com/FreeGh0o0st")
    End Sub

    Private Sub WebsiteLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WebsiteLabel.Click
        Process.Start("https://mousa.alfhaily.me")
    End Sub

    Private Sub GetToolKifyBUT_Click(sender As Object, e As EventArgs) Handles GetToolKifyBUT.Click
        Process.Start("https://mousa.alfhaily.me/Apps/Free/ToolKify")
    End Sub
End Class