Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        sidebar.Visible = False
        sideBtnClose.Visible = False
        sideBtnHome.Visible = False
        sideBtnProfile.Visible = False
        sideBtnEntries.Visible = False
        sideBtnSettings.Visible = False
        sideBtnLogout.Visible = False
        btnHamburger.Visible = True

    End Sub
    Dim WithEvents aTimer As New System.Windows.Forms.Timer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        lbl_date.Text = DateTime.Now.ToString("MMM dd, yyyy")
        lbl_time.Text = DateTime.Now.ToString("h:mm tt")

    End Sub

    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles MyBase.Shown
        aTimer.Interval = 250
        aTimer.Start()
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

    Private Sub createEntry_MouseDown(sender As Object, e As MouseEventArgs) Handles createEntry.MouseDown
        With createEntry
            .BackgroundImage = My.Resources.big_button_clicked
        End With
    End Sub

    Private Sub createEntry_MouseUp(sender As Object, e As MouseEventArgs) Handles createEntry.MouseUp
        With createEntry
            .BackgroundImage = My.Resources.big_button
        End With
    End Sub

    Private Sub viewEntries_MouseDown(sender As Object, e As MouseEventArgs) Handles viewEntries.MouseDown
        With viewEntries
            .BackgroundImage = My.Resources.big_button_clicked
        End With
    End Sub

    Private Sub viewEntries_MouseUp(sender As Object, e As MouseEventArgs) Handles viewEntries.MouseUp
        With viewEntries
            .BackgroundImage = My.Resources.big_button
        End With
    End Sub

    Private Sub sideBtnClose_Click(sender As Object, e As EventArgs) Handles sideBtnClose.Click
        sidebar.Visible = False
        sideBtnClose.Visible = False
        sideBtnHome.Visible = False
        sideBtnProfile.Visible = False
        sideBtnEntries.Visible = False
        sideBtnSettings.Visible = False
        sideBtnLogout.Visible = False
        btnHamburger.Visible = True
    End Sub

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        sidebar.Visible = True
        sideBtnClose.Visible = True
        sideBtnHome.Visible = True
        sideBtnProfile.Visible = True
        sideBtnEntries.Visible = True
        sideBtnSettings.Visible = True
        sideBtnLogout.Visible = True
        btnHamburger.Visible = False
    End Sub
End Class
