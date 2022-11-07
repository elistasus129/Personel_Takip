<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GezintiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.İlkKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ÖncekiKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SonrakiKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SonKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SilVeVazgeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VazgeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaasSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YeniKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ZamanıBaşlatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ZamanıDurdurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AktarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.İlişkiTabloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.İlişkiTabloAçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeriDönToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeriDönToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.GezintiToolStripMenuItem, Me.SilVeVazgeçToolStripMenuItem, Me.MaasSToolStripMenuItem, Me.İlişkiTabloToolStripMenuItem, Me.GeriDönToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1160, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'GezintiToolStripMenuItem
        '
        Me.GezintiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.İlkKayıtToolStripMenuItem, Me.ÖncekiKayıtToolStripMenuItem, Me.SonrakiKayıtToolStripMenuItem, Me.SonKayıtToolStripMenuItem})
        Me.GezintiToolStripMenuItem.Name = "GezintiToolStripMenuItem"
        Me.GezintiToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.GezintiToolStripMenuItem.Text = "Gezinti"
        '
        'İlkKayıtToolStripMenuItem
        '
        Me.İlkKayıtToolStripMenuItem.Name = "İlkKayıtToolStripMenuItem"
        Me.İlkKayıtToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.İlkKayıtToolStripMenuItem.Text = "İlk Kayıt"
        '
        'ÖncekiKayıtToolStripMenuItem
        '
        Me.ÖncekiKayıtToolStripMenuItem.Name = "ÖncekiKayıtToolStripMenuItem"
        Me.ÖncekiKayıtToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.ÖncekiKayıtToolStripMenuItem.Text = "Önceki Kayıt"
        '
        'SonrakiKayıtToolStripMenuItem
        '
        Me.SonrakiKayıtToolStripMenuItem.Name = "SonrakiKayıtToolStripMenuItem"
        Me.SonrakiKayıtToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.SonrakiKayıtToolStripMenuItem.Text = "Sonraki Kayıt"
        '
        'SonKayıtToolStripMenuItem
        '
        Me.SonKayıtToolStripMenuItem.Name = "SonKayıtToolStripMenuItem"
        Me.SonKayıtToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.SonKayıtToolStripMenuItem.Text = "Son Kayıt"
        '
        'SilVeVazgeçToolStripMenuItem
        '
        Me.SilVeVazgeçToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem, Me.VazgeçToolStripMenuItem})
        Me.SilVeVazgeçToolStripMenuItem.Name = "SilVeVazgeçToolStripMenuItem"
        Me.SilVeVazgeçToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.SilVeVazgeçToolStripMenuItem.Text = "Sil ve Vazgeç"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'VazgeçToolStripMenuItem
        '
        Me.VazgeçToolStripMenuItem.Name = "VazgeçToolStripMenuItem"
        Me.VazgeçToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.VazgeçToolStripMenuItem.Text = "Vazgeç"
        '
        'MaasSToolStripMenuItem
        '
        Me.MaasSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniKayıtToolStripMenuItem, Me.ZamanıBaşlatToolStripMenuItem, Me.ZamanıDurdurToolStripMenuItem, Me.AktarToolStripMenuItem, Me.KaydetToolStripMenuItem})
        Me.MaasSToolStripMenuItem.Name = "MaasSToolStripMenuItem"
        Me.MaasSToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.MaasSToolStripMenuItem.Text = "Maas Süresi"
        '
        'YeniKayıtToolStripMenuItem
        '
        Me.YeniKayıtToolStripMenuItem.Name = "YeniKayıtToolStripMenuItem"
        Me.YeniKayıtToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.YeniKayıtToolStripMenuItem.Text = "Yeni Kayıt"
        '
        'ZamanıBaşlatToolStripMenuItem
        '
        Me.ZamanıBaşlatToolStripMenuItem.Name = "ZamanıBaşlatToolStripMenuItem"
        Me.ZamanıBaşlatToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.ZamanıBaşlatToolStripMenuItem.Text = "Zamanı Başlat"
        '
        'ZamanıDurdurToolStripMenuItem
        '
        Me.ZamanıDurdurToolStripMenuItem.Name = "ZamanıDurdurToolStripMenuItem"
        Me.ZamanıDurdurToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.ZamanıDurdurToolStripMenuItem.Text = "Zamanı Durdur"
        '
        'AktarToolStripMenuItem
        '
        Me.AktarToolStripMenuItem.Name = "AktarToolStripMenuItem"
        Me.AktarToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.AktarToolStripMenuItem.Text = "Aktar"
        '
        'KaydetToolStripMenuItem
        '
        Me.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem"
        Me.KaydetToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.KaydetToolStripMenuItem.Text = "Kaydet"
        '
        'İlişkiTabloToolStripMenuItem
        '
        Me.İlişkiTabloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.İlişkiTabloAçToolStripMenuItem})
        Me.İlişkiTabloToolStripMenuItem.Name = "İlişkiTabloToolStripMenuItem"
        Me.İlişkiTabloToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.İlişkiTabloToolStripMenuItem.Text = "İlişki Tablo"
        '
        'İlişkiTabloAçToolStripMenuItem
        '
        Me.İlişkiTabloAçToolStripMenuItem.Name = "İlişkiTabloAçToolStripMenuItem"
        Me.İlişkiTabloAçToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.İlişkiTabloAçToolStripMenuItem.Text = "İlişki Tablo Aç"
        '
        'GeriDönToolStripMenuItem
        '
        Me.GeriDönToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeriDönToolStripMenuItem1, Me.ÇıkışToolStripMenuItem})
        Me.GeriDönToolStripMenuItem.Name = "GeriDönToolStripMenuItem"
        Me.GeriDönToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.GeriDönToolStripMenuItem.Text = "Geri Dön"
        '
        'GeriDönToolStripMenuItem1
        '
        Me.GeriDönToolStripMenuItem1.Name = "GeriDönToolStripMenuItem1"
        Me.GeriDönToolStripMenuItem1.Size = New System.Drawing.Size(137, 24)
        Me.GeriDönToolStripMenuItem1.Text = "Geri Dön"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 398)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Süre Kayıt"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(117, 340)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 37)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Kaydet"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(14, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 37)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Aktar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 37)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Yeni Kayıt"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(228, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 48)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Zamanı Durdur"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Zamanı Başlat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(170, 243)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(137, 22)
        Me.TextBox6.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(170, 198)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 22)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(170, 150)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(170, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(170, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Çalışılmayan Saniye:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Çalışılmayan Dakika:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Çalışılmayan Saat:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gün Sayısı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tarih:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel No:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(333, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(812, 285)
        Me.DataGridView1.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(333, 327)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 34)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "İlk Kayıt"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(431, 327)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 34)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Önceki Kayıt"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(546, 327)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(116, 34)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Sonraki Kayıt"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(668, 327)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 34)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Son Kayıt"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(821, 327)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(115, 34)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Sil"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(942, 326)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(182, 35)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "Yapılan İşlemden Vazgeç"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 439)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 175)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maaş Hesaplama"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(143, 124)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(144, 28)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "Kaydet"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(135, 79)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(152, 22)
        Me.TextBox8.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(135, 26)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(152, 22)
        Me.TextBox7.TabIndex = 4
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(7, 124)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(122, 28)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "Maaşı Hesapla"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cezalı Maas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Personel No:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1160, 616)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeriDönToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents GezintiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents İlkKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖncekiKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonrakiKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilVeVazgeçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VazgeçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaasSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZamanıBaşlatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZamanıDurdurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GeriDönToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents İlişkiTabloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents İlişkiTabloAçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
