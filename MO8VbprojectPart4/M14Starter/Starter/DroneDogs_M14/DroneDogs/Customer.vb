Public Structure Customer
    'Public members
    Public FirstName As String
    Public LastName As String
    Public Email As String

    'Formats the display
    Public Overrides Function ToString() As String
        Return FirstName & " " & LastName & " (" & Email & ")"
    End Function

End Structure




