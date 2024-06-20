<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHub = New TextBox()
        btnStopwatch = New Button()
        btnSubmit = New Button()
        txtStopwatch = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(272, 85)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(275, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(272, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(275, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(272, 218)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.PlaceholderText = "Phone Number"
        txtPhoneNumber.Size = New Size(275, 31)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(272, 291)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.PlaceholderText = "Github Link"
        txtGitHub.Size = New Size(275, 31)
        txtGitHub.TabIndex = 3
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = SystemColors.Info
        btnStopwatch.Location = New Point(137, 339)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(275, 41)
        btnStopwatch.TabIndex = 4
        btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Location = New Point(291, 386)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(237, 48)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(432, 344)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(174, 31)
        txtStopwatch.TabIndex = 6
        txtStopwatch.Text = "00:00:00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(368, 25)
        Label2.TabIndex = 8
        Label2.Text = "Tanishk, Slidely AI Task - 2 Create Submission"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(116, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 25)
        Label3.TabIndex = 9
        Label3.Text = "Github"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(100, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 25)
        Label4.TabIndex = 10
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(116, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 25)
        Label5.TabIndex = 11
        Label5.Text = "Email"
        ' 
        ' FormCreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "FormCreateSubmission"
        Text = "FormCreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
