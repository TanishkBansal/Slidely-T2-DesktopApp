Imports System.Diagnostics

Public Class FormCreateSubmission
    Private stopwatch As Stopwatch = New Stopwatch()
    Private isRunning As Boolean = False
    Private timer As Timer
    Private isEdit As Boolean = False
    Private editIndex As Integer = -1

    ' Constructor for creating new submission
    Public Sub New()
        InitializeComponent()
        InitializeForm()
    End Sub

    ' Constructor for editing existing submission
    Public Sub New(submission As Submission, index As Integer)
        InitializeComponent()
        InitializeForm()

        ' Set form fields with the existing submission data
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhoneNumber.Text = submission.PhoneNumber
        txtGitHub.Text = submission.GitHubRepo
        txtStopwatch.Text = submission.StopwatchTime

        isEdit = True
        editIndex = index
    End Sub

    Private Sub InitializeForm()
        Me.KeyPreview = True
        txtStopwatch.Text = "00:00:00"
        timer = New Timer()
        AddHandler timer.Tick, AddressOf UpdateStopwatch
        timer.Interval = 1000 ' Update every second
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If isRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnStopwatch.Text = "Resume"
        Else
            stopwatch.Start()
            timer.Start()
            btnStopwatch.Text = "Pause"
        End If
        isRunning = Not isRunning
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newSubmission As New Submission(txtName.Text, txtEmail.Text, txtPhoneNumber.Text, txtGitHub.Text, txtStopwatch.Text)
        If isEdit Then
            Submission.UpdateSubmission(editIndex, newSubmission)
        Else
            Submission.SaveSubmission(newSubmission)
        End If
        MessageBox.Show("Submission Saved!")
        ResetStopwatch()
        Me.Close()
    End Sub

    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        End If
    End Sub

    Private Sub UpdateStopwatch(sender As Object, e As EventArgs)
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub ResetStopwatch()
        stopwatch.Reset()
        txtStopwatch.Text = "00:00:00"
        btnStopwatch.Text = "Start"
        isRunning = False
        timer.Stop()
    End Sub
End Class
