<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickedColorWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickedColorWindow))
        Me.HexLabel = New System.Windows.Forms.Label()
        Me.HexTextBox = New System.Windows.Forms.TextBox()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.GetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CopyBUT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HexLabel
        '
        Me.HexLabel.AutoSize = True
        Me.HexLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexLabel.Location = New System.Drawing.Point(12, 8)
        Me.HexLabel.Name = "HexLabel"
        Me.HexLabel.Size = New System.Drawing.Size(44, 18)
        Me.HexLabel.TabIndex = 0
        Me.HexLabel.Text = "Hex :"
        '
        'HexTextBox
        '
        Me.HexTextBox.Location = New System.Drawing.Point(12, 29)
        Me.HexTextBox.Name = "HexTextBox"
        Me.HexTextBox.ReadOnly = True
        Me.HexTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HexTextBox.TabIndex = 1
        Me.HexTextBox.TabStop = False
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(209, 11)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.ReadOnly = True
        Me.RedTextBox.Size = New System.Drawing.Size(50, 20)
        Me.RedTextBox.TabIndex = 7
        Me.RedTextBox.TabStop = False
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedLabel.Location = New System.Drawing.Point(150, 9)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(43, 18)
        Me.RedLabel.TabIndex = 6
        Me.RedLabel.Text = "Red :"
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(209, 38)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.ReadOnly = True
        Me.GreenTextBox.Size = New System.Drawing.Size(50, 20)
        Me.GreenTextBox.TabIndex = 9
        Me.GreenTextBox.TabStop = False
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenLabel.Location = New System.Drawing.Point(150, 36)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(57, 18)
        Me.GreenLabel.TabIndex = 8
        Me.GreenLabel.Text = "Green :"
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(209, 64)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.ReadOnly = True
        Me.BlueTextBox.Size = New System.Drawing.Size(50, 20)
        Me.BlueTextBox.TabIndex = 11
        Me.BlueTextBox.TabStop = False
        '
        'BlueLabel
        '
        Me.BlueLabel.AutoSize = True
        Me.BlueLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueLabel.Location = New System.Drawing.Point(150, 63)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(45, 18)
        Me.BlueLabel.TabIndex = 10
        Me.BlueLabel.Text = "Blue :"
        '
        'GetTimer
        '
        Me.GetTimer.Enabled = True
        '
        'CopyBUT
        '
        Me.CopyBUT.Location = New System.Drawing.Point(12, 56)
        Me.CopyBUT.Name = "CopyBUT"
        Me.CopyBUT.Size = New System.Drawing.Size(100, 23)
        Me.CopyBUT.TabIndex = 13
        Me.CopyBUT.Text = "Copy"
        Me.CopyBUT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(130, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(3, 76)
        Me.Label1.TabIndex = 14
        '
        'PickedColorWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(268, 92)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CopyBUT)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.HexTextBox)
        Me.Controls.Add(Me.HexLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PickedColorWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThisColor"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HexLabel As System.Windows.Forms.Label
    Friend WithEvents HexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RedLabel As System.Windows.Forms.Label
    Friend WithEvents GreenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GreenLabel As System.Windows.Forms.Label
    Friend WithEvents BlueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BlueLabel As System.Windows.Forms.Label
    Friend WithEvents GetTimer As System.Windows.Forms.Timer
    Friend WithEvents CopyBUT As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
End Class
