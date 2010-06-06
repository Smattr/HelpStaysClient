Public Class Bed

    Public id As Integer
    Public owner As String
    Public phoneNumber As String
    Public address1 As String
    Public address2 As String
    Public suburb As String
    Public state As String
    Public postcode As String
    Public country As String
    Public latitude As Double
    Public longitude As Double

    Public Function fullAddress() As String
        Dim address As String

        address = ""
        If Not IsNothing(address1) AndAlso address1 <> "" Then
            address &= address1 & ", "
        End If
        If Not IsNothing(address2) AndAlso address2 <> "" Then
            address &= address2 & ", "
        End If
        If Not IsNothing(suburb) AndAlso suburb <> "" Then
            address &= suburb & ", "
        End If
        If Not IsNothing(state) AndAlso state <> "" Then
            address &= state & ", "
        End If
        If Not IsNothing(postcode) AndAlso postcode <> "" Then
            address &= postcode & ", "
        End If
        If Not IsNothing(country) AndAlso country <> "" Then
            address &= country
        End If
        If address.EndsWith(", ") Then
            address = address.Substring(0, address.Length - 2)
        End If
        Return address
    End Function
End Class
