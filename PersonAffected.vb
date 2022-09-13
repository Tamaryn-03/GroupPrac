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
Public Class PersonAffected

    'MEMBER VARIABLE DECLARATION.
    Private _Age As Integer
    Private _Gender As String
    Private _Symptom As Integer

    'PROPERTY METHODS.
    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = CheckValueIPositive(value)
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property

    Public Property Symptom As Integer
        Get
            Return _Symptom
        End Get
        Set(value As Integer)
            _Symptom = value
        End Set
    End Property

    'CONSTRUCTOR.
    Public Sub New(Age As Integer, Gender As String, Symptom As Integer)
        _Age = Age
        _Gender = Gender
        _Symptom = Symptom
    End Sub

    'DEFAULT CONSTRUCTOR.
    Public Sub New()

    End Sub

    'METHOD
    Protected Function CheckValueIPositive(v As Integer) As Integer
        If v >= 0 Then
            Return v
        Else
            Throw New InvalidCastException(CStr(v) & "is negative value")
        End If
    End Function
End Class
