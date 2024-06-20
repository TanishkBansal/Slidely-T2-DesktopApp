<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHub = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStopwatchTime = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.Info
        btnPrevious.Location = New Point(151, 365)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(180, 52)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(337, 365)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(195, 52)
        btnNext.TabIndex = 1
        btnNext.Text = "Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(384, 89)
        lblName.Name = "lblName"
        lblName.Size = New Size(63, 25)
        lblName.TabIndex = 2
        lblName.Text = "Label1"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(384, 148)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(63, 25)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Label2"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(384, 204)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(63, 25)
        lblPhoneNumber.TabIndex = 4
        lblPhoneNumber.Text = "Label3"
        ' 
        ' lblGitHub
        ' 
        lblGitHub.AutoSize = True
        lblGitHub.Location = New Point(384, 257)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(63, 25)
        lblGitHub.TabIndex = 5
        lblGitHub.Text = "Label4"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 7
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 25)
        Label3.TabIndex = 8
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(202, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 9
        Label4.Text = "Github Link"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(388, 307)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(63, 25)
        lblStopwatchTime.TabIndex = 10
        lblStopwatchTime.Text = "Label5"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(202, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 25)
        Label5.TabIndex = 11
        Label5.Text = "Stopwatch Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(46, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(358, 25)
        Label6.TabIndex = 12
        Label6.Text = "Tanishk,Slidely AI Task 2 - View Submissions"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ButtonShadow
        btnEdit.Location = New Point(242, 444)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(195, 52)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaptionText
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(242, 512)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(195, 52)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' FormViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 626)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblStopwatchTime)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        KeyPreview = True
        Name = "FormViewSubmissions"
        Text = "FormViewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHub As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
