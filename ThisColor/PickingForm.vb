Imports System.Threading

Public Class PickingForm
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Dim PickedColor As Color
    Dim ColorPicked As String = "No"
    Dim Value As String = Application.ExecutablePath
    Dim KeyName As String = "Software\Microsoft\Windows\CurrentVersion\Run"
    Dim MutexOBJ As Mutex, MutexKey As String = "EnCt23f6fd82ba32802c699a768c90794fe67be172d553f6fd82ba32802c699a768c9lajy7D+9YAI9uw3SF1odCeqiQVznzlTiVJ1nIwEmS"

    Private Sub CheckTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles CheckTimer.Tick
        MutexOBJ = New Mutex(False, MutexKey)
        If MutexOBJ.WaitOne(0, False) = False Then
            MutexOBJ.Close()
            MutexOBJ = Nothing
            NotifyIcon.Visible = False
            MsgBox("Could not launch MyColorPicker" & vbCrLf & "Only one instance of MyColorPicker can be run at a time.", MsgBoxStyle.Critical, "MyColorPicker - ERROR")
            Close()
        Else

        End If
        If GetAsyncKeyState(Keys.F6) Then
            Opacity = 1
            Visible = True
            PickColorTimer.Start()
            PickedColorWindow.Close()
        ElseIf GetAsyncKeyState(Keys.F7) Then
            Visible = False
        ElseIf GetAsyncKeyState(Keys.F8) Then
            If Visible = True Then
                Visible = False
                PickedColorWindow.GetTimer.Start()
                PickedColorWindow.HexTextBox.Text = "#" & PickedColor.Name.Substring(2)
                PickedColorWindow.RedTextBox.Text = PickedColor.R
                PickedColorWindow.GreenTextBox.Text = PickedColor.G
                PickedColorWindow.BlueTextBox.Text = PickedColor.B
            End If
        ElseIf GetAsyncKeyState(Keys.F12) Then
            Close()
            AboutWindow.Close()
        End If
    End Sub

    Private Sub PickColorTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles PickColorTimer.Tick
        PickColorTimer.Stop()
        If MousePosition.X > My.Computer.Screen.Bounds.Width - 100 Then
            Left = MousePosition.X - 145
        ElseIf MousePosition.X < My.Computer.Screen.Bounds.Width - 100 Then
            Left = MousePosition.X + 5
        End If
        If MousePosition.Y > My.Computer.Screen.Bounds.Height - 100 Then
            Top = MousePosition.Y - 145
        ElseIf MousePosition.Y < My.Computer.Screen.Bounds.Height - 100 Then
            Top = MousePosition.Y + 5
        End If
        Dim BMP As New Bitmap(1, 1)
        Dim GFX As Graphics = Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Point(MousePosition.X, MousePosition.Y), New Point(0, 0), BMP.Size)
        PickedColor = BMP.GetPixel(0, 0)
        PickedColorLabel.BackColor = PickedColor
        If Visible = True Then
            PickColorTimer.Start()
        End If
    End Sub

    Private Sub StartPickingF5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles StartPickingF5ToolStripMenuItem.Click
        Opacity = 1
        Visible = True
        PickColorTimer.Start()
        PickedColorWindow.Close()
    End Sub

    Private Sub StopPickingF6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles StopPickingF6ToolStripMenuItem.Click
        Visible = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutWindow.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        AboutWindow.Close()
    End Sub

    Private Sub PickingForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue(Application.ProductName, Value)
        HideTimer.Start()
    End Sub

    Private Sub HideTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles HideTimer.Tick
        HideTimer.Stop()
        Visible = False
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Start tracking : F6" & vbLf & "Stop tracking : F7" & vbLf & "Pick the color : F8" & vbLf & "Close the program : F12", MsgBoxStyle.Information, "MyColorPicker")
    End Sub
End Class