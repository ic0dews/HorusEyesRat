﻿Imports PacketLib.Packet
Public Class RD_Form
    Public isOK As Boolean = False
    <Obsolete>
    Public V As New Threading.Thread(Sub() J())

    <Obsolete>
    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        V.Suspend()
        Me.Hide()
    End Sub
    <Obsolete>
    Private Sub RemoteDesktop_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        isOK = True
        Try
            V.IsBackground = True
            V.Start()
        Catch ex As Exception
            V.Resume()
        End Try
    End Sub
    Private Sub RemoteDesktop_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        isOK = False
    End Sub
    Private Sub RD_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = ComboBox1.Items(10)
        ComboBox2.SelectedItem = ComboBox2.Items(0)
        isOK = True
    End Sub
    <Obsolete>
    Public Sub J()
        isOK = True
        While isOK = True
            '.Plugin = Plugins._RD,
            Dim packet As New PacketMaker With {
            .Function_Params = New Object() {PictureBox1.Width.ToString, PictureBox1.Height.ToString, ComboBox1.Text, ComboBox2.Text},
                .Type_Packet = PacketType.RD
                }
            For Each C As Clients In Form1.L
                If C.ID = Label1.Text Then
                    Task.Run(Sub() Helpers.Sender(C, packet))
                End If
            Next
            Threading.Thread.Sleep(NumericUpDown1.Value)
            If isOK = False Then
                V.Suspend()
            End If
        End While
    End Sub

End Class