'the  button runs this code, there is a lookup table hidden beneath the celular automation area for the correct value

Sub final()
    Dim test As Boolean
    Dim result
    test = validate()
    If test = True Then
        result = loops()
    Else
    result = MsgBox("Opps, Something went wrong!" & vbNewLine & vbNewLine & "Try change the gird size or the rule" & vbNewLine & "The max grid size is 100 by 50" & vbNewLine & "Rules go from 0 to 255 inclusive", vbCritical, "Error")
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
        For j = 0 To Range("E7").Value - 1
            'finds the above input
            inp = Range(cur).Offset(-1, -1).Value
            inp = inp & Range(cur).Offset(-1, 0).Value
            inp = inp & Range(cur).Offset(-1, 1).Value
            'calls function find_value
            Range(cur).Value = find_value(inp)
            'changes the value
            cur = Range(cur).Offset(0, 1).Address
            'increments column adress
        Next
        'increments row adress
        cur = Range("L2").Offset(i, 0).Address
    Next
End Function
Function find_value(inp As String) As Integer
    'declare vairables
    Dim table As String
    table = "E15"
    'selects the correct collumn and row from the reference table
    Select Case inp
        Case Is = "111"
            find_value = Range(table).Offset(0, 0).Value
        Case Is = "110"
            find_value = Range(table).Offset(1, 0).Value
        Case Is = "101"
            find_value = Range(table).Offset(2, 0).Value
        Case Is = "100"
            find_value = Range(table).Offset(3, 0).Value
        Case Is = "011"
            find_value = Range(table).Offset(4, 0).Value
        Case Is = "010"
            find_value = Range(table).Offset(5, 0).Value
        Case Is = "001"
            find_value = Range(table).Offset(6, 0).Value
        Case Is = "000"
            find_value = Range(table).Offset(7, 0).Value
        Case Else
            find_value = 2
    End Select
End Function
