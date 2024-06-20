Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubRepo As String
    Public Property StopwatchTime As String ' Add this property

    Public Sub New(name As String, email As String, phoneNumber As String, gitHubRepo As String, stopwatchTime As String)
        Me.Name = name
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.GitHubRepo = gitHubRepo
        Me.StopwatchTime = stopwatchTime ' Initialize this property
    End Sub

    ' For simplicity, using a static list to simulate backend
    Private Shared submissions As New List(Of Submission)()

    Public Shared Sub SaveSubmission(submission As Submission)
        submissions.Add(submission)
    End Sub

    Public Shared Function LoadSubmissions() As List(Of Submission)
        Return submissions
    End Function

    Public Shared Sub DeleteSubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            submissions.RemoveAt(index)
        End If
    End Sub

    Public Shared Sub UpdateSubmission(index As Integer, updatedSubmission As Submission)
        If index >= 0 AndAlso index < submissions.Count Then
            submissions(index) = updatedSubmission
        End If
    End Sub
End Class
