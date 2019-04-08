'raw VBA code
Sub final()
Dim test As Boolean
Dim result
test = validate()
If test = True Then
    result = loops()
Else
   result = MsgBox("Something went wrong, please read the instructions.", vbCritical, "Error")
End If
End Sub
'validates the rule,row and column inputs
Function validate() As Boolean
validate = True
Dim words(2) As String
Dim nums(2) As Double
'gets input as string to not cause an error
words(0) = Range("E1").Value
words(1) = Range("E5").Value
words(2) = Range("E7").Value
'tests if inputs are numeric
If IsNumeric(words(0)) = False Or IsNumeric(words(1)) = False Or IsNumeric(words(2)) = False Then
      validate = False
      Exit Function
End If
'converts to decimal format
    nums(0) = words(0)
    nums(1) = words(1)
    nums(2) = words(2)
'tests lower bounds
If nums(0) < 0 Or nums(1) < 0 Or nums(2) < 0 Then
        validate = False
      Exit Function
End If
'tests upper bounds
If nums(0) > 255 Or nums(1) > 50 Or nums(2) > 100 Then
        validate = False
      Exit Function
End If
'tests if the decimal can be reperesnted as an nteger with no rounding
If nums(0) <> Int(nums(0)) Or nums(1) <> Int(nums(1)) Or nums(1) <> Int(nums(1)) Then
    validate = False
      Exit Function
End If
Exit Function
End Function
Function loops()
      'declare variables
    Dim inp As String
    Dim cur
    cur = "L2"
    'for loop for each row thats being changed
    For i = 0 To Range("E5").Value
        'for loop for each collumn being changed
        For j = 0 To Range("E7").Value
            'finds the above input
            Range(cur).Select
            ActiveCell.Offset(-1, -1).Select
            inp = ActiveCell.Value
            ActiveCell.Offset(0, 1).Select
            inp = inp & ActiveCell.Value
            ActiveCell.Offset(0, 1).Select
            inp = inp & ActiveCell.Value
            
            'calls function find_value
            find_value (inp)
            Range(cur).Value = Range("DJ1").Value
            'changes the value
            Range(cur).Select
            cur = Range(cur).Offset(0, 1).Address
            'increments column
        Next
        'increments row
        Range("L2").Select
        ActiveCell.Offset(i, 0).Select
        cur = ActiveCell.Address
    Next
End Function
Function find_value(inp As String)
    'declare vairables
    Dim table As String
    table = "B55"
    Dim rule
    rule = Range("E1")
    Range(table).Select
    'selects the correct column
    Range(table).Select
    ActiveCell.Offset(0, rule).Select
    'selects the correct collumn
    Select Case inp
    Case Is = "111"
        ActiveCell.Offset(1, 0).Select
    Case Is = "110"
        ActiveCell.Offset(2, 0).Select
    Case Is = "101"
        ActiveCell.Offset(3, 0).Select
    Case Is = "100"
        ActiveCell.Offset(4, 0).Select
    Case Is = "011"
        ActiveCell.Offset(5, 0).Select
    Case Is = "010"
        ActiveCell.Offset(6, 0).Select
    Case Is = "001"
        ActiveCell.Offset(7, 0).Select
    Case Is = "000"
        ActiveCell.Offset(8, 0).Select
    End Select
    Range("DJ1") = ActiveCell.Value
End Function


