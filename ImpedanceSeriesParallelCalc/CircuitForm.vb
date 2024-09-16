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
        'Populate L1 Value
        circuitValues(3, 0) = CDbl(L1TextBox.Text)
        'Calculate and Populate XL1
        circuitValues(3, 1) = CalculateXL(circuitValues(0, 1), circuitValues(3, 0))
        'Populate RW Value
        circuitValues(4, 0) = CDbl(RwTextBox.Text)
        'Populate C2 Value
        circuitValues(5, 0) = CDbl(C2TextBox.Text)
        'Calculate and Populate CX2
        circuitValues(5, 1) = CalculateXC(circuitValues(0, 1), circuitValues(5, 0))
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
        'Load Default Values: Vgen = 12V, F = 100, R1 = 50, C1 = 1μF, L1 = 1H, RW = 50, C2 = 1μF, R2 = 500
        circuitValues = {{12, 100}, {50, 0}, {0.000001, 0}, {1, 0}, {50, 0}, {0.000001, 0}, {500, 0}}
        'Calculate Default XC1
        circuitValues(2, 1) = CalculateXC(circuitValues(0, 1), circuitValues(2, 0))
        'Calculate Default XL1
        circuitValues(3, 1) = CalculateXL(circuitValues(0, 1), circuitValues(3, 0))
        'Calculate Default XC2
        circuitValues(5, 1) = CalculateXC(circuitValues(0, 1), circuitValues(5, 0))
        'Update Text boxes with defaults
        VgenTextBox.Text = CStr(circuitValues(0, 0))
        FrequencyTextBox.Text = CStr(circuitValues(0, 1))
        R1TextBox.Text = CStr(circuitValues(1, 0))
        C1TextBox.Text = CStr(circuitValues(2, 0))
        L1TextBox.Text = CStr(circuitValues(3, 0))
        RwTextBox.Text = CStr(circuitValues(4, 0))
        C2TextBox.Text = CStr(circuitValues(5, 0))
        R2TextBox.Text = CStr(circuitValues(6, 0))
    End Sub

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
