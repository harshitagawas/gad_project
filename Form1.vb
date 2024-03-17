Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Public Class Form1

    Private client_var As TcpClient
    Public STR As StreamReader
    Public STW As StreamWriter
    Public receive As String
    Public TextToSend As String

    Public Sub New()
        InitializeComponent()
        connections_pnl.Visible = False
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)

        For Each address As IPAddress In localIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                server_ip_tb.Text = address.ToString()
            End If
        Next
    End Sub



    Private Sub mom_btn_Click(sender As Object, e As EventArgs) Handles mom_btn.Click
        mom.Visible = True
        dad.Visible = False
        patya.Visible = False
        raj.Visible = False
        ayushi.Visible = False
        geetika.Visible = False
    End Sub

    Private Sub dad_btn_Click(sender As Object, e As EventArgs) Handles dad_btn.Click
        mom.Visible = False
        dad.Visible = True
        patya.Visible = False
        raj.Visible = False
        ayushi.Visible = False
        geetika.Visible = False
    End Sub

    Private Sub patya_btn_Click(sender As Object, e As EventArgs) Handles patya_btn.Click
        mom.Visible = False
        dad.Visible = False
        patya.Visible = True
        raj.Visible = False
        ayushi.Visible = False
        geetika.Visible = False
    End Sub

    Private Sub raj_btn_Click(sender As Object, e As EventArgs) Handles raj_btn.Click
        mom.Visible = False
        dad.Visible = False
        patya.Visible = False
        raj.Visible = True
        ayushi.Visible = False
        geetika.Visible = False
    End Sub

    Private Sub ayushi_btn_Click(sender As Object, e As EventArgs) Handles ayushi_btn.Click
        mom.Visible = False
        dad.Visible = False
        patya.Visible = False
        raj.Visible = False
        ayushi.Visible = True
        geetika.Visible = False
    End Sub

    Private Sub geetika_btn_Click(sender As Object, e As EventArgs) Handles geetika_btn.Click
        mom.Visible = False
        dad.Visible = False
        patya.Visible = False
        raj.Visible = False
        ayushi.Visible = False
        geetika.Visible = True
    End Sub

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Dim listener As New TcpListener(IPAddress.Any, Integer.Parse(server_port_tb.Text))
        listener.Start()
        client_var = listener.AcceptTcpClient()
        STR = New StreamReader(client_var.GetStream())
        STW = New StreamWriter(client_var.GetStream())
        STW.AutoFlush = True

        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.WorkerSupportsCancellation = True
    End Sub

    Private Sub connect_btn_Click(sender As Object, e As EventArgs) Handles connect_btn.Click
        client_var = New TcpClient()
        Dim IpEnd As New IPEndPoint(IPAddress.Parse(client_ip_tb.Text), Integer.Parse(client_port_tb.Text))
        Try
            client_var.Connect(IpEnd)

            If (client_var.Connected) Then
                text_area.AppendText("Connected to Server " + Environment.NewLine)
                STW = New StreamWriter(client_var.GetStream())
                STR = New StreamReader(client_var.GetStream())
                STW.AutoFlush = True
                BackgroundWorker1.RunWorkerAsync()
                BackgroundWorker2.WorkerSupportsCancellation = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While (client_var.Connected)
            Try
                receive = STR.ReadLine
                Me.text_area.Invoke(New MethodInvoker(Function()
                                                          text_area.AppendText("You: " + receive + Environment.NewLine)
                                                      End Function))
                receive = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End While
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (client_var.Connected) Then
            STW.WriteLine(TextToSend)
            Me.text_area.Invoke(New MethodInvoker(Function()
                                                      text_area.AppendText("Me: " + TextToSend + Environment.NewLine)
                                                  End Function))
        Else
            MessageBox.Show("Sending Failed")
        End If
        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub send_btn_Click(sender As Object, e As EventArgs) Handles send_btn.Click
        If (msg_writer.Text <> "") Then
            TextToSend = msg_writer.Text
            BackgroundWorker2.RunWorkerAsync()
        End If
        msg_writer.Text = ""
    End Sub

    Private Sub connector_btn_Click(sender As Object, e As EventArgs) Handles connector_btn.Click
        connections_pnl.Visible = True
    End Sub


End Class

