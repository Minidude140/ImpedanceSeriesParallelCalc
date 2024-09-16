'Zachary Christensen
'Spring 2024; 09/15/24
'Series Parallel Impedance Calculator
'https://github.com/Minidude140/ImpedanceSeriesParallelCalc

'TOdO
'[]Load Circuit Values into array
'[]User input validation
'[]Load Default Circuit Values
'[]Do Math
'[]Create and populate list box with results
'[]Output File with results;  Use print function

Option Explicit On
Option Strict On
Public Class CircuitForm
    Dim circuitValues(6, 1) As Integer
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
        circuitValues(0, 0) = CInt(VgenTextBox.Text)
        'Populate Frequency
        circuitValues(0, 1) = CInt(FrequencyTextBox.Text)
        'Populate R1 Value
        circuitValues(1, 0) = CInt(R1TextBox.Text)
        'Populate C1 Value
        circuitValues(2, 0) = CInt(C1TextBox.Text)
        'Calculate and Populate XC1
        'circuitValues(2, 1) = CalculateXC(circuitValues(0, 1), circuitValues(2, 0))
        'Populate L1 Value
        circuitValues(3, 0) = CInt(L1TextBox.Text)
        'Calculate and Populate XL1
        'circuitValues(3, 1) = CalculateXL(circuitValues(0,1), circuitValues(3, 0))
        'Populate RW Value
        circuitValues(4, 0) = CInt(RwTextBox.Text)
        'Populate C2 Value
        circuitValues(5, 0) = CInt(C2TextBox.Text)
        'Calculate and Populate CX2
        'circuitValues(5, 1) = CalculateXC(circuitValues(0, 1), circuitValues(5, 0)
        'Populate R2 Value
        circuitValues(6, 0) = CInt(R2TextBox.Text)
    End Sub

    'Event Handlers
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        'Close Program
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

    End Sub
End Class
