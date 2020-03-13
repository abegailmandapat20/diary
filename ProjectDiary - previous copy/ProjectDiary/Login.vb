Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnection()
        'Change Background Image According to Current Time'
        Dim current As Date = Date.Now
        Dim morning As New Date(current.Year, current.Month, current.Day, 6, 0, 0)
        Dim afternoon As New Date(current.Year, current.Month, current.Day, 15, 0, 0)
        Dim evening As New Date(current.Year, current.Month, current.Day, 18, 0, 0, 0)
        If (current >= morning) And (current <= afternoon) Then
            Me.BackgroundImage = My.Resources.early_bg
        ElseIf (current > afternoon) And (current <= evening) Then
            Me.BackgroundImage = My.Resources.afternoon_bg
        ElseIf (current > evening) And (current < morning) Then
            Me.BackgroundImage = My.Resources.projectDiaryBG
        End If
    End Sub
    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        With btnClose
            .BackgroundImage = My.Resources.Close
        End With
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        With btnClose
            .BackgroundImage = My.Resources.close_clicked1
        End With
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        With btnMinimize
            .BackgroundImage = My.Resources.Minimize
        End With
    End Sub

    Private Sub btnMinimize_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseDown
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_clicked
        End With
    End Sub

    Private Sub btnMinimize_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseUp
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseDown
        With btnLogin
            .BackgroundImage = My.Resources.long_button_clicked
        End With
    End Sub

    Private Sub btnLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseUp
        With btnLogin
            .BackgroundImage = My.Resources.long_button
        End With
    End Sub

    Private Sub tboxUsername_Enter(sender As Object, e As EventArgs) Handles tboxUsername.Enter
        If tboxUsername.Text = "Username" Then
            tboxUsername.Text = ""
        End If
    End Sub

    Private Sub tboxUsername_Leave(sender As Object, e As EventArgs) Handles tboxUsername.Leave
        If tboxUsername.Text = "" Then
            tboxUsername.Text = "Username"
        End If
    End Sub

    Private Sub tboxPassword_Enter(sender As Object, e As EventArgs) Handles tboxPassword.Enter
        If tboxPassword.Text = "Password" Then
            tboxPassword.Text = ""
            tboxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub tboxPassword_Leave(sender As Object, e As EventArgs) Handles tboxPassword.Leave
        If tboxPassword.Text = "" Then
            tboxPassword.Text = "Password"
            tboxPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub registerLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registerLink.LinkClicked
        Call New Registration().Show()
        Close()
    End Sub

    'button login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim found As Boolean = False
            Dim strname As String = ""
            cn.Open()
            cm = New MySqlCommand("select * from users", cn)
            dr = cm.ExecuteReader

            While dr.Read
                If tboxUsername.Text = dr.Item("username").ToString And tboxPassword.Text = DecryptData(dr.Item("password").ToString) Then
                    found = True
                    strname = dr.Item("username").ToString
                End If
            End While
            dr.Close()
            cn.Close()

            If found = True Then
                MsgBox("Access granted. Welcome" & strname, vbInformation)
            Else
                MsgBox("Access Denied. Invalid Username or Password", vbExclamation)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class