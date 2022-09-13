' *****************************************************************
' Team Number: 36
' Team Member 1 Details: Shaw, TL (222040654)
' Team Member 2 Details: Maphelela,MJ (220061897)
' Team Member 3 Details: Nkuna,TV (222077432)
' Team Member 4 Details: Amod, ME (222143220)
' Practical: Team Project
' Class name: frmDisease
' *****************************************************************
'OPTION STATEMENTS.
Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Disease '//ABSTRACT.

    'MEMBER VARIABLE DECLARATION.
    Private _PersonAffected() As PersonAffected   '//COMPOSITION.
    Private _Type As String
    Private _Curability As String
    Private _TotalMale As Integer

    'PROPERTY METHODS.
    Public Property PersonAffected(index As Integer) As PersonAffected
        Get
            Return _PersonAffected(index)
        End Get
        Set(value As PersonAffected)
            _PersonAffected(index) = value
        End Set
    End Property

    Public Property Curability As String
        Get
            Return _Curability
        End Get
        Set(value As String)
            _Curability = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _Type
        End Get
        Set(value As String)
            _Type = value
        End Set
    End Property

    'CONSTRUCTORS.
    Public Sub New(Curability As String, Type As String)
        _Type = Type
        _Curability = Curability
    End Sub

    Public Sub New(NumPeople As Integer)
        ReDim _PersonAffected(NumPeople)
        For i As Integer = 1 To NumPeople
            _PersonAffected(i) = New PersonAffected()
        Next
    End Sub

    'METHODS.
    Public Overridable Function MaxAge() As Integer
        Dim Age, Max As Integer

        Age = _PersonAffected(1).Age
        For i As Integer = 2 To (_PersonAffected.Length - 1)
            If Age < _PersonAffected(i).Age Then
                Age = _PersonAffected(i).Age
                Max = i
            End If
        Next
        Return _PersonAffected(Max).Age
    End Function

    Public Overridable Function GenderRatio() As Double
        Dim Males, Females As Integer
        Males = 0
        Females = 0
        For i As Integer = 1 To (_PersonAffected.Length - 1)
            If _PersonAffected(i).Gender = "Male" Then
                Males += 1
            Else
                Females += 1
            End If
        Next
        Return Males / Females
    End Function

    'Public Overridable Function Treatment(Condition As Integer) As String
    '    Dim Meds As String = ""
    '    Return Meds
    'End Function

End Class
