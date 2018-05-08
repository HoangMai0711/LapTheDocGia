<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapThe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapThe))
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbLoaiDocGia = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNgayLapThe = New System.Windows.Forms.Label()
        Me.lbNguoiLapThe = New System.Windows.Forms.Label()
        Me.tbHoTen = New System.Windows.Forms.TextBox()
        Me.cbxLoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.tbNguoiLapThe = New System.Windows.Forms.TextBox()
        Me.bttNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Location = New System.Drawing.Point(125, 83)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(65, 20)
        Me.lbHoTen.TabIndex = 0
        Me.lbHoTen.Text = "Họ Tên:"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(124, 248)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(64, 20)
        Me.lbDiaChi.TabIndex = 1
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(124, 191)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(85, 20)
        Me.lbNgaySinh.TabIndex = 2
        Me.lbNgaySinh.Text = "Ngày Sinh:"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(123, 138)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(105, 20)
        Me.lbLoaiDocGia.TabIndex = 3
        Me.lbLoaiDocGia.Text = "Loại Độc Giả:"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(124, 302)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(52, 20)
        Me.lbEmail.TabIndex = 4
        Me.lbEmail.Text = "Email:"
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.Location = New System.Drawing.Point(124, 357)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(111, 20)
        Me.lbNgayLapThe.TabIndex = 5
        Me.lbNgayLapThe.Text = "Ngày Lập Thẻ:"
        '
        'lbNguoiLapThe
        '
        Me.lbNguoiLapThe.AutoSize = True
        Me.lbNguoiLapThe.Location = New System.Drawing.Point(124, 414)
        Me.lbNguoiLapThe.Name = "lbNguoiLapThe"
        Me.lbNguoiLapThe.Size = New System.Drawing.Size(116, 20)
        Me.lbNguoiLapThe.TabIndex = 6
        Me.lbNguoiLapThe.Text = "Người Lập Thẻ:"
        '
        'tbHoTen
        '
        Me.tbHoTen.Location = New System.Drawing.Point(288, 77)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(411, 26)
        Me.tbHoTen.TabIndex = 7
        '
        'cbxLoaiDocGia
        '
        Me.cbxLoaiDocGia.FormattingEnabled = True
        Me.cbxLoaiDocGia.Items.AddRange(New Object() {"X", "Y"})
        Me.cbxLoaiDocGia.Location = New System.Drawing.Point(288, 130)
        Me.cbxLoaiDocGia.Name = "cbxLoaiDocGia"
        Me.cbxLoaiDocGia.Size = New System.Drawing.Size(121, 28)
        Me.cbxLoaiDocGia.TabIndex = 8
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(288, 185)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(316, 26)
        Me.dtpNgaySinh.TabIndex = 9
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(288, 242)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(411, 26)
        Me.tbDiaChi.TabIndex = 10
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(288, 296)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(411, 26)
        Me.tbEmail.TabIndex = 11
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(288, 351)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(316, 26)
        Me.dtpNgayLapThe.TabIndex = 12
        '
        'tbNguoiLapThe
        '
        Me.tbNguoiLapThe.Location = New System.Drawing.Point(288, 408)
        Me.tbNguoiLapThe.Name = "tbNguoiLapThe"
        Me.tbNguoiLapThe.Size = New System.Drawing.Size(411, 26)
        Me.tbNguoiLapThe.TabIndex = 13
        '
        'bttNhap
        '
        Me.bttNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttNhap.Location = New System.Drawing.Point(348, 501)
        Me.bttNhap.Name = "bttNhap"
        Me.bttNhap.Size = New System.Drawing.Size(161, 43)
        Me.bttNhap.TabIndex = 14
        Me.bttNhap.Text = "Nhập"
        Me.bttNhap.UseVisualStyleBackColor = True
        '
        'frmLapThe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 582)
        Me.Controls.Add(Me.bttNhap)
        Me.Controls.Add(Me.tbNguoiLapThe)
        Me.Controls.Add(Me.dtpNgayLapThe)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.cbxLoaiDocGia)
        Me.Controls.Add(Me.tbHoTen)
        Me.Controls.Add(Me.lbNguoiLapThe)
        Me.Controls.Add(Me.lbNgayLapThe)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbLoaiDocGia)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbHoTen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLapThe"
        Me.Text = "Lập Thẻ Độc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbLoaiDocGia As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbNgayLapThe As Label
    Friend WithEvents lbNguoiLapThe As Label
    Friend WithEvents tbHoTen As TextBox
    Friend WithEvents cbxLoaiDocGia As ComboBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents tbNguoiLapThe As TextBox
    Friend WithEvents bttNhap As Button
End Class
