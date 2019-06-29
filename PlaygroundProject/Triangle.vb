Public Class Triangle

    Private newBase As Double
    Private newHeight As Double
    Private newPrice As Double
    Private area As Double
    ' Default constructor
    Public Sub New()

    End Sub

    ' Parameterized constructor
    Public Sub New(base As Double, height As Double, price As Double)
        Me.Base = base
        Me.Height = height
        Me.Price = price

    End Sub

    Public Property Base() As Double
        Get
            Return newBase
        End Get
        Set(ByVal value As Double)
            If value > 0 Then
                newBase = value
            Else
                newBase = 0
            End If
            newBase = value
        End Set
    End Property

    Public Property Height() As Double
        Get
            Return newHeight
        End Get
        Set(ByVal value As Double)
            If value > 0 Then
                newHeight = value
            Else
                newHeight = 0
            End If
            newHeight = value
        End Set
    End Property


    Public Property Price() As Double
        Get
            Return newPrice
        End Get
        Set(ByVal value As Double)
            newPrice = value
        End Set
    End Property

    Public Function GetPrice() As Double
        Return area * newPrice
    End Function

    Public Function GetArea() As Double
        area = Math.Round(0.5 * newBase * newHeight, 2)
        Return area
    End Function
End Class
