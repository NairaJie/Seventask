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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbTipeKamar = New System.Windows.Forms.ComboBox()
        Me.DTPtransaksi = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdTambah = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdUpdate = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.TbNo = New System.Windows.Forms.TextBox()
        Me.TbNapel = New System.Windows.Forms.TextBox()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        Me.TbLama = New System.Windows.Forms.TextBox()
        Me.TbDiskon = New System.Windows.Forms.TextBox()
        Me.TbTotbay = New System.Windows.Forms.TextBox()
        Me.DgTampil = New System.Windows.Forms.DataGridView()
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pemesanan Hotel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipe Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lama Menginap"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Bayar"
        '
        'CbTipeKamar
        '
        Me.CbTipeKamar.FormattingEnabled = True
        Me.CbTipeKamar.Items.AddRange(New Object() {"Suite", "Deluxe ", "Standart"})
        Me.CbTipeKamar.Location = New System.Drawing.Point(216, 154)
        Me.CbTipeKamar.Name = "CbTipeKamar"
        Me.CbTipeKamar.Size = New System.Drawing.Size(121, 21)
        Me.CbTipeKamar.TabIndex = 8
        '
        'DTPtransaksi
        '
        Me.DTPtransaksi.Location = New System.Drawing.Point(216, 223)
        Me.DTPtransaksi.Name = "DTPtransaksi"
        Me.DTPtransaksi.Size = New System.Drawing.Size(200, 20)
        Me.DTPtransaksi.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Tanggal Transaksi"
        '
        'CmdTambah
        '
        Me.CmdTambah.Location = New System.Drawing.Point(50, 373)
        Me.CmdTambah.Name = "CmdTambah"
        Me.CmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.CmdTambah.TabIndex = 11
        Me.CmdTambah.Text = "Tambah"
        Me.CmdTambah.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(216, 373)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimpan.TabIndex = 12
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Location = New System.Drawing.Point(383, 373)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.CmdUpdate.TabIndex = 13
        Me.CmdUpdate.Text = "Update"
        Me.CmdUpdate.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(542, 373)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 14
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'TbNo
        '
        Me.TbNo.Location = New System.Drawing.Point(216, 83)
        Me.TbNo.Name = "TbNo"
        Me.TbNo.Size = New System.Drawing.Size(121, 20)
        Me.TbNo.TabIndex = 15
        '
        'TbNapel
        '
        Me.TbNapel.Location = New System.Drawing.Point(216, 118)
        Me.TbNapel.Name = "TbNapel"
        Me.TbNapel.Size = New System.Drawing.Size(200, 20)
        Me.TbNapel.TabIndex = 16
        '
        'TbHarga
        '
        Me.TbHarga.Location = New System.Drawing.Point(216, 189)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(200, 20)
        Me.TbHarga.TabIndex = 17
        '
        'TbLama
        '
        Me.TbLama.Location = New System.Drawing.Point(216, 256)
        Me.TbLama.Name = "TbLama"
        Me.TbLama.Size = New System.Drawing.Size(121, 20)
        Me.TbLama.TabIndex = 18
        '
        'TbDiskon
        '
        Me.TbDiskon.Location = New System.Drawing.Point(216, 293)
        Me.TbDiskon.Name = "TbDiskon"
        Me.TbDiskon.Size = New System.Drawing.Size(121, 20)
        Me.TbDiskon.TabIndex = 19
        '
        'TbTotbay
        '
        Me.TbTotbay.Location = New System.Drawing.Point(216, 326)
        Me.TbTotbay.Name = "TbTotbay"
        Me.TbTotbay.Size = New System.Drawing.Size(121, 20)
        Me.TbTotbay.TabIndex = 20
        '
        'DgTampil
        '
        Me.DgTampil.AllowUserToOrderColumns = True
        Me.DgTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgTampil.Location = New System.Drawing.Point(51, 427)
        Me.DgTampil.Name = "DgTampil"
        Me.DgTampil.Size = New System.Drawing.Size(582, 150)
        Me.DgTampil.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.DgTampil)
        Me.Controls.Add(Me.TbTotbay)
        Me.Controls.Add(Me.TbDiskon)
        Me.Controls.Add(Me.TbLama)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.TbNapel)
        Me.Controls.Add(Me.TbNo)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.CmdUpdate)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmdTambah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTPtransaksi)
        Me.Controls.Add(Me.CbTipeKamar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbTipeKamar As ComboBox
    Friend WithEvents DTPtransaksi As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents CmdTambah As Button
    Friend WithEvents CmdSimpan As Button
    Friend WithEvents CmdUpdate As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents TbNo As TextBox
    Friend WithEvents TbNapel As TextBox
    Friend WithEvents TbHarga As TextBox
    Friend WithEvents TbLama As TextBox
    Friend WithEvents TbDiskon As TextBox
    Friend WithEvents TbTotbay As TextBox
    Friend WithEvents DgTampil As DataGridView
End Class
