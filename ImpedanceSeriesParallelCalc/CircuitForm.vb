'Zachary Christensen
'Spring 2024; 09/15/24
'Series Parallel Impedance Calculator
'https://github.com/Minidude140/ImpedanceSeriesParallelCalc

'TOdO
'[*]Load Circuit Values into array
'[*]User input validation
'[*]Load Default Circuit Values
'[*]Calculate Impedance Totals
'[1/2]Calculate Voltages and Currents
'[]Create and populate list box with results
'[]Output File with results;  Use print function

Option Explicit On
Option Strict On
Public Class CircuitForm
    Dim pi As Double = System.Math.PI
    Dim circuitValues(6, 1) As Double
    '          0:    1:
    '   0:  | Vgen |  F   |    
    '   1:  | R1   |  x   |
    '   2:  | C1   | XC1  |
    '   3:  | L1   | XL1  |
    '   4:  | RW   |  x   |
    '   5:  | C2   | XC2  |
    '   6:  | R2   |  x   |
    Dim polRectValues(2, 3) As Double
    '           0:     1:       2:       3:
    '   0:  |  XC1  | XC1θ  |  XC1R  |  XC1J    
    '   1:  |  XL1  | XL1θ  |  XL1R  |  XL1J       ***XL values include R winding(ZBR2)***
    '   2:  |  XC2  | XC2θ  |  XC2R  |  XC2J
    Dim impedanceValues(3, 3) As Double
    '           0:        1:         2:         3:
    '   0:  |  ZBR1    | ZBR1θ   |  ZBR1R   |  ZBR1J    
    '   1:  |  ZBR1/2  | ZBR1/2θ |  ZBR1/2R |  ZBR1/2J   ***ZBR2 = PolRectValues(1,x)****
    '   2:  |  ZC1R1   | ZC1R1θ  |  ZC1R1R  |  ZC1R1J
    '   3:  |  ZTOT    | ZTOTθ   |  ZTOTR   |  ZTOTj

    Dim voltagesAndCurrents(5, 1) As Double
    '          0:         1:         2:     3:
    '   0:  | Itot   |   Itotθ    |   x  |   x
    '   1:  | VR1    |   VR1θ     |  VC1 |  VC1θ
    '   2:  | VBR1/2 |   VBR1/2θ  |   x  |   x
    '   3:  | IBR1   |   IBR1θ    | IBR2 |  IBR2θ
    '   4:  | VL1    |   VL1θ     |   x  |   x
    '   5:  | VC2    |   VC2θ     |  VR2 |  VR2θ

    'Custom Methods
    ''' <summary>
    ''' Populates and Calculates Input Circuit Values
    ''' </summary>
    Sub LoadCircuitValues()
        'Populate Vgen
        circuitValues(0, 0) = CDbl(VgenTextBox.Text)
        'Populate Frequency
        circuitValues(0, 1) = CDbl(FrequencyTextBox.Text)
        'Populate R1 Value
        circuitValues(1, 0) = CDbl(R1TextBox.Text)
        'Populate C1 Value
        circuitValues(2, 0) = CDbl(C1TextBox.Text)
        'Calculate and Populate XC1
        circuitValues(2, 1) = CalculateXC(circuitValues(0, 1), circuitValues(2, 0))
        polRectValues(0, 0) = circuitValues(2, 1)
        polRectValues(0, 1) = -90
        polRectValues(0, 2) = 0
        polRectValues(0, 3) = (polRectValues(0, 0) * -1)
        'Populate L1 Value
        circuitValues(3, 0) = CDbl(L1TextBox.Text)
        'Populate RW Value
        circuitValues(4, 0) = CDbl(RwTextBox.Text)
        'Calculate and Populate XL1
        circuitValues(3, 1) = CalculateXL(circuitValues(0, 1), circuitValues(3, 0))
        polRectValues(1, 0) = RectToPol(circuitValues(4, 0), circuitValues(3, 1))(0)
        polRectValues(1, 1) = RectToPol(circuitValues(4, 0), circuitValues(3, 1))(1)
        polRectValues(1, 2) = circuitValues(4, 0)
        polRectValues(1, 3) = circuitValues(3, 1)
        'Populate C2 Value
        circuitValues(5, 0) = CDbl(C2TextBox.Text)
        'Calculate and Populate CX2
        circuitValues(5, 1) = CalculateXC(circuitValues(0, 1), circuitValues(5, 0))
        polRectValues(2, 0) = circuitValues(5, 1)
        polRectValues(2, 1) = -90
        polRectValues(2, 2) = 0
        polRectValues(2, 3) = (polRectValues(2, 0) * -1)
        'Populate R2 Value
        circuitValues(6, 0) = CDbl(R2TextBox.Text)
    End Sub

    ''' <summary>
    ''' Returns the Calculated XC given Frequency and Capacitance
    ''' </summary>
    ''' <param name="frequency"></param>
    ''' <param name="capacitance"></param>
    ''' <returns></returns>
    Function CalculateXC(frequency As Double, capacitance As Double) As Double
        Dim xC As Double
        xC = (1 / (2 * pi * frequency * capacitance))
        Return xC
    End Function

    ''' <summary>
    ''' Returns the Calculated XL given Frequency and Inductance
    ''' </summary>
    ''' <param name="frequency"></param>
    ''' <param name="inductace"></param>
    ''' <returns></returns>
    Function CalculateXL(frequency As Double, inductace As Double) As Double
        Dim xL As Double
        xL = (2 * pi * frequency * inductace)
        Return xL
    End Function

    ''' <summary>
    ''' Checks if the contents of the text boxes are numeric.  Returns False if any are not.  
    ''' </summary>
    ''' <returns></returns>
    Function UserInputValidation() As Boolean
        Dim isValid As Boolean = True
        'Check Vgen is a number
        If IsNumeric(VgenTextBox.Text) = False Then
            isValid = False
        End If
        'Check Frequency is a number
        If IsNumeric(FrequencyTextBox.Text) = False Then
            isValid = False
        End If
        'check R1 is a number
        If IsNumeric(R1TextBox.Text) = False Then
            isValid = False
        End If
        'check C1 is a number
        If IsNumeric(C1TextBox.Text) = False Then
            isValid = False
        End If
        'check L1 is a number
        If IsNumeric(L1TextBox.Text) = False Then
            isValid = False
        End If
        'check RW is a number
        If IsNumeric(RwTextBox.Text) = False Then
            isValid = False
        End If
        'check C2 is a number
        If IsNumeric(C2TextBox.Text) = False Then
            isValid = False
        End If
        'check R2 is a number
        If IsNumeric(R2TextBox.Text) = False Then
            isValid = False
        End If
        Return isValid
    End Function

    ''' <summary>
    ''' Loads Default values into Array and updates Text boxes
    ''' </summary>
    Sub LoadDefaults()
        VgenTextBox.Text = "12"
        FrequencyTextBox.Text = "1000"
        R1TextBox.Text = "50"
        C1TextBox.Text = "0.000001"
        L1TextBox.Text = "1"
        RwTextBox.Text = "50"
        C2TextBox.Text = "0.000001"
        R2TextBox.Text = "500"
        LoadCircuitValues()
        CalculateBranch1()
        CalculateSeriesComponents()
        CalculateParallelBranches()
        CalculateImpedanceTotal()
    End Sub

    ''' <summary>
    ''' Converts Polar Coordinates to Rectangular Coordinates Return(0) is real Return(1) is imaginary
    ''' </summary>
    ''' <param name="vector"></param>
    ''' <param name="angle"></param>
    ''' <returns></returns>
    Function PolToRect(vector As Double, angle As Double) As Double()
        'convert angle from degrees to radians
        angle = (angle * (pi / 180))
        Dim rectangularForm(1) As Double
        rectangularForm(0) = (vector * System.Math.Cos(angle))
        rectangularForm(1) = (vector * System.Math.Sin(angle))
        Return rectangularForm
    End Function

    ''' <summary>
    ''' Converts Rectangular Coordinates to Polar Coordinates Return(0) is vector Return(1) is angle
    ''' </summary>
    ''' <param name="real"></param>
    ''' <param name="imaginary"></param>
    ''' <returns></returns>
    Function RectToPol(real As Double, imaginary As Double) As Double()
        Dim polarForm(1) As Double
        polarForm(0) = System.Math.Sqrt((real ^ 2) + (imaginary ^ 2))
        polarForm(1) = ((System.Math.Atan(imaginary / real) * 180) / pi)
        Return polarForm
    End Function

    ''' <summary>
    ''' Calculates C2 and R2 in series.  Stores values as rectangular and polar in impedanceValues(0,x)
    ''' </summary>
    Sub CalculateBranch1()
        'set rectangular values R2 then C2
        impedanceValues(0, 2) = circuitValues(6, 0) ' Real value is R2
        impedanceValues(0, 3) = polRectValues(0, 3) 'Imaginary value is XC2
        'convert and set polar values
        impedanceValues(0, 0) = RectToPol(impedanceValues(0, 2), impedanceValues(0, 3))(0) 'Set Vector
        impedanceValues(0, 1) = RectToPol(impedanceValues(0, 2), impedanceValues(0, 3))(1) 'Set Phase Angle
    End Sub

    ''' <summary>
    ''' Calculates R1 and C1 in series.  Stores values as rectangular and Polar in impedanceValues(2,x)
    ''' </summary>
    Sub CalculateSeriesComponents()
        'Set rectangular vales R1 then C1
        impedanceValues(2, 2) = circuitValues(1, 0) 'Real value is R1
        impedanceValues(2, 3) = polRectValues(0, 3) 'imaginary vale is XC1
        'convert and set polar values
        impedanceValues(2, 0) = RectToPol(impedanceValues(2, 2), impedanceValues(2, 3))(0) 'Set Vector
        impedanceValues(2, 1) = RectToPol(impedanceValues(2, 2), impedanceValues(2, 3))(1) 'Set Angle
    End Sub

    ''' <summary>
    ''' Uses Product over sum to calculate parallel impedance.  Stores values in impedancevalues(1,x)
    ''' </summary>
    Sub CalculateParallelBranches()
        'product(0) is the vector magnitudes  product(1) is the phase angles
        Dim product(1) As Double
        'sum(0) is real value  sum(1) is imaginary
        Dim sum(1) As Double
        'multiply the magnitudes
        product(0) = (impedanceValues(0, 0) * polRectValues(1, 0))
        'add the phase angles
        product(1) = (impedanceValues(0, 1) + polRectValues(1, 1))
        'add real values
        sum(0) = (impedanceValues(0, 2) + polRectValues(1, 2))
        'add imaginary values
        sum(1) = (impedanceValues(0, 3) + polRectValues(1, 3))
        'divide to find parallel total polar magnitude
        impedanceValues(1, 0) = (product(0) / RectToPol(sum(0), sum(1))(0))
        'subtract to find parallel total phase angle
        impedanceValues(1, 1) = (product(1) - RectToPol(sum(0), sum(1))(1))
        'convert and populate rectangular values
        impedanceValues(1, 2) = PolToRect(impedanceValues(1, 0), impedanceValues(1, 1))(0)
        impedanceValues(1, 3) = PolToRect(impedanceValues(1, 0), impedanceValues(1, 1))(1)

    End Sub

    ''' <summary>
    ''' Calculated impedance total.  Stores values in impedanceValues(3,x)
    ''' </summary>
    Sub CalculateImpedanceTotal()
        'add real components
        impedanceValues(3, 2) = (impedanceValues(2, 2) + impedanceValues(1, 2))
        'add imaginary components
        impedanceValues(3, 3) = (impedanceValues(2, 3) + impedanceValues(1, 3))
        'convert rectangular to polar and populate
        impedanceValues(3, 0) = RectToPol(impedanceValues(3, 2), impedanceValues(3, 3))(0)
        impedanceValues(3, 1) = RectToPol(impedanceValues(3, 2), impedanceValues(3, 3))(1)
    End Sub

    ''' <summary>
    ''' Calculates Voltages and Currents (after impedances calculated)  Stored in voltagesAndCurrent(x,x)
    ''' </summary>
    Sub CalculateVoltagesAndCurrents()
        'Calculate Current Total (Vgen / Ztot)
        voltagesAndCurrents(0, 0) = (circuitValues(0, 0) / impedanceValues(3, 0))
        'Calculate Current Total Phase angle (Vgenθ - Ztotθ)
        voltagesAndCurrents(0, 1) = (0 - impedanceValues(3, 1))
        'Calculate VR1 (Itot * R1)
        voltagesAndCurrents(1, 0) = (voltagesAndCurrents(0, 0) * circuitValues(1, 0))
        'calculate VR1 phase angle (=Itotθ)
        voltagesAndCurrents(1, 1) = voltagesAndCurrents(0, 1)
        'Calculate VC1 (Itot * XC1)
        voltagesAndCurrents(1, 2) = (voltagesAndCurrents(0, 0) * polRectValues(0, 0))
        'Calculate VC1 phase angle (Itotθ + XC1θ)
        voltagesAndCurrents(1, 3) = (polRectValues(0, 1) + voltagesAndCurrents(0, 1))
        'Calculate Voltage of Branch 1 and 2 (Itot * ZBR1/2)
        voltagesAndCurrents(2, 0) = (voltagesAndCurrents(0, 0) * impedanceValues(1, 0))
        'Calculate Voltage Phase angle of Branch 1 and 2 (Itotθ + ZBR1/2θ)
        voltagesAndCurrents(2, 1) = (voltagesAndCurrents(0, 1) + impedanceValues(1, 1))
        'Calculate Current of Branch 1 (VBR1/2 / ZBR1)
        voltagesAndCurrents(3, 0) = (voltagesAndCurrents(2, 0) / impedanceValues(0, 0))
        'Calculate the current phase angle of Branch 1 (VBR1/2θ - ZBR1θ)
        voltagesAndCurrents(3, 1) = (voltagesAndCurrents(2, 1) - impedanceValues(0, 1))
        'Calculate Current of Branch 2 (VBR1/2 / ZBR2)
        voltagesAndCurrents(3, 2) = (voltagesAndCurrents(2, 0) / polRectValues(1, 0))
        'Calculate the Current Phase angle of branch 2 (VBR1/2θ - ZBR2θ)
        voltagesAndCurrents(3, 3) = (voltagesAndCurrents(2, 1) / polRectValues(1, 1))
        'Calculate VL1 (IBR2 * XL1)
        voltagesAndCurrents(4, 0) = (voltagesAndCurrents(3, 2) * polRectValues(1, 0))
        'Calculate VL1 Phase angle (IBR2θ + XL1θ)
        voltagesAndCurrents(4, 1) = (voltagesAndCurrents(3, 3) + polRectValues(1, 1))
        'Calculate VC2 (IBR1 * XC2)
        voltagesAndCurrents(5, 0) = (voltagesAndCurrents(3, 0) * polRectValues(2, 0))
        'Calculate Phase angle of VC2 (IBR1θ + XC2θ)
        voltagesAndCurrents(5, 1) = (voltagesAndCurrents(3, 1) + polRectValues(2, 1))
        'Calculate VR2 (IBR1 * R2)
        voltagesAndCurrents(5, 2) = (voltagesAndCurrents(3, 0) * circuitValues(6, 0))
        'Calculate Phase angle of VR2 (=IBR1θ)
        voltagesAndCurrents(5, 3) = voltagesAndCurrents(3, 1)
    End Sub

    ''' <summary>
    ''' Returns a string cleaned and formatted into engineering notation from given double point
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function FormatEngNot(value As Double) As String
        Dim tempSplit() As String
        Dim mantissa As Double
        Dim exponent As Double
        Dim metricSuffix As String
        'Split the value into value, the mantissa, and exponent in scientific notation
        tempSplit = Split(value.ToString("e"), "e")
        mantissa = CDbl(tempSplit(0))
        exponent = CDbl(tempSplit(1))
        'Shift until 3 decimal places for engineering notation
        Do While exponent Mod 3 <> 0
            exponent -= 1
            mantissa *= 10
        Loop
        'Set metric suffix dependent on exponent level
        Select Case exponent
            Case = 24 'Yotta
                metricSuffix = "Y"
            Case = 21 'Zetta
                metricSuffix = "Z"
            Case = 18 'Exa
                metricSuffix = "E"
            Case = 15 'Peta
                metricSuffix = "P"
            Case = 12 'Tera
                metricSuffix = "T"
            Case = 9 'Giga
                metricSuffix = "G"
            Case = 6 'Mega
                metricSuffix = "M"
            Case = 3 'Kilo
                metricSuffix = "K"
            Case = 0 'Notta
                metricSuffix = ""
            Case = -3 'Mili
                metricSuffix = "m"
            Case = -6 'Micro
                metricSuffix = "μ"
            Case = -9 'nano
                metricSuffix = "n"
            Case = -12 'pico
                metricSuffix = "p"
            Case = -15 'femto
                metricSuffix = "f"
            Case = -18 'atto
                metricSuffix = "a"
            Case = -21 'zepto
                metricSuffix = "z"
            Case = -24 'yocto
                metricSuffix = "y"
            Case Else
                metricSuffix = $"x10^{exponent}"
        End Select
        'Return value in engineering notation
        Return $"{mantissa}{metricSuffix}"
    End Function

    'Event Handlers
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        'Close Program
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Try
            'Checks if all inputs are numbers
            If UserInputValidation() = True Then
                'Load numbers into array
                LoadCircuitValues()
                MsgBox("User input values have been saved")
            Else
                'Not all numbers throw exception
                Throw New Exception()
            End If
        Catch ex As Exception
            MsgBox("Sorry your inputs could not be converted.  Please enter numbers only.")
        End Try
    End Sub

    Private Sub CircuitForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDefaults()
    End Sub

    Private Sub RestoreDefaultsButton_Click(sender As Object, e As EventArgs) Handles RestoreDefaultsButton.Click
        LoadDefaults()
    End Sub

End Class
