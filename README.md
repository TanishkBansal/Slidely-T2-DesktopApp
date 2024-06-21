# Submission Form Application - Frontend

This repository contains the frontend components of the Submission Form Application. The application is built using Visual Basic within Visual Studio. It allows users to create, view, edit, and delete submissions. It also includes a stopwatch feature that records the time taken to fill out the form.

## Directory Structure (Check Raw it can explain properly)

SubmissionFormApp/
│
├── SubmissionFormApp.sln
├── My Project/
│ ├── Application.Designer.vb
│ ├── Application.myapp
│ ├── AssemblyInfo.vb
│ ├── Resources.Designer.vb
│ ├── Resources.resx
│ └── Settings.Designer.vb
├── FormCreateSubmission.Designer.vb
├── FormCreateSubmission.resx
├── FormCreateSubmission.vb
├── FormViewSubmissions.Designer.vb
├── FormViewSubmissions.resx
├── FormViewSubmissions.vb
├── Submission.vb
└── README.md


## Files and Details

### Solution File
- **SubmissionFormApp.sln**: The solution file for the Visual Studio project.

### Project Files
- **My Project/**: This folder contains project-related files and settings.
  - **Application.Designer.vb**: Auto-generated file for application configuration.
  - **Application.myapp**: Contains application-level properties.
  - **AssemblyInfo.vb**: Contains assembly-level attributes.
  - **Resources.Designer.vb**: Auto-generated file for managing resources.
  - **Resources.resx**: Resource file for storing string and image resources.
  - **Settings.Designer.vb**: Auto-generated file for managing application settings.

### Form Files

#### FormCreateSubmission

- **FormCreateSubmission.Designer.vb**: Designer file for the Create Submission form. This file is auto-generated and contains the layout and controls of the form.
- **FormCreateSubmission.resx**: Resource file for the Create Submission form. It stores any resources (like strings or images) used by the form.
- **FormCreateSubmission.vb**: Code-behind file for the Create Submission form. This file contains the logic for handling form initialization, form submission, the stopwatch functionality, and keyboard shortcuts.

#### FormViewSubmissions

- **FormViewSubmissions.Designer.vb**: Designer file for the View Submissions form. This file is auto-generated and contains the layout and controls of the form.
- **FormViewSubmissions.resx**: Resource file for the View Submissions form. It stores any resources (like strings or images) used by the form.
- **FormViewSubmissions.vb**: Code-behind file for the View Submissions form. This file contains the logic for handling form navigation, deletion, and editing of submissions.

### Class Files
- **Submission.vb**: Class file that defines the `Submission` class and methods for saving, loading, deleting, and updating submissions. This class simulates the backend storage using a static list.

## How to Set Up

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/yourusername/SubmissionFormApp.git
   cd SubmissionFormApp
   
2. **Open in Visual Studio**:
  - Open Visual Studio.
  - Select `File` > `Open` > `Project/Solution`.
  - Navigate to the cloned repository and select `SubmissionFormApp.sln`.

3. **Build and Run**:
  - Build the solution by selecting `Build` > `Build Solution`.
  - Run the application by pressing `F5` or selecting `Debug` > `Start Debugging`.

### Features

  - **Create New Submission**: Allows users to create a new submission with name, email, phone number, GitHub repo link, and stopwatch time.
  - **View Submissions**: Allows users to view all submissions one by one.
  - **Edit Submission**: Allows users to edit an existing submission.
  - **Delete Submission**: Allows users to delete a submission.
  - **Stopwatch**: A stopwatch feature to record the time taken to fill out the form.

### Keyboard Shortcuts
  - **View Submissions: `Ctrl + V`**
  - **Create New Submission: `Ctrl + N`**
  - **Previous Submission: `Ctrl + P`**
  - **Next Submission: `Ctrl + N`**
  - **Toggle Stopwatch: `Ctrl + T`**
  - **Submit Form: `Ctrl + S`**
