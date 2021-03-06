
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaCN] [int] NOT NULL,
	[TenCN] [char](50) NULL,
	[TenQuan_CN] [char](50) NULL,
	[TenDuong_CN] [char](50) NULL,
	[KhuVuc_CN] [char](50) NULL,
	[SDT_CN] [char](11) NULL,
	[Fax] [char](11) NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuNha]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuNha](
	[MaChuNha] [int] NOT NULL,
	[TenChuNha] [char](50) NULL,
	[DiaChi_ChuNha] [char](100) NULL,
	[SDT_ChuNha] [char](11) NULL,
	[username] [char](50) NULL,
	[password] [char](50) NULL,
 CONSTRAINT [PK_ChuNha] PRIMARY KEY CLUSTERED 
(
	[MaChuNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDongThue]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongThue](
	[MaHopDong] [int] NOT NULL,
	[MaNha] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK_HopDongThue] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC,
	[MaNha] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [char](50) NULL,
	[DiaChiKH] [char](100) NULL,
	[SDT_KH] [char](11) NULL,
	[MaNV] [int] NULL,
	[username] [char](50) NULL,
	[password] [char](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNha]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNha](
	[MaLoaiNha] [int] NOT NULL,
	[LoaiNha] [char](50) NULL,
 CONSTRAINT [PK_LoaiNha] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LSDangNha]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LSDangNha](
	[MaNha] [int] NOT NULL,
	[STT] [int] NOT NULL,
	[NgayDang] [date] NULL,
	[NgayHetHan] [date] NULL,
 CONSTRAINT [PK_LSDangNha] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC,
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LSXemNha]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LSXemNha](
	[MaNha] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayXemNha] [date] NULL,
	[NhanXet] [char](100) NULL,
 CONSTRAINT [PK_LSXemNha] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha](
	[MaNha] [int] NOT NULL,
	[TenDuong_Nha] [char](50) NULL,
	[TenQuan_Nha] [char](50) NULL,
	[TenThanhPho_Nha] [char](50) NULL,
	[KhuVuc_Nha] [char](50) NULL,
	[SL_Phong] [int] NULL,
	[TinhTrang] [char](50) NULL,
	[SoLuotXem] [int] NULL,
	[MaChuNha] [int] NULL,
	[MaNV] [int] NULL,
	[MaLoaiNha] [int] NULL,
 CONSTRAINT [PK_Nha] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaBan]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaBan](
	[MaNha] [int] NOT NULL,
	[GiaBan] [float] NULL,
	[DieuKienChuNha] [char](100) NULL,
 CONSTRAINT [PK_NhaBan] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[MaCN] [int] NULL,
	[TenNV] [char](50) NULL,
	[DiaChiNV] [char](100) NULL,
	[SDT_NV] [char](11) NULL,
	[GioiTinhNV] [bit] NULL,
	[NgaySinh] [date] NULL,
	[Luong] [float] NULL,
	[CurrentFlag] [bit] NULL,
	[username] [char](50) NULL,
	[password] [char](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaThue]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaThue](
	[MaNha] [int] NOT NULL,
	[TienThueThang] [float] NULL,
 CONSTRAINT [PK_NhaThue] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauKhachHang]    Script Date: 1/6/2021 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauKhachHang](
	[MaPhieu] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[LoaiNha] [char](50) NULL,
	[TieuChi] [char](100) NULL,
 CONSTRAINT [PK_YeuCauKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (1, N'HCMUS                                             ', N'ABC                                               ', N'DE                                                ', N'Quan 9                                            ', N'0986189658 ', N'0102345    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (2, N'Binh Thanh                                        ', N'Binh Thanh                                        ', N'Xo Viet                                           ', N'TPHCM                                             ', N'0964689617 ', N'0163846    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (3, N'Tan Phu                                           ', N'Tan Phu                                           ', N'CMT8                                              ', N'tphcm                                             ', N'0946752164 ', N'0874567    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (4, N'Quan 5                                            ', N'5                                                 ', N'Nguyen Van Cu                                     ', N'TPHCM                                             ', N'0875345678 ', N'0123456    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (5, N'Tan Binh                                          ', N'Tan Binh                                          ', N'Bach Dang                                         ', N'TPHCM                                             ', N'0456787423 ', N'0123456    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (6, N'Go Vap                                            ', N'Go Vap                                            ', N'Tran Hung Dao                                     ', N'TPHCM                                             ', N'0912578765 ', N'0145643    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (7, N'Quan 6                                            ', N'6                                                 ', N'Hai Ba Trung                                      ', N'TPHCM                                             ', N'9456789133 ', N'0345670    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (8, N'Quan 1                                            ', N'1                                                 ', N'Pastuer                                           ', N'TPHCM                                             ', N'0451390731 ', N'0462131    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (9, N'Binh Tan                                          ', N'Binh Tan                                          ', N'Tan Ki Tan Quy                                    ', N'TPHCM                                             ', N'0461863811 ', N'0813711    ')
INSERT [dbo].[ChiNhanh] ([MaCN], [TenCN], [TenQuan_CN], [TenDuong_CN], [KhuVuc_CN], [SDT_CN], [Fax]) VALUES (10, N'Thu Duc                                           ', N'Thu Duc                                           ', N'Vo Van Ngan                                       ', N'TPHCM                                             ', N'0471282719 ', N'0856173    ')
GO
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (1, N'Hoa                                               ', N'TPHCM                                                                                               ', N'09136139876', N'cna                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (2, N'Ngan                                              ', N'Binh Duong                                                                                          ', N'05631867311', N'cnb                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (3, N'Thanh                                             ', N'TPHCM                                                                                               ', N'09862318901', N'cnc                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (4, N'Thai                                              ', N'Binh Duong                                                                                          ', N'09127839011', N'cnd                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (5, N'Vy                                                ', N'TPHCM                                                                                               ', N'09143678311', N'cne                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (6, N'Van                                               ', N'Dong Nai                                                                                            ', N'04567813134', N'cnf                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (7, N'Viet                                              ', N'TPHCM                                                                                               ', N'02345678131', N'cng                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (8, N'Tham                                              ', N'TPHCM                                                                                               ', N'03456173214', N'cnh                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (9, N'Thuy                                              ', N'Dong Nai                                                                                            ', N'04678332511', N'cni                                               ', N'123                                               ')
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [DiaChi_ChuNha], [SDT_ChuNha], [username], [password]) VALUES (10, N'Tran                                              ', N'Binh Duong                                                                                          ', N'06714572464', N'cnj                                               ', N'123                                               ')
GO
INSERT [dbo].[HopDongThue] ([MaHopDong], [MaNha], [MaKH], [NgayBatDau], [NgayKetThuc]) VALUES (1, 1, 1, CAST(N'2020-07-12' AS Date), CAST(N'2020-08-12' AS Date))
INSERT [dbo].[HopDongThue] ([MaHopDong], [MaNha], [MaKH], [NgayBatDau], [NgayKetThuc]) VALUES (2, 4, 2, CAST(N'2019-03-12' AS Date), CAST(N'2020-09-12' AS Date))
INSERT [dbo].[HopDongThue] ([MaHopDong], [MaNha], [MaKH], [NgayBatDau], [NgayKetThuc]) VALUES (3, 5, 4, CAST(N'2020-12-12' AS Date), CAST(N'2021-01-12' AS Date))
INSERT [dbo].[HopDongThue] ([MaHopDong], [MaNha], [MaKH], [NgayBatDau], [NgayKetThuc]) VALUES (4, 10, 2, CAST(N'2020-12-10' AS Date), CAST(N'2021-12-10' AS Date))
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (1, N'Ngoc                                              ', N'Thu Duc                                                                                             ', N'0912384711 ', 1, N'kha                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (2, N'Nga                                               ', N'Binh Duong                                                                                          ', N'0914631341 ', 2, N'khb                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (3, N'Thuan                                             ', N'TPHCM                                                                                               ', N'0463145515 ', 1, N'khc                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (4, N'Thang                                             ', N'TPHCM                                                                                               ', N'0571942141 ', 3, N'khd                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (5, N'Thuc                                              ', N'Binh Duong                                                                                          ', N'0567135346 ', 1, N'khe                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (6, N'Tran                                              ', N'Binh Duong                                                                                          ', N'0578136512 ', 5, N'khf                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (7, N'Nuong                                             ', N'KTX Khu B                                                                                           ', N'7912166415 ', 6, N'khg                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (8, N'Tri                                               ', N'Dong Nai                                                                                            ', N'0681938411 ', 10, N'khh                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (9, N'Phong                                             ', N'Binh Duong                                                                                          ', N'0912312111 ', 9, N'khi                                               ', N'123                                               ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDT_KH], [MaNV], [username], [password]) VALUES (10, N'Phi                                               ', N'TPHCM                                                                                               ', N'0237891334 ', 8, NULL, NULL)
GO
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [LoaiNha]) VALUES (1, N'Chung cu                                          ')
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [LoaiNha]) VALUES (2, N'Phong tro                                         ')
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [LoaiNha]) VALUES (3, N'Biet thu                                          ')
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [LoaiNha]) VALUES (4, N'Villa                                             ')
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [LoaiNha]) VALUES (5, N'Nha cap 4                                         ')
GO
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (1, 1, CAST(N'2020-12-01' AS Date), CAST(N'2021-02-01' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (2, 1, CAST(N'2018-01-19' AS Date), CAST(N'2018-03-19' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (2, 2, CAST(N'2020-02-18' AS Date), CAST(N'2020-12-18' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (3, 1, CAST(N'2018-09-12' AS Date), CAST(N'2018-10-12' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (4, 1, CAST(N'2019-09-09' AS Date), CAST(N'2019-11-09' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (4, 2, CAST(N'2019-12-12' AS Date), CAST(N'2020-02-12' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (5, 1, CAST(N'2020-03-12' AS Date), CAST(N'2020-04-12' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (5, 2, CAST(N'2020-08-13' AS Date), CAST(N'2020-09-13' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (6, 1, CAST(N'2018-09-12' AS Date), CAST(N'2018-10-12' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (7, 1, CAST(N'2020-09-12' AS Date), CAST(N'2020-10-13' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (7, 2, CAST(N'2020-10-14' AS Date), CAST(N'2020-11-10' AS Date))
INSERT [dbo].[LSDangNha] ([MaNha], [STT], [NgayDang], [NgayHetHan]) VALUES (8, 1, CAST(N'2018-09-06' AS Date), CAST(N'2018-10-08' AS Date))
GO
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (1, 1, CAST(N'2020-11-10' AS Date), N'nha rong, dep                                                                                       ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (1, 3, CAST(N'2020-12-10' AS Date), N'gia dat                                                                                             ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (2, 4, CAST(N'2018-09-12' AS Date), N'dep, chat luong                                                                                     ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (4, 2, CAST(N'2020-12-12' AS Date), N'vua y, dep                                                                                          ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (5, 1, CAST(N'2020-09-18' AS Date), N'nha dep                                                                                             ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (5, 10, CAST(N'2018-09-19' AS Date), N'khong                                                                                               ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (6, 6, CAST(N'2020-09-19' AS Date), N'khong                                                                                               ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (7, 8, CAST(N'2019-10-12' AS Date), N'khong                                                                                               ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (9, 5, CAST(N'2019-09-18' AS Date), N'khong                                                                                               ')
INSERT [dbo].[LSXemNha] ([MaNha], [MaKH], [NgayXemNha], [NhanXet]) VALUES (10, 1, CAST(N'2020-12-30' AS Date), N'dep, hop li                                                                                         ')
GO
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (1, N'ABC                                               ', N'DE                                                ', N'Z                                                 ', N'Thu Duc                                           ', 10, N'EXPIRED                                           ', 1000, 2, 6, 1)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (2, N'Phan Van Tri                                      ', N'Go Vap                                            ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 3, N'Con                                               ', 1345, 1, 1, 1)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (3, N'Tran Hung Dao                                     ', N'Quan 5                                            ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 2, N'Con                                               ', 18923, 4, 2, 2)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (4, N'Nguyen Van Cu                                     ', N'Quan 10                                           ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 3, N'Con                                               ', 5412, 3, 4, 3)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (5, N'Bach Dang                                         ', N'Binh Thanh                                        ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 4, N'Con                                               ', 123, 5, 1, 4)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (6, N'Pham Van Dong                                     ', N'Thu Duc                                           ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 3, N'Con                                               ', 123, 6, 5, 5)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (7, N'Xo Viet                                           ', N'Binh Thanh                                        ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 3, N'Con                                               ', 8467, 3, 2, 2)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (8, N'Ngo Quyen                                         ', N'Quan 3                                            ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 2, N'Con                                               ', 16799, 10, 9, 5)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (9, N'Hoang Dieu                                        ', N'Thu Duc                                           ', N'TPHCM                                             ', N'Dong Nam Bo                                       ', 5, N'Con                                               ', 900, 7, 3, 3)
INSERT [dbo].[Nha] ([MaNha], [TenDuong_Nha], [TenQuan_Nha], [TenThanhPho_Nha], [KhuVuc_Nha], [SL_Phong], [TinhTrang], [SoLuotXem], [MaChuNha], [MaNV], [MaLoaiNha]) VALUES (10, N'Vo Van Ngan                                       ', N'Thu Duc                                           ', N'TPHC<                                             ', N'Dong Nam Bo                                       ', 2, N'Het                                               ', 129, 8, 10, 4)
GO
INSERT [dbo].[NhaBan] ([MaNha], [GiaBan], [DieuKienChuNha]) VALUES (2, 200000000, N'khong                                                                                               ')
INSERT [dbo].[NhaBan] ([MaNha], [GiaBan], [DieuKienChuNha]) VALUES (3, 120000000, N'khong                                                                                               ')
INSERT [dbo].[NhaBan] ([MaNha], [GiaBan], [DieuKienChuNha]) VALUES (6, 129009, N'khong                                                                                               ')
INSERT [dbo].[NhaBan] ([MaNha], [GiaBan], [DieuKienChuNha]) VALUES (8, 18900000, N'khong                                                                                               ')
INSERT [dbo].[NhaBan] ([MaNha], [GiaBan], [DieuKienChuNha]) VALUES (9, 90000000, N'khong                                                                                               ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (1, 1, N'Trang                                             ', N'Binh Duong                                                                                          ', N'0345671341 ', 0, CAST(N'2000-07-17' AS Date), 500000, 1, N'nva                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (2, 2, N'Long                                              ', N'TPHCM                                                                                               ', N'5790756121 ', 1, CAST(N'2000-10-12' AS Date), 4500000, 1, N'nvb                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (3, 2, N'Nuong                                             ', N'TPHCM                                                                                               ', N'8345670113 ', 0, CAST(N'2000-12-10' AS Date), 389000, 1, N'nvc                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (4, 3, N'Phat                                              ', N'Binh Duong                                                                                          ', N'0168392141 ', 1, CAST(N'2000-04-12' AS Date), 230000, 1, N'nvd                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (5, 4, N'Truong                                            ', N'khu B                                                                                               ', N'0173142244 ', 1, CAST(N'2000-09-12' AS Date), 1831000, 1, N'nve                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (6, 1, N'Nhan                                              ', N'KTX Khu B                                                                                           ', N'0156239711 ', 1, CAST(N'2000-12-15' AS Date), 1000000, 1, N'nvf                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (7, 4, N'Van                                               ', N'Binh Duong                                                                                          ', N'0721472321 ', 0, CAST(N'2000-12-01' AS Date), 6813100, 1, N'nvg                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (8, 8, N'Trung                                             ', N'Khu B                                                                                               ', N'0935157411 ', 1, CAST(N'1999-01-12' AS Date), 90000, 1, N'nvh                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (9, 10, N'Tram                                              ', N'TPHCM                                                                                               ', N'0935881111 ', 0, CAST(N'1998-10-12' AS Date), 9630000, 1, N'nvi                                               ', N'123                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [MaCN], [TenNV], [DiaChiNV], [SDT_NV], [GioiTinhNV], [NgaySinh], [Luong], [CurrentFlag], [username], [password]) VALUES (10, 5, N'Phuong                                            ', N'TPHCM                                                                                               ', N'0916371311 ', 0, CAST(N'1999-10-12' AS Date), 850000, 1, N'nvj                                               ', N'123                                               ')
GO
INSERT [dbo].[NhaThue] ([MaNha], [TienThueThang]) VALUES (1, 120000)
INSERT [dbo].[NhaThue] ([MaNha], [TienThueThang]) VALUES (4, 239000)
INSERT [dbo].[NhaThue] ([MaNha], [TienThueThang]) VALUES (5, 936144)
INSERT [dbo].[NhaThue] ([MaNha], [TienThueThang]) VALUES (7, 90000)
INSERT [dbo].[NhaThue] ([MaNha], [TienThueThang]) VALUES (10, 120000)
GO
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (1, 1, N'1                                                 ', N'dep, rong                                                                                           ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (1, 2, N'4                                                 ', N'rong rai                                                                                            ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (1, 10, N'5                                                 ', N'nha chung cu                                                                                        ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (2, 3, N'2                                                 ', N'to                                                                                                  ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (2, 4, N'3                                                 ', N'cao                                                                                                 ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (2, 9, N'5                                                 ', N'khong                                                                                               ')
INSERT [dbo].[YeuCauKhachHang] ([MaPhieu], [MaKH], [LoaiNha], [TieuChi]) VALUES (8, 5, N'2                                                 ', N'co ban cong                                                                                         ')
GO
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [FK_HopDongThue_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [FK_HopDongThue_KhachHang]
GO
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [FK_HopDongThue_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [FK_HopDongThue_Nha]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO
ALTER TABLE [dbo].[LSDangNha]  WITH CHECK ADD  CONSTRAINT [FK_LSDangNha_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LSDangNha] CHECK CONSTRAINT [FK_LSDangNha_Nha]
GO
ALTER TABLE [dbo].[LSXemNha]  WITH CHECK ADD  CONSTRAINT [FK_LSXemNha_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[LSXemNha] CHECK CONSTRAINT [FK_LSXemNha_KhachHang]
GO
ALTER TABLE [dbo].[LSXemNha]  WITH CHECK ADD  CONSTRAINT [FK_LSXemNha_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LSXemNha] CHECK CONSTRAINT [FK_LSXemNha_Nha]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_ChuNha] FOREIGN KEY([MaChuNha])
REFERENCES [dbo].[ChuNha] ([MaChuNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_ChuNha]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_LoaiNha] FOREIGN KEY([MaLoaiNha])
REFERENCES [dbo].[LoaiNha] ([MaLoaiNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_LoaiNha]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_NhanVien]
GO
ALTER TABLE [dbo].[NhaBan]  WITH CHECK ADD  CONSTRAINT [FK_NhaBan_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhaBan] CHECK CONSTRAINT [FK_NhaBan_Nha]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[NhaThue]  WITH CHECK ADD  CONSTRAINT [FK_NhaThue_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhaThue] CHECK CONSTRAINT [FK_NhaThue_Nha]
GO
ALTER TABLE [dbo].[YeuCauKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_YeuCauKhachHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[YeuCauKhachHang] CHECK CONSTRAINT [FK_YeuCauKhachHang_KhachHang]
GO
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [CHECK_TIME_CONTRACT] CHECK  (([HopDongThue].[NgayBatDau]<[HopDongThue].[NgayKetThuc]))
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [CHECK_TIME_CONTRACT]
GO
ALTER TABLE [dbo].[LSDangNha]  WITH CHECK ADD  CONSTRAINT [CHECK_TIME] CHECK  (([LSDangNha].[NgayDang]<[LSDangNha].[NgayHetHan]))
GO
ALTER TABLE [dbo].[LSDangNha] CHECK CONSTRAINT [CHECK_TIME]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CHECK_AGE] CHECK  (((datepart(year,getdate())-datepart(year,[NhanVien].[NgaySinh]))>=(18)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CHECK_AGE]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CHECK_SALARY] CHECK  (([NhanVien].[Luong]>(0)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CHECK_SALARY]
GO

