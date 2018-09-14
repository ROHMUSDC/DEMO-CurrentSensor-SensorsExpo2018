Public Class Form1

    Inherits System.Windows.Forms.Form
    Dim WithEvents serialPort As New IO.Ports.SerialPort

    Dim Q As Queue(Of String) = New Queue(Of String)


    Dim rxData As Byte
    Dim txComplete As Boolean
    Dim repeat As Integer
    Dim indata As String
    Dim starting_time As String
    Dim ending_time As String
    Dim start_time As New DateTime
    Dim end_time As New DateTime
    Dim loop_saved As Integer
    Dim bytes_sent As Integer
    Dim looping As Boolean
    Dim Data As Integer
    Dim returnStr As String = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To _
            My.Computer.Ports.SerialPortNames.Count - 1
            cbbCOMPorts.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
        cmdDisconnect.Enabled = False
        looping = False

        txComplete = True

    End Sub

    Private Sub DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived




        Dim incoming As String = serialPort.ReadLine()

        returnStr = incoming '& vbCrLf



        ' UpdateBar(returnStr)

        'Q.Enqueue(serialPort.ReadExisting())
        'indata = Q.Dequeue

        SetText(returnStr)

    End Sub
    Delegate Sub SetTextCallback(newString As String)

    Private Sub SetText(ByVal newString As String)
        Dim Data As Double
        Dim Data_Full As Integer
        Dim sChars As String = " "

        Dim incoming As String

        incoming = newString

        If Me.txtReceive.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {newString})
        Else

            Me.txtReceive.Text = Me.txtReceive.Text + newString

            Me.txtReceive.ScrollToCaret()

            If incoming.Length <= 5 Then
                incoming = incoming.Trim()
                Data = Convert.ToInt32(incoming, 16)
                Data_Full = Data

                If Data > 65000 Then Data = 0

                Data = Data / 125
                If Data > 35 Then Data = 35
                If Data < 20 Then Me.cBar.ProgressColor = Color.Green
                If Data >= 20 And Data < 30 Then Me.cBar.ProgressColor = Color.Yellow
                If Data >= 30 Then Me.cBar.ProgressColor = Color.Red

                Me.cBar.Value = Data
                Data = Decimal.Round(Data, 2, MidpointRounding.AwayFromZero)
                Me.cBar.Text = Data

                Data_Full = Data_Full / 125
                If Data_Full > 65 Then Data_Full = 65
                Me.cbarFullRange.Value = Data_Full

            End If


        End If
    End Sub
    Private Sub UpdateBar(ByVal newString As String)

        Data = System.Convert.ToDecimal(newString)
        Data = Data / 125
        cBar.Value = Data

    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        If serialPort.IsOpen Then
            serialPort.Close()
        End If
        Try
            With serialPort
                .PortName = cbbCOMPorts.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                ' .ReadBufferSize = 2
                ' .Encoding = System.Text.Encoding.Unicode
            End With

            serialPort.Open()

            lblMessage.Text = cbbCOMPorts.Text & " connected."
            cmdConnect.Enabled = False
            cmdDisconnect.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisconnect.Click
        Try
            serialPort.Close()
            lblMessage.Text = serialPort.PortName & " disconnected."
            cmdConnect.Enabled = True
            cmdDisconnect.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub cmdClearReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearReceive.Click
        txtReceive.Clear()

    End Sub


    Private Sub lblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub
End Class
