<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickingForm))
        Me.CheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PickColorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PickedColorLabel = New System.Windows.Forms.Label()
        Me.StartPickingF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopPickingF6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PickTheColorF8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckTimer
        '
        Me.CheckTimer.Enabled = True
        '
        'PickColorTimer
        '
        Me.PickColorTimer.Interval = 1
        '
        'PickedColorLabel
        '
        Me.PickedColorLabel.BackColor = System.Drawing.Color.Black
        Me.PickedColorLabel.Location = New System.Drawing.Point(5, 5)
        Me.PickedColorLabel.Name = "PickedColorLabel"
        Me.PickedColorLabel.Size = New System.Drawing.Size(130, 130)
        Me.PickedColorLabel.TabIndex = 0
        '
        'StartPickingF5ToolStripMenuItem
        '
        Me.StartPickingF5ToolStripMenuItem.Name = "StartPickingF5ToolStripMenuItem"
        Me.StartPickingF5ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartPickingF5ToolStripMenuItem.Text = "Start tracking (F6)"
        '
        'StopPickingF6ToolStripMenuItem
        '
        Me.StopPickingF6ToolStripMenuItem.Name = "StopPickingF6ToolStripMenuItem"
        Me.StopPickingF6ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StopPickingF6ToolStripMenuItem.Text = "Stop tracking (F7)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "ThisColor"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartPickingF5ToolStripMenuItem, Me.StopPickingF6ToolStripMenuItem, Me.PickTheColorF8ToolStripMenuItem, Me.ToolStripSeparator1, Me.HelpToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(181, 170)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'HideTimer
        '
        Me.HideTimer.Interval = 10
        '
        'PickTheColorF8ToolStripMenuItem
        '
        Me.PickTheColorF8ToolStripMenuItem.Enabled = False
        Me.PickTheColorF8ToolStripMenuItem.Name = "PickTheColorF8ToolStripMenuItem"
        Me.PickTheColorF8ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PickTheColorF8ToolStripMenuItem.Text = "Pick the color (F8)"
        '
        'PickingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(140, 140)
        Me.Controls.Add(Me.PickedColorLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PickingForm"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "MyColorPicker"
        Me.TopMost = True
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckTimer As System.Windows.Forms.Timer
    Friend WithEvents PickColorTimer As System.Windows.Forms.Timer
    Friend WithEvents PickedColorLabel As System.Windows.Forms.Label
    Friend WithEvents StartPickingF5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopPickingF6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents HideTimer As System.Windows.Forms.Timer
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PickTheColorF8ToolStripMenuItem As ToolStripMenuItem
End Class
