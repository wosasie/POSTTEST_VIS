Module ValidationModule

    Public Sub OnlyLetters(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
            Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub OnlyNumbers(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidateTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidateMerch(ep As ErrorProvider,
                                 txtCode As TextBox,
                                 txtName As TextBox,
                                 cbTeam As ComboBox,
                                 cbCategory As ComboBox,
                                 txtStock As TextBox,
                                 txtPrice As TextBox) As Boolean

        Dim codeValid As Boolean = ValidateTextBox(ep, txtCode, "Merch code cannot be empty")
        Dim nameValid As Boolean = ValidateTextBox(ep, txtName, "Merch name cannot be empty")

        Dim teamValid As Boolean
        If cbTeam.Text.Trim() = "" Then
            ep.SetError(cbTeam, "Team must be selected")
            teamValid = False
        Else
            ep.SetError(cbTeam, "")
            teamValid = True
        End If

        Dim categoryValid As Boolean
        If cbCategory.Text.Trim() = "" Then
            ep.SetError(cbCategory, "Category must be selected")
            categoryValid = False
        Else
            ep.SetError(cbCategory, "")
            categoryValid = True
        End If

        Dim stockValid As Boolean = ValidateTextBox(ep, txtStock, "Stock cannot be empty")
        Dim priceValid As Boolean = ValidateTextBox(ep, txtPrice, "Price cannot be empty")

        Return codeValid And nameValid And teamValid And categoryValid And stockValid And priceValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module