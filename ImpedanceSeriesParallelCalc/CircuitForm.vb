'Zachary Christensen
'Spring 2024; 09/15/24
'Series Parallel Impedance Calculator
'https://github.com/Minidude140/ImpedanceSeriesParallelCalc

'TOdO
'[*]Load Circuit Values into array
'[*]User input validation
'[*]Load Default Circuit Values
'[]Do Math
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
    '   1:  |  XL1  | XL1θ  |  XL1R  |  XL1J
    '   2:  |  XC2  | XC2θ  |  XC2R  |  XC2J

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
    End Sub

    ''' <summary>
    ''' Converts Polar Coordinates to Rectangular Coordinates Return(0) is real Return(1) is imaginary
    ''' </summary>
    ''' <param name="vector"></param>
    ''' <param name="angle"></param>
    ''' <returns></returns>
    Function PolToRect(vector As Double, angle As Double) As Double()
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
