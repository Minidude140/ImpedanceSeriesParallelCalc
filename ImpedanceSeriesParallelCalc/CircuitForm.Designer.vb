<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircuitForm
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
        Me.C1TextBox = New System.Windows.Forms.TextBox()
        Me.R1TextBox = New System.Windows.Forms.TextBox()
        Me.L1TextBox = New System.Windows.Forms.TextBox()
        Me.C2TextBox = New System.Windows.Forms.TextBox()
        Me.R2TextBox = New System.Windows.Forms.TextBox()
        Me.VgenTextBox = New System.Windows.Forms.TextBox()
        Me.FrequencyTextBox = New System.Windows.Forms.TextBox()
        Me.RwTextBox = New System.Windows.Forms.TextBox()
        Me.CircuitPictureBox = New System.Windows.Forms.PictureBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.RestoreDefaultsButton = New System.Windows.Forms.Button()
        Me.HzLabel = New System.Windows.Forms.Label()
        Me.VoltageLabel = New System.Windows.Forms.Label()
        Me.C1UnitsLabel = New System.Windows.Forms.Label()
        Me.R1UnitsLabel = New System.Windows.Forms.Label()
        Me.L1UnitsLabel = New System.Windows.Forms.Label()
        Me.RWUnitsLabel = New System.Windows.Forms.Label()
        Me.C2UnitsLabel = New System.Windows.Forms.Label()
        Me.R2UnitsLabel = New System.Windows.Forms.Label()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(331, 122)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(66, 22)
        Me.C1TextBox.TabIndex = 3
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(480, 122)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(66, 22)
        Me.R1TextBox.TabIndex = 4
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(771, 216)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(66, 22)
        Me.L1TextBox.TabIndex = 5
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(1046, 174)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(66, 22)
        Me.C2TextBox.TabIndex = 7
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(1046, 304)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(66, 22)
        Me.R2TextBox.TabIndex = 8
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(45, 188)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(66, 22)
        Me.VgenTextBox.TabIndex = 1
        '
        'FrequencyTextBox
        '
        Me.FrequencyTextBox.Location = New System.Drawing.Point(45, 269)
        Me.FrequencyTextBox.Name = "FrequencyTextBox"
        Me.FrequencyTextBox.Size = New System.Drawing.Size(66, 22)
        Me.FrequencyTextBox.TabIndex = 2
        '
        'RwTextBox
        '
        Me.RwTextBox.Location = New System.Drawing.Point(771, 272)
        Me.RwTextBox.Name = "RwTextBox"
        Me.RwTextBox.Size = New System.Drawing.Size(66, 22)
        Me.RwTextBox.TabIndex = 6
        '
        'CircuitPictureBox
        '
        Me.CircuitPictureBox.BackgroundImage = Global.ImpedanceSeriesParallelCalc.My.Resources.Resources.CircuitImage1
        Me.CircuitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CircuitPictureBox.Location = New System.Drawing.Point(12, 28)
        Me.CircuitPictureBox.Name = "CircuitPictureBox"
        Me.CircuitPictureBox.Size = New System.Drawing.Size(1204, 461)
        Me.CircuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CircuitPictureBox.TabIndex = 0
        Me.CircuitPictureBox.TabStop = False
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(1097, 517)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(144, 56)
        Me.QuitButton.TabIndex = 9
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(12, 508)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(144, 65)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "Calculate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Values"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'RestoreDefaultsButton
        '
        Me.RestoreDefaultsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreDefaultsButton.Location = New System.Drawing.Point(12, 579)
        Me.RestoreDefaultsButton.Name = "RestoreDefaultsButton"
        Me.RestoreDefaultsButton.Size = New System.Drawing.Size(144, 65)
        Me.RestoreDefaultsButton.TabIndex = 11
        Me.RestoreDefaultsButton.Text = "Restore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defaults"
        Me.RestoreDefaultsButton.UseVisualStyleBackColor = True
        '
        'HzLabel
        '
        Me.HzLabel.AutoSize = True
        Me.HzLabel.Location = New System.Drawing.Point(117, 272)
        Me.HzLabel.Name = "HzLabel"
        Me.HzLabel.Size = New System.Drawing.Size(25, 17)
        Me.HzLabel.TabIndex = 12
        Me.HzLabel.Text = "Hz"
        '
        'VoltageLabel
        '
        Me.VoltageLabel.AutoSize = True
        Me.VoltageLabel.Location = New System.Drawing.Point(117, 188)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(33, 17)
        Me.VoltageLabel.TabIndex = 13
        Me.VoltageLabel.Text = "Vpp"
        '
        'C1UnitsLabel
        '
        Me.C1UnitsLabel.AutoSize = True
        Me.C1UnitsLabel.Location = New System.Drawing.Point(403, 127)
        Me.C1UnitsLabel.Name = "C1UnitsLabel"
        Me.C1UnitsLabel.Size = New System.Drawing.Size(16, 17)
        Me.C1UnitsLabel.TabIndex = 14
        Me.C1UnitsLabel.Text = "F"
        '
        'R1UnitsLabel
        '
        Me.R1UnitsLabel.AutoSize = True
        Me.R1UnitsLabel.Location = New System.Drawing.Point(552, 127)
        Me.R1UnitsLabel.Name = "R1UnitsLabel"
        Me.R1UnitsLabel.Size = New System.Drawing.Size(19, 17)
        Me.R1UnitsLabel.TabIndex = 15
        Me.R1UnitsLabel.Text = "Ω"
        '
        'L1UnitsLabel
        '
        Me.L1UnitsLabel.AutoSize = True
        Me.L1UnitsLabel.Location = New System.Drawing.Point(843, 219)
        Me.L1UnitsLabel.Name = "L1UnitsLabel"
        Me.L1UnitsLabel.Size = New System.Drawing.Size(18, 17)
        Me.L1UnitsLabel.TabIndex = 16
        Me.L1UnitsLabel.Text = "H"
        '
        'RWUnitsLabel
        '
        Me.RWUnitsLabel.AutoSize = True
        Me.RWUnitsLabel.Location = New System.Drawing.Point(843, 275)
        Me.RWUnitsLabel.Name = "RWUnitsLabel"
        Me.RWUnitsLabel.Size = New System.Drawing.Size(19, 17)
        Me.RWUnitsLabel.TabIndex = 17
        Me.RWUnitsLabel.Text = "Ω"
        '
        'C2UnitsLabel
        '
        Me.C2UnitsLabel.AutoSize = True
        Me.C2UnitsLabel.Location = New System.Drawing.Point(1118, 177)
        Me.C2UnitsLabel.Name = "C2UnitsLabel"
        Me.C2UnitsLabel.Size = New System.Drawing.Size(16, 17)
        Me.C2UnitsLabel.TabIndex = 18
        Me.C2UnitsLabel.Text = "F"
        '
        'R2UnitsLabel
        '
        Me.R2UnitsLabel.AutoSize = True
        Me.R2UnitsLabel.Location = New System.Drawing.Point(1118, 307)
        Me.R2UnitsLabel.Name = "R2UnitsLabel"
        Me.R2UnitsLabel.Size = New System.Drawing.Size(19, 17)
        Me.R2UnitsLabel.TabIndex = 19
        Me.R2UnitsLabel.Text = "Ω"
        '
        'CircuitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 652)
        Me.Controls.Add(Me.R2UnitsLabel)
        Me.Controls.Add(Me.C2UnitsLabel)
        Me.Controls.Add(Me.RWUnitsLabel)
        Me.Controls.Add(Me.L1UnitsLabel)
        Me.Controls.Add(Me.R1UnitsLabel)
        Me.Controls.Add(Me.C1UnitsLabel)
        Me.Controls.Add(Me.VoltageLabel)
        Me.Controls.Add(Me.HzLabel)
        Me.Controls.Add(Me.RestoreDefaultsButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.RwTextBox)
        Me.Controls.Add(Me.FrequencyTextBox)
        Me.Controls.Add(Me.VgenTextBox)
        Me.Controls.Add(Me.R2TextBox)
        Me.Controls.Add(Me.C2TextBox)
        Me.Controls.Add(Me.L1TextBox)
        Me.Controls.Add(Me.R1TextBox)
        Me.Controls.Add(Me.C1TextBox)
        Me.Controls.Add(Me.CircuitPictureBox)
        Me.MinimumSize = New System.Drawing.Size(1275, 47)
        Me.Name = "CircuitForm"
        Me.Text = "Circuit Calculator"
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CircuitPictureBox As PictureBox
    Friend WithEvents C1TextBox As TextBox
    Friend WithEvents R1TextBox As TextBox
    Friend WithEvents L1TextBox As TextBox
    Friend WithEvents C2TextBox As TextBox
    Friend WithEvents R2TextBox As TextBox
    Friend WithEvents VgenTextBox As TextBox
    Friend WithEvents FrequencyTextBox As TextBox
    Friend WithEvents RwTextBox As TextBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents RestoreDefaultsButton As Button
    Friend WithEvents HzLabel As Label
    Friend WithEvents VoltageLabel As Label
    Friend WithEvents C1UnitsLabel As Label
    Friend WithEvents R1UnitsLabel As Label
    Friend WithEvents L1UnitsLabel As Label
    Friend WithEvents RWUnitsLabel As Label
    Friend WithEvents C2UnitsLabel As Label
    Friend WithEvents R2UnitsLabel As Label
End Class
