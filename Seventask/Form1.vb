Imports MySql.Data.MySqlClient
Public Class Form1

    Dim strkon As String = "server=localhost;uid=root;database=datahotel_22"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Dim harga, total, diskon As Double

    Sub tidakaktif()
        TbNo.Enabled = False
        TbNapel.Enabled = False
        CbTipeKamar.Enabled = False
        TbHarga.Enabled = False
        DTPtransaksi.Enabled = False
        TbLama.Enabled = False
        TbDiskon.Enabled = False
        TbTotbay.Enabled = False

        TbNo.BackColor = Color.Gray
        TbNapel.BackColor = Color.Gray
        CbTipeKamar.BackColor = Color.Gray
        TbHarga.BackColor = Color.Gray
        DTPtransaksi.BackColor = Color.Gray
        TbLama.BackColor = Color.Gray
        TbDiskon.BackColor = Color.Gray
        TbTotbay.BackColor = Color.Gray


        CmdSimpan.Enabled = False
        CmdUpdate.Enabled = False
    End Sub

    Sub aktif()
        TbNo.Enabled = True
        TbNapel.Enabled = True
        CbTipeKamar.Enabled = True
        TbHarga.Enabled = True
        DTPtransaksi.Enabled = True
        TbLama.Enabled = True
        TbDiskon.Enabled = True
        TbTotbay.Enabled = True

        TbNo.BackColor = Color.White
        TbNapel.BackColor = Color.White
        CbTipeKamar.BackColor = Color.White
        TbHarga.BackColor = Color.White
        DTPtransaksi.BackColor = Color.White
        TbLama.BackColor = Color.White
        TbDiskon.BackColor = Color.White
        TbTotbay.BackColor = Color.White


        CmdSimpan.Enabled = True
        CmdUpdate.Enabled = True

    End Sub

    Sub bersih()
        TbNo.Text = ""
        TbNapel.Text = ""
        CbTipeKamar.Text = ""
        TbHarga.Text = ""
        DTPtransaksi.Text = ""
        TbLama.Text = ""
        TbDiskon.Text = ""
        TbTotbay.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from data"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        DgTampil.DataSource = ds.Tables("data")
        kon.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub TbNo_TextChanged(sender As Object, e As KeyEventArgs) Handles TbNo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from data " &
                " where Id='" & TbNapel.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "Pesan")
                If cek.HasRows Then
                    TbNapel.Text = cek.Item("NamaPelanggan")
                    CbTipeKamar.Text = cek.Item("TipeKamar")
                    TbHarga.Text = cek.Item("Harga")
                    DTPtransaksi.Value = cek.Item("TanggalTransaksi")
                    TbLama.Text = cek.Item("Lama")
                    TbDiskon.Text = cek.Item("Diskon")
                    TbTotbay.Text = cek.Item("Total")
                    CmdSimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                CmdTambah.Enabled = True
        End Select
    End Sub

    Private Sub CmdTambah_Click(sender As Object, e As EventArgs) Handles CmdTambah.Click
        aktif()
        TbNo.Focus()
        CmdTambah.Enabled = False
    End Sub

    Private Sub CmdSimpan_Click(sender As Object, e As EventArgs) Handles CmdSimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into data values " &
        " ('" & TbNo.Text & "', '" & TbNapel.Text & "', " &
        " '" & CbTipeKamar.Text & "', '" & harga & "', " &
        " '" & Format(DTPtransaksi.Value, "yyyy-MM-dd") & "', " &
        " '" & TbLama.Text & "', '" & diskon & "', ' " & total & " ')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        CmdTambah.Enabled = True
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "Update data set NamaPelanggan =  '" & TbNapel.Text & "' ,
        TipeKamar = '" & CbTipeKamar.Text & "', Harga = '" & harga & "',
        TanggalTransaksi = '" & Format(DTPtransaksi.Value, "yyyy-MM-dd") & "',
        Lama = '" & TbLama.Text & "', Diskon = '" & diskon & "',
        Total  = '" & total & "' where NoTransaksi ='" & TbNo.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub TbLama_TextChanged(sender As Object, e As EventArgs) Handles TbLama.TextChanged
        If Val(TbLama.Text) > 3 Then
            diskon = harga * 10 / 100
        Else
            diskon = 0
        End If
        TbDiskon.Text = Format(diskon, "Rp ###,###,##")
        total = harga * Val(TbLama.Text) - diskon
        TbTotbay.Text = Format(total, "Rp ###,###,##")
    End Sub

    Private Sub CbTipeKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipeKamar.SelectedIndexChanged
        Select Case CbTipeKamar.SelectedIndex
            Case 0
                harga = 1000000
            Case 1
                harga = 700000
            Case 2
                harga = 500000
        End Select
        TbHarga.Text = Format(harga, "Rp ###,###,##")

    End Sub
End Class
