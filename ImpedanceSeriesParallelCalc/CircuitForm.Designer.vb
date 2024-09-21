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
        Me.components = New System.ComponentModel.Container()
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
        Me.Branch1Label = New System.Windows.Forms.Label()
        Me.Branch2Label = New System.Windows.Forms.Label()
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.ExportResultsButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(248, 99)
        Me.C1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(50, 20)
        Me.C1TextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.C1TextBox, "Enter Capacitance Here")
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(360, 99)
        Me.R1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(50, 20)
        Me.R1TextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.R1TextBox, "Enter Resistance Here")
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(578, 176)
        Me.L1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(50, 20)
        Me.L1TextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.L1TextBox, "Enter Inductance Here")
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(784, 141)
        Me.C2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(50, 20)
        Me.C2TextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.C2TextBox, "Enter Capacitance Here")
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(784, 247)
        Me.R2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(50, 20)
        Me.R2TextBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.R2TextBox, "Enter Resistance Here")
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(34, 153)
        Me.VgenTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(50, 20)
        Me.VgenTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.VgenTextBox, "Enter Volage Here")
        '
        'FrequencyTextBox
        '
        Me.FrequencyTextBox.Location = New System.Drawing.Point(34, 219)
        Me.FrequencyTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FrequencyTextBox.Name = "FrequencyTextBox"
        Me.FrequencyTextBox.Size = New System.Drawing.Size(50, 20)
        Me.FrequencyTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.FrequencyTextBox, "Enter Frequnecy Here")
        '
        'RwTextBox
        '
        Me.RwTextBox.Location = New System.Drawing.Point(578, 221)
        Me.RwTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RwTextBox.Name = "RwTextBox"
        Me.RwTextBox.Size = New System.Drawing.Size(50, 20)
        Me.RwTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.RwTextBox, "Enter Winding Resistance Here")
        '
        'CircuitPictureBox
        '
        Me.CircuitPictureBox.BackgroundImage = Global.ImpedanceSeriesParallelCalc.My.Resources.Resources.CircuitImage1
        Me.CircuitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CircuitPictureBox.Location = New System.Drawing.Point(9, 23)
        Me.CircuitPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CircuitPictureBox.Name = "CircuitPictureBox"
        Me.CircuitPictureBox.Size = New System.Drawing.Size(903, 375)
        Me.CircuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CircuitPictureBox.TabIndex = 0
        Me.CircuitPictureBox.TabStop = False
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(815, 466)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(108, 53)
        Me.QuitButton.TabIndex = 12
        Me.QuitButton.Text = "Quit"
        Me.ToolTip1.SetToolTip(Me.QuitButton, "Exit the Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(285, 402)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(343, 53)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "Calculate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Values"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate Current Values and Update Results")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'RestoreDefaultsButton
        '
        Me.RestoreDefaultsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestoreDefaultsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreDefaultsButton.Location = New System.Drawing.Point(404, 459)
        Me.RestoreDefaultsButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RestoreDefaultsButton.Name = "RestoreDefaultsButton"
        Me.RestoreDefaultsButton.Size = New System.Drawing.Size(108, 53)
        Me.RestoreDefaultsButton.TabIndex = 10
        Me.RestoreDefaultsButton.Text = "Restore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defaults"
        Me.ToolTip1.SetToolTip(Me.RestoreDefaultsButton, "Restore Values To Default and Update Results")
        Me.RestoreDefaultsButton.UseVisualStyleBackColor = True
        '
        'HzLabel
        '
        Me.HzLabel.AutoSize = True
        Me.HzLabel.Location = New System.Drawing.Point(88, 221)
        Me.HzLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HzLabel.Name = "HzLabel"
        Me.HzLabel.Size = New System.Drawing.Size(20, 13)
        Me.HzLabel.TabIndex = 12
        Me.HzLabel.Text = "Hz"
        '
        'VoltageLabel
        '
        Me.VoltageLabel.AutoSize = True
        Me.VoltageLabel.Location = New System.Drawing.Point(88, 153)
        Me.VoltageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(26, 13)
        Me.VoltageLabel.TabIndex = 13
        Me.VoltageLabel.Text = "Vpp"
        '
        'C1UnitsLabel
        '
        Me.C1UnitsLabel.AutoSize = True
        Me.C1UnitsLabel.Location = New System.Drawing.Point(302, 103)
        Me.C1UnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C1UnitsLabel.Name = "C1UnitsLabel"
        Me.C1UnitsLabel.Size = New System.Drawing.Size(13, 13)
        Me.C1UnitsLabel.TabIndex = 14
        Me.C1UnitsLabel.Text = "F"
        '
        'R1UnitsLabel
        '
        Me.R1UnitsLabel.AutoSize = True
        Me.R1UnitsLabel.Location = New System.Drawing.Point(414, 103)
        Me.R1UnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R1UnitsLabel.Name = "R1UnitsLabel"
        Me.R1UnitsLabel.Size = New System.Drawing.Size(16, 13)
        Me.R1UnitsLabel.TabIndex = 15
        Me.R1UnitsLabel.Text = "Ω"
        '
        'L1UnitsLabel
        '
        Me.L1UnitsLabel.AutoSize = True
        Me.L1UnitsLabel.Location = New System.Drawing.Point(632, 178)
        Me.L1UnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L1UnitsLabel.Name = "L1UnitsLabel"
        Me.L1UnitsLabel.Size = New System.Drawing.Size(15, 13)
        Me.L1UnitsLabel.TabIndex = 16
        Me.L1UnitsLabel.Text = "H"
        '
        'RWUnitsLabel
        '
        Me.RWUnitsLabel.AutoSize = True
        Me.RWUnitsLabel.Location = New System.Drawing.Point(632, 223)
        Me.RWUnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RWUnitsLabel.Name = "RWUnitsLabel"
        Me.RWUnitsLabel.Size = New System.Drawing.Size(16, 13)
        Me.RWUnitsLabel.TabIndex = 17
        Me.RWUnitsLabel.Text = "Ω"
        '
        'C2UnitsLabel
        '
        Me.C2UnitsLabel.AutoSize = True
        Me.C2UnitsLabel.Location = New System.Drawing.Point(838, 144)
        Me.C2UnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C2UnitsLabel.Name = "C2UnitsLabel"
        Me.C2UnitsLabel.Size = New System.Drawing.Size(13, 13)
        Me.C2UnitsLabel.TabIndex = 18
        Me.C2UnitsLabel.Text = "F"
        '
        'R2UnitsLabel
        '
        Me.R2UnitsLabel.AutoSize = True
        Me.R2UnitsLabel.Location = New System.Drawing.Point(838, 249)
        Me.R2UnitsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R2UnitsLabel.Name = "R2UnitsLabel"
        Me.R2UnitsLabel.Size = New System.Drawing.Size(16, 13)
        Me.R2UnitsLabel.TabIndex = 19
        Me.R2UnitsLabel.Text = "Ω"
        '
        'Branch1Label
        '
        Me.Branch1Label.AutoSize = True
        Me.Branch1Label.Location = New System.Drawing.Point(730, 50)
        Me.Branch1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Branch1Label.Name = "Branch1Label"
        Me.Branch1Label.Size = New System.Drawing.Size(50, 13)
        Me.Branch1Label.TabIndex = 20
        Me.Branch1Label.Text = "Branch 1"
        '
        'Branch2Label
        '
        Me.Branch2Label.AutoSize = True
        Me.Branch2Label.Location = New System.Drawing.Point(521, 50)
        Me.Branch2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Branch2Label.Name = "Branch2Label"
        Me.Branch2Label.Size = New System.Drawing.Size(50, 13)
        Me.Branch2Label.TabIndex = 21
        Me.Branch2Label.Text = "Branch 2"
        '
        'OutputListBox
        '
        Me.OutputListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(928, 23)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(298, 498)
        Me.OutputListBox.TabIndex = 22
        '
        'ExportResultsButton
        '
        Me.ExportResultsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportResultsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportResultsButton.Location = New System.Drawing.Point(815, 409)
        Me.ExportResultsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExportResultsButton.Name = "ExportResultsButton"
        Me.ExportResultsButton.Size = New System.Drawing.Size(108, 53)
        Me.ExportResultsButton.TabIndex = 11
        Me.ExportResultsButton.Text = "Export" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Results"
        Me.ToolTip1.SetToolTip(Me.ExportResultsButton, "Export Results to Text File")
        Me.ExportResultsButton.UseVisualStyleBackColor = True
        '
        'CircuitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 530)
        Me.Controls.Add(Me.ExportResultsButton)
        Me.Controls.Add(Me.OutputListBox)
        Me.Controls.Add(Me.Branch2Label)
        Me.Controls.Add(Me.Branch1Label)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(1254, 569)
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
    Friend WithEvents Branch1Label As Label
    Friend WithEvents Branch2Label As Label
    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents ExportResultsButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
