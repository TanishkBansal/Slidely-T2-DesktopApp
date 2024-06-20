Public Class FormViewSubmissions
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from backend (for simplicity, using a local list)
        submissions = Submission.LoadSubmissions()
        ShowSubmission()
        Me.KeyPreview = True
    End Sub

    Private Sub ShowSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            ' Display the submission details
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhoneNumber.Text = submission.PhoneNumber
            lblGitHub.Text = submission.GitHubRepo
            lblStopwatchTime.Text = submission.StopwatchTime
        Else
            lblName.Text = ""
            lblEmail.Text = ""
            lblPhoneNumber.Text = ""
            lblGitHub.Text = ""
            lblStopwatchTime.Text = "Stopwatch Time: "
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Submission.DeleteSubmission(currentIndex)
            If currentIndex > 0 Then
                currentIndex -= 1
            End If
            ShowSubmission()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim submission = submissions(currentIndex)
        Dim editForm As New FormCreateSubmission(submission, currentIndex)
        editForm.ShowDialog()
        submissions = Submission.LoadSubmissions()
        ShowSubmission()
    End Sub

    Private Sub FormViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
