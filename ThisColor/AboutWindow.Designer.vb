<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutWindow))
        Me.YouTubeLabel = New System.Windows.Forms.Label()
        Me.TwitterLabel = New System.Windows.Forms.Label()
        Me.WebsiteLabel = New System.Windows.Forms.Label()
        Me.TermsAndConditionsLabel = New System.Windows.Forms.Label()
        Me.GetToolKifyBUT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YouTubeLabel
        '
        Me.YouTubeLabel.BackColor = System.Drawing.Color.Transparent
        Me.YouTubeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YouTubeLabel.Location = New System.Drawing.Point(41, 256)
        Me.YouTubeLabel.Name = "YouTubeLabel"
        Me.YouTubeLabel.Size = New System.Drawing.Size(61, 60)
        Me.YouTubeLabel.TabIndex = 0
        '
        'TwitterLabel
        '
        Me.TwitterLabel.BackColor = System.Drawing.Color.Transparent
        Me.TwitterLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TwitterLabel.Location = New System.Drawing.Point(251, 256)
        Me.TwitterLabel.Name = "TwitterLabel"
        Me.TwitterLabel.Size = New System.Drawing.Size(61, 60)
        Me.TwitterLabel.TabIndex = 1
        '
        'WebsiteLabel
        '
        Me.WebsiteLabel.BackColor = System.Drawing.Color.Transparent
        Me.WebsiteLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WebsiteLabel.Location = New System.Drawing.Point(118, 256)
        Me.WebsiteLabel.Name = "WebsiteLabel"
        Me.WebsiteLabel.Size = New System.Drawing.Size(114, 60)
        Me.WebsiteLabel.TabIndex = 2
        '
        'TermsAndConditionsLabel
        '
        Me.TermsAndConditionsLabel.BackColor = System.Drawing.Color.Transparent
        Me.TermsAndConditionsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TermsAndConditionsLabel.Location = New System.Drawing.Point(242, 196)
        Me.TermsAndConditionsLabel.Name = "TermsAndConditionsLabel"
        Me.TermsAndConditionsLabel.Size = New System.Drawing.Size(114, 10)
        Me.TermsAndConditionsLabel.TabIndex = 3
        '
        'GetToolKifyBUT
        '
        Me.GetToolKifyBUT.BackColor = System.Drawing.Color.Transparent
        Me.GetToolKifyBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetToolKifyBUT.Location = New System.Drawing.Point(399, 256)
        Me.GetToolKifyBUT.Name = "GetToolKifyBUT"
        Me.GetToolKifyBUT.Size = New System.Drawing.Size(162, 60)
        Me.GetToolKifyBUT.TabIndex = 4
        '
        'AboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ThisColor.My.Resources.Resources.AboutWindowBG
        Me.ClientSize = New System.Drawing.Size(584, 331)
        Me.Controls.Add(Me.GetToolKifyBUT)
        Me.Controls.Add(Me.TermsAndConditionsLabel)
        Me.Controls.Add(Me.WebsiteLabel)
        Me.Controls.Add(Me.TwitterLabel)
        Me.Controls.Add(Me.YouTubeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThisColor"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YouTubeLabel As System.Windows.Forms.Label
    Friend WithEvents TwitterLabel As System.Windows.Forms.Label
    Friend WithEvents WebsiteLabel As System.Windows.Forms.Label
    Friend WithEvents TermsAndConditionsLabel As System.Windows.Forms.Label
    Friend WithEvents GetToolKifyBUT As Label
End Class
