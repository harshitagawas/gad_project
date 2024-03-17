<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        appInfo_pnl = New Panel()
        PictureBox1 = New PictureBox()
        connector_btn = New Button()
        contacts_pnl = New Panel()
        geetika_btn = New Button()
        ayushi_btn = New Button()
        raj_btn = New Button()
        patya_btn = New Button()
        dad_btn = New Button()
        mom_btn = New Button()
        userInfo_pnl = New Panel()
        geetika = New Label()
        ayushi = New Label()
        raj = New Label()
        patya = New Label()
        dad = New Label()
        mom = New Label()
        main_pnl = New Panel()
        connections_pnl = New Panel()
        send_btn = New Button()
        msg_writer = New RichTextBox()
        connect_btn = New Button()
        start_btn = New Button()
        text_area = New RichTextBox()
        client_port_tb = New TextBox()
        client_ip_tb = New TextBox()
        server_port_tb = New TextBox()
        server_ip_tb = New TextBox()
        client_port = New Label()
        client_ip = New Label()
        client = New Label()
        server_port = New Label()
        server_ip = New Label()
        server = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        appInfo_pnl.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        contacts_pnl.SuspendLayout()
        userInfo_pnl.SuspendLayout()
        connections_pnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' appInfo_pnl
        ' 
        appInfo_pnl.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        appInfo_pnl.Controls.Add(PictureBox1)
        appInfo_pnl.Controls.Add(connector_btn)
        appInfo_pnl.Location = New Point(-1, 1)
        appInfo_pnl.Name = "appInfo_pnl"
        appInfo_pnl.Size = New Size(1353, 87)
        appInfo_pnl.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(214, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' connector_btn
        ' 
        connector_btn.BackColor = Color.Red
        connector_btn.FlatAppearance.BorderSize = 0
        connector_btn.FlatStyle = FlatStyle.Popup
        connector_btn.ForeColor = SystemColors.Control
        connector_btn.Location = New Point(1143, 22)
        connector_btn.Name = "connector_btn"
        connector_btn.Size = New Size(176, 44)
        connector_btn.TabIndex = 0
        connector_btn.Text = "CONNECT"
        connector_btn.UseVisualStyleBackColor = False
        ' 
        ' contacts_pnl
        ' 
        contacts_pnl.BackColor = Color.FromArgb(CByte(16), CByte(23), CByte(23))
        contacts_pnl.Controls.Add(geetika_btn)
        contacts_pnl.Controls.Add(ayushi_btn)
        contacts_pnl.Controls.Add(raj_btn)
        contacts_pnl.Controls.Add(patya_btn)
        contacts_pnl.Controls.Add(dad_btn)
        contacts_pnl.Controls.Add(mom_btn)
        contacts_pnl.Location = New Point(-1, 87)
        contacts_pnl.Name = "contacts_pnl"
        contacts_pnl.Size = New Size(356, 910)
        contacts_pnl.TabIndex = 1
        ' 
        ' geetika_btn
        ' 
        geetika_btn.FlatAppearance.BorderSize = 0
        geetika_btn.FlatStyle = FlatStyle.Flat
        geetika_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        geetika_btn.ForeColor = SystemColors.Control
        geetika_btn.Location = New Point(0, 499)
        geetika_btn.Name = "geetika_btn"
        geetika_btn.Size = New Size(351, 93)
        geetika_btn.TabIndex = 4
        geetika_btn.Text = "GEETIKA"
        geetika_btn.UseVisualStyleBackColor = True
        ' 
        ' ayushi_btn
        ' 
        ayushi_btn.FlatAppearance.BorderSize = 0
        ayushi_btn.FlatAppearance.MouseDownBackColor = Color.Black
        ayushi_btn.FlatStyle = FlatStyle.Flat
        ayushi_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ayushi_btn.ForeColor = SystemColors.Control
        ayushi_btn.Location = New Point(0, 400)
        ayushi_btn.Name = "ayushi_btn"
        ayushi_btn.Size = New Size(351, 93)
        ayushi_btn.TabIndex = 2
        ayushi_btn.Text = "AYUSHI"
        ayushi_btn.UseVisualStyleBackColor = True
        ' 
        ' raj_btn
        ' 
        raj_btn.FlatAppearance.BorderSize = 0
        raj_btn.FlatStyle = FlatStyle.Flat
        raj_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        raj_btn.ForeColor = SystemColors.Control
        raj_btn.Location = New Point(0, 301)
        raj_btn.Name = "raj_btn"
        raj_btn.Size = New Size(351, 93)
        raj_btn.TabIndex = 3
        raj_btn.Text = "RAJ"
        raj_btn.UseVisualStyleBackColor = True
        ' 
        ' patya_btn
        ' 
        patya_btn.FlatAppearance.BorderSize = 0
        patya_btn.FlatStyle = FlatStyle.Flat
        patya_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        patya_btn.ForeColor = SystemColors.Control
        patya_btn.Location = New Point(0, 202)
        patya_btn.Name = "patya_btn"
        patya_btn.Size = New Size(351, 93)
        patya_btn.TabIndex = 2
        patya_btn.Text = "PRATHMESH"
        patya_btn.UseVisualStyleBackColor = True
        ' 
        ' dad_btn
        ' 
        dad_btn.FlatAppearance.BorderSize = 0
        dad_btn.FlatStyle = FlatStyle.Flat
        dad_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dad_btn.ForeColor = SystemColors.Control
        dad_btn.Location = New Point(0, 103)
        dad_btn.Name = "dad_btn"
        dad_btn.Size = New Size(351, 93)
        dad_btn.TabIndex = 1
        dad_btn.Text = "DAD"
        dad_btn.UseVisualStyleBackColor = True
        ' 
        ' mom_btn
        ' 
        mom_btn.FlatAppearance.BorderSize = 0
        mom_btn.FlatStyle = FlatStyle.Flat
        mom_btn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mom_btn.ForeColor = SystemColors.Control
        mom_btn.Location = New Point(0, 4)
        mom_btn.Name = "mom_btn"
        mom_btn.Size = New Size(351, 93)
        mom_btn.TabIndex = 0
        mom_btn.Text = "MOM"
        mom_btn.UseVisualStyleBackColor = True
        ' 
        ' userInfo_pnl
        ' 
        userInfo_pnl.BackColor = Color.FromArgb(CByte(16), CByte(23), CByte(32))
        userInfo_pnl.Controls.Add(geetika)
        userInfo_pnl.Controls.Add(ayushi)
        userInfo_pnl.Controls.Add(raj)
        userInfo_pnl.Controls.Add(patya)
        userInfo_pnl.Controls.Add(dad)
        userInfo_pnl.Controls.Add(mom)
        userInfo_pnl.Location = New Point(351, 87)
        userInfo_pnl.Name = "userInfo_pnl"
        userInfo_pnl.Size = New Size(1004, 83)
        userInfo_pnl.TabIndex = 2
        ' 
        ' geetika
        ' 
        geetika.AutoSize = True
        geetika.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        geetika.ForeColor = SystemColors.ButtonHighlight
        geetika.Location = New Point(45, 26)
        geetika.Name = "geetika"
        geetika.Size = New Size(102, 30)
        geetika.TabIndex = 5
        geetika.Text = "GEETIKA"
        ' 
        ' ayushi
        ' 
        ayushi.AutoSize = True
        ayushi.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ayushi.ForeColor = SystemColors.ButtonHighlight
        ayushi.Location = New Point(45, 26)
        ayushi.Name = "ayushi"
        ayushi.Size = New Size(91, 30)
        ayushi.TabIndex = 4
        ayushi.Text = "AYUSHI"
        ' 
        ' raj
        ' 
        raj.AutoSize = True
        raj.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        raj.ForeColor = SystemColors.ButtonHighlight
        raj.Location = New Point(45, 26)
        raj.Name = "raj"
        raj.Size = New Size(53, 30)
        raj.TabIndex = 3
        raj.Text = "RAJ"
        ' 
        ' patya
        ' 
        patya.AutoSize = True
        patya.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        patya.ForeColor = SystemColors.ButtonHighlight
        patya.Location = New Point(45, 26)
        patya.Name = "patya"
        patya.Size = New Size(146, 30)
        patya.TabIndex = 2
        patya.Text = "PRATHMESH"
        patya.Visible = False
        ' 
        ' dad
        ' 
        dad.AutoSize = True
        dad.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dad.ForeColor = SystemColors.ButtonHighlight
        dad.Location = New Point(45, 26)
        dad.Name = "dad"
        dad.Size = New Size(60, 30)
        dad.TabIndex = 1
        dad.Text = "DAD"
        ' 
        ' mom
        ' 
        mom.AutoSize = True
        mom.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mom.ForeColor = SystemColors.ButtonHighlight
        mom.Location = New Point(45, 26)
        mom.Name = "mom"
        mom.Size = New Size(72, 30)
        mom.TabIndex = 0
        mom.Text = "MOM"
        ' 
        ' main_pnl
        ' 
        main_pnl.BackgroundImage = My.Resources.Resources.whatsappbg
        main_pnl.BackgroundImageLayout = ImageLayout.Stretch
        main_pnl.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        main_pnl.Location = New Point(351, 169)
        main_pnl.Name = "main_pnl"
        main_pnl.Size = New Size(1007, 825)
        main_pnl.TabIndex = 3
        ' 
        ' connections_pnl
        ' 
        connections_pnl.Controls.Add(send_btn)
        connections_pnl.Controls.Add(msg_writer)
        connections_pnl.Controls.Add(connect_btn)
        connections_pnl.Controls.Add(start_btn)
        connections_pnl.Controls.Add(text_area)
        connections_pnl.Controls.Add(client_port_tb)
        connections_pnl.Controls.Add(client_ip_tb)
        connections_pnl.Controls.Add(server_port_tb)
        connections_pnl.Controls.Add(server_ip_tb)
        connections_pnl.Controls.Add(client_port)
        connections_pnl.Controls.Add(client_ip)
        connections_pnl.Controls.Add(client)
        connections_pnl.Controls.Add(server_port)
        connections_pnl.Controls.Add(server_ip)
        connections_pnl.Controls.Add(server)
        connections_pnl.Location = New Point(410, 200)
        connections_pnl.Name = "connections_pnl"
        connections_pnl.Size = New Size(877, 762)
        connections_pnl.TabIndex = 0
        ' 
        ' send_btn
        ' 
        send_btn.Location = New Point(746, 692)
        send_btn.Name = "send_btn"
        send_btn.Size = New Size(112, 34)
        send_btn.TabIndex = 14
        send_btn.Text = "SEND"
        send_btn.UseVisualStyleBackColor = True
        ' 
        ' msg_writer
        ' 
        msg_writer.Location = New Point(23, 674)
        msg_writer.Name = "msg_writer"
        msg_writer.Size = New Size(701, 67)
        msg_writer.TabIndex = 13
        msg_writer.Text = ""
        ' 
        ' connect_btn
        ' 
        connect_btn.Location = New Point(542, 195)
        connect_btn.Name = "connect_btn"
        connect_btn.Size = New Size(112, 34)
        connect_btn.TabIndex = 12
        connect_btn.Text = "CONNECT"
        connect_btn.UseVisualStyleBackColor = True
        ' 
        ' start_btn
        ' 
        start_btn.Location = New Point(542, 80)
        start_btn.Name = "start_btn"
        start_btn.Size = New Size(112, 34)
        start_btn.TabIndex = 11
        start_btn.Text = "START"
        start_btn.UseVisualStyleBackColor = True
        ' 
        ' text_area
        ' 
        text_area.Location = New Point(23, 248)
        text_area.Name = "text_area"
        text_area.Size = New Size(835, 408)
        text_area.TabIndex = 10
        text_area.Text = ""
        ' 
        ' client_port_tb
        ' 
        client_port_tb.Location = New Point(318, 200)
        client_port_tb.Name = "client_port_tb"
        client_port_tb.Size = New Size(150, 31)
        client_port_tb.TabIndex = 9
        ' 
        ' client_ip_tb
        ' 
        client_ip_tb.Location = New Point(78, 197)
        client_ip_tb.Name = "client_ip_tb"
        client_ip_tb.Size = New Size(150, 31)
        client_ip_tb.TabIndex = 8
        ' 
        ' server_port_tb
        ' 
        server_port_tb.Location = New Point(318, 83)
        server_port_tb.Name = "server_port_tb"
        server_port_tb.Size = New Size(150, 31)
        server_port_tb.TabIndex = 7
        ' 
        ' server_ip_tb
        ' 
        server_ip_tb.Location = New Point(78, 83)
        server_ip_tb.Name = "server_ip_tb"
        server_ip_tb.Size = New Size(150, 31)
        server_ip_tb.TabIndex = 6
        ' 
        ' client_port
        ' 
        client_port.AutoSize = True
        client_port.Location = New Point(257, 200)
        client_port.Name = "client_port"
        client_port.Size = New Size(55, 25)
        client_port.TabIndex = 5
        client_port.Text = "PORT"
        ' 
        ' client_ip
        ' 
        client_ip.AutoSize = True
        client_ip.Location = New Point(45, 197)
        client_ip.Name = "client_ip"
        client_ip.Size = New Size(27, 25)
        client_ip.TabIndex = 4
        client_ip.Text = "IP"
        ' 
        ' client
        ' 
        client.AutoSize = True
        client.Location = New Point(35, 143)
        client.Name = "client"
        client.Size = New Size(67, 25)
        client.TabIndex = 3
        client.Text = "CLIENT"
        ' 
        ' server_port
        ' 
        server_port.AutoSize = True
        server_port.Location = New Point(257, 89)
        server_port.Name = "server_port"
        server_port.Size = New Size(55, 25)
        server_port.TabIndex = 2
        server_port.Text = "PORT"
        ' 
        ' server_ip
        ' 
        server_ip.AutoSize = True
        server_ip.Location = New Point(45, 89)
        server_ip.Name = "server_ip"
        server_ip.Size = New Size(27, 25)
        server_ip.TabIndex = 1
        server_ip.Text = "IP"
        ' 
        ' server
        ' 
        server.AutoSize = True
        server.Location = New Point(35, 31)
        server.Name = "server"
        server.Size = New Size(73, 25)
        server.TabIndex = 0
        server.Text = "SERVER"
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' BackgroundWorker2
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 993)
        Controls.Add(connections_pnl)
        Controls.Add(main_pnl)
        Controls.Add(userInfo_pnl)
        Controls.Add(contacts_pnl)
        Controls.Add(appInfo_pnl)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        appInfo_pnl.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        contacts_pnl.ResumeLayout(False)
        userInfo_pnl.ResumeLayout(False)
        userInfo_pnl.PerformLayout()
        connections_pnl.ResumeLayout(False)
        connections_pnl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents appInfo_pnl As Panel
    Friend WithEvents contacts_pnl As Panel
    Friend WithEvents userInfo_pnl As Panel
    Friend WithEvents main_pnl As Panel
    Friend WithEvents connector_btn As Button
    Friend WithEvents geetika_btn As Button
    Friend WithEvents ayushi_btn As Button
    Friend WithEvents raj_btn As Button
    Friend WithEvents patya_btn As Button
    Friend WithEvents dad_btn As Button
    Friend WithEvents mom_btn As Button
    Friend WithEvents mom As Label
    Friend WithEvents raj As Label
    Friend WithEvents patya As Label
    Friend WithEvents dad As Label
    Friend WithEvents geetika As Label
    Friend WithEvents ayushi As Label
    Friend WithEvents connections_pnl As Panel
    Friend WithEvents client_port_tb As TextBox
    Friend WithEvents client_ip_tb As TextBox
    Friend WithEvents server_port_tb As TextBox
    Friend WithEvents server_ip_tb As TextBox
    Friend WithEvents client_port As Label
    Friend WithEvents client_ip As Label
    Friend WithEvents client As Label
    Friend WithEvents server_port As Label
    Friend WithEvents server_ip As Label
    Friend WithEvents server As Label
    Friend WithEvents connect_btn As Button
    Friend WithEvents start_btn As Button
    Friend WithEvents text_area As RichTextBox
    Friend WithEvents send_btn As Button
    Friend WithEvents msg_writer As RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox

End Class
