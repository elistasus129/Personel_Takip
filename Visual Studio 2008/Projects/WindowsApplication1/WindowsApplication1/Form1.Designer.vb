<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YeniÜyelikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ŞifremiUnuttumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProjeHakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TelifHakkıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YardımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ÇıkışToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kullanıcı Girişi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Çıkış"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Giriş"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Üyelik Şifresi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Üyelik Adı:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 69)
        Me.TextBox2.MaximumSize = New System.Drawing.Size(160, 30)
        Me.TextBox2.MinimumSize = New System.Drawing.Size(160, 30)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(160, 30)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 28)
        Me.TextBox1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(252, 35)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Şifremi Unuttum"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(252, 37)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Yeni Üyelik"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.HakkındaToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniÜyelikToolStripMenuItem, Me.ŞifremiUnuttumToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'YeniÜyelikToolStripMenuItem
        '
        Me.YeniÜyelikToolStripMenuItem.Name = "YeniÜyelikToolStripMenuItem"
        Me.YeniÜyelikToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.YeniÜyelikToolStripMenuItem.Text = "Yeni Üyelik"
        '
        'ŞifremiUnuttumToolStripMenuItem
        '
        Me.ŞifremiUnuttumToolStripMenuItem.Name = "ŞifremiUnuttumToolStripMenuItem"
        Me.ŞifremiUnuttumToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.ŞifremiUnuttumToolStripMenuItem.Text = "Şifremi Unuttum"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjeHakkındaToolStripMenuItem, Me.TelifHakkıToolStripMenuItem, Me.YardımToolStripMenuItem})
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.HakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'ProjeHakkındaToolStripMenuItem
        '
        Me.ProjeHakkındaToolStripMenuItem.Name = "ProjeHakkındaToolStripMenuItem"
        Me.ProjeHakkındaToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.ProjeHakkındaToolStripMenuItem.Text = "Proje Hakkında"
        '
        'TelifHakkıToolStripMenuItem
        '
        Me.TelifHakkıToolStripMenuItem.Name = "TelifHakkıToolStripMenuItem"
        Me.TelifHakkıToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.TelifHakkıToolStripMenuItem.Text = "Telif Hakkı"
        '
        'YardımToolStripMenuItem
        '
        Me.YardımToolStripMenuItem.Name = "YardımToolStripMenuItem"
        Me.YardımToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.YardımToolStripMenuItem.Text = "Yardım"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem1})
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'ÇıkışToolStripMenuItem1
        '
        Me.ÇıkışToolStripMenuItem1.Name = "ÇıkışToolStripMenuItem1"
        Me.ÇıkışToolStripMenuItem1.Size = New System.Drawing.Size(108, 24)
        Me.ÇıkışToolStripMenuItem1.Text = "Çıkış"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 357)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(323, 404)
        Me.MinimumSize = New System.Drawing.Size(323, 404)
        Me.Name = "Form1"
        Me.Text = "Giriş Paneli"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniÜyelikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ŞifremiUnuttumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjeHakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelifHakkıToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YardımToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
