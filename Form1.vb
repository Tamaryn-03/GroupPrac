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
Public Class frmDisease

    'VARIABLE DECLARATION.
    Private objHIV As HIV
    Private objMalaria As Malaria
    Private NumHIV, NumMalaria As Integer

    Public Sub Initialize()

        'GET NUMBER OF INFECTED PEOPLE FOR EACH DISEASE FROM USER.
        NumHIV = CInt(InputBox("How many people are infected with HIV?"))
        NumMalaria = CInt(InputBox("How many people are infected with Malaria?"))

        'RESIZE GRID.
        grdHIV.Rows = 1 + NumHIV
        grdHIV.Cols = 1 + 4
        grdHIV.set_ColWidth(4, 176)
        grdMalaria.Rows = 1 + NumMalaria
        grdMalaria.Cols = 1 + 4
        grdMalaria.set_ColWidth(4, 176)
        'DISPLAY HEADINGS.
        For i As Integer = 1 To NumHIV
            DisplayH(i, 0, "Person" & i)
        Next
        For m As Integer = 1 To NumMalaria
            DisplayM(m, 0, "Person" & m)
        Next
        DisplayH(0, 0, "Person:")
        DisplayH(0, 1, "Age:")
        DisplayH(0, 2, "Gender:")
        DisplayH(0, 3, "Symptom Rating:")
        DisplayH(0, 4, "Treatment:")
        DisplayM(0, 0, "Person:")
        DisplayM(0, 1, "Age:")
        DisplayM(0, 2, "Gender:")
        DisplayM(0, 3, "Symptom Rating:")
        DisplayM(0, 4, "Treatment:")
    End Sub

    'SUBROUTINE TO DISPLAY HIV INFO IN GRID.
    Private Sub DisplayH(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdHIV.Row = r
        grdHIV.Col = c
        grdHIV.Text = t
    End Sub

    'SUBROUTINE TO DISPLAY MALARIA INFO IN GRID.
    Private Sub DisplayM(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdMalaria.Row = r
        grdMalaria.Col = c
        grdMalaria.Text = t
    End Sub

    'BUTTON TO INITIALIZE.
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        Initialize()
    End Sub

    'BUTTTON TO GET INFO FROM USER FOR EACH DISEASE.
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim Age As Integer
        Dim Gender As String
        Dim Symptom As Integer
        Dim Treatment As String

        Dim Choice As Integer
        Choice = CInt(InputBox("Which Disease would you like to evaluate?" & vbNewLine & "1.HIV" & vbNewLine & "2,Malaria"))
        Select Case Choice
            Case 1
                'INSTANCIATION.
                objHIV = New HIV(NumHIV)
                For i As Integer = 1 To NumHIV
                    Age = CInt(InputBox("What is the Age of person" & i & "?"))
                    DisplayH(i, 1, CStr(Age))
                    Gender = InputBox("What is the Gender of person" & i & "?")
                    DisplayH(i, 2, Gender)
                    Symptom = CInt(InputBox("On a scale of 1 to 10 how bad are the symptoms of person" & i & "?"))
                    DisplayH(i, 3, CStr(Symptom))
                    objHIV.PersonAffected(i) = New PersonAffected(Age, Gender, Symptom)
                    Treatment = objHIV.Treatment(Age) '//Polymorphism//
                    DisplayH(i, 4, CStr(Treatment))
                Next i
            Case 2
                'INSTANCIATION.
                objMalaria = New Malaria(NumMalaria)
                For m As Integer = 1 To NumMalaria
                    Age = CInt(InputBox("What is the Age of person" & m & "?"))
                    DisplayM(m, 1, CStr(Age))
                    Gender = InputBox("What is the Gender of person" & m & "?")
                    DisplayM(m, 2, Gender)
                    Symptom = CInt(InputBox("On a scale of 1 to 10 how bad are the symptoms of person" & m & "?"))
                    DisplayM(m, 3, CStr(Symptom))
                    objMalaria.PersonAffected(m) = New PersonAffected(Age, Gender, Symptom)
                    Treatment = objMalaria.Treatment(Symptom) '//Polymorphism//
                    DisplayM(m, 4, CStr(Treatment))
                Next m
        End Select

    End Sub

    'BUTTON TO DISPLAY FINAL RESULTS.
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        'HIV RESULTS.
        txtMaxAgeHIV.Text = CStr(objHIV.MaxAge())
        txtGenderRatioHIV.Text = CStr(objMalaria.GenderRatio())
        'MALARIA RESULTS.
        txtMaxAgeMalaria.Text = CStr(objMalaria.MaxAge())
        txtGenderRatioMalaria.Text = CStr(objMalaria.GenderRatio())
        'MORE COMMON DISEASE.
        If NumHIV > NumMalaria Then
            txtDisease.Text = "HIV & AIDS"
        Else
            If NumHIV = NumMalaria Then
                txtDisease.Text = "Both"
            Else
                If NumMalaria > NumHIV Then
                    txtDisease.Text = "Malaria"
                End If
            End If
        End If
    End Sub
End Class
