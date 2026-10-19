Imports System.Drawing
Imports System.Windows.Forms

Public Class BaseForm
    Inherits Form

    Public Sub New()

        ' Theme
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.ForeColor = Color.White

        ' Window
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        ' Font
        Me.Font = New Font("Segoe UI", 10)

    End Sub

    Protected Sub ShowSuccess(message As String)
        MessageBox.Show(message,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Protected Sub ShowError(message As String)
        MessageBox.Show(message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
    End Sub

    Protected Function ConfirmExit() As Boolean

        Return MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes

    End Function

End Class
