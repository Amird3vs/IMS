Public Class Form_Alert

    Public Enum enmAction
        wait
        start
        close
    End Enum

    Public Enum enmType
        Success
        Warning
        [Error]
        Info
    End Enum

    Private action As Form_Alert.enmAction

    Private x, y As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case Me.action
            Case enmAction.wait
                Timer1.Interval = 2000
                action = enmAction.close

            Case Form_Alert.enmAction.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If Me.x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1.0 Then
                        action = Form_Alert.enmAction.wait
                    End If
                End If

            Case enmAction.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1

                Me.Left -= 3
                If MyBase.Opacity = 0.0 Then
                    MyBase.Close()
                End If
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Interval = 1
        action = enmAction.close
    End Sub

    Public Sub showAlert(ByVal msg As String, ByVal type As enmType)
        Me.Opacity = 0.0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String

        For i = 1 To 9
            fname = "alert" & i.ToString()
            Dim frm As Form_Alert = CType(Application.OpenForms(fname), Form_Alert)

            If frm Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For

            End If

        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - MyBase.Width - 5

        Select Case type
            Case enmType.Success
                Me.PictureBox1.Image = My.Resources.Success
                Me.BackColor = Color.SeaGreen
            Case enmType.[Error]
                Me.PictureBox1.Image = My.Resources._error
                Me.BackColor = Color.DarkRed
            Case enmType.Info
                Me.PictureBox1.Image = My.Resources.info
                Me.BackColor = Color.RoyalBlue
            Case enmType.Warning
                Me.PictureBox1.Image = My.Resources.warning
                Me.BackColor = Color.DarkOrange
        End Select

        Me.lblMsg.Text = msg

        Me.Show()
        Me.action = enmAction.start
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub
End Class