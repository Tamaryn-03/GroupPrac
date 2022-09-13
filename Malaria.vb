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
Public Class Malaria
    Inherits Disease
    Implements ITreatment

    'CONSTRUCTORS.
    Public Sub New(Curability As String, Type As String)
        MyBase.New(Curability, Type)
    End Sub

    Public Sub New(NumPeople As Integer)
        MyBase.New(NumPeople)
    End Sub

    'METHODS.
    Public Overrides Function MaxAge() As Integer
        Return MyBase.MaxAge()
    End Function

    Public Overrides Function GenderRatio() As Double
        Return MyBase.GenderRatio()
    End Function

    Public Function Treatment(Symptom As Integer) As String Implements ITreatment.Treatment
        Dim Meds As String
        If Symptom > 5 Then
            Meds = "Artesunate,Artemether,Doxycycline"
        Else
            Meds = "Clindamycin"
        End If
        Return Meds
    End Function

End Class
