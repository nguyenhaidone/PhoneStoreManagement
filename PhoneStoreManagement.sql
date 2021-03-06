USE [PhoneStoreManagement]
GO
/****** Object:  Table [dbo].[TBL_ChiTietHDB]    Script Date: 11/6/2020 9:02:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_ChiTietHDB](
	[MaHDB] [nvarchar](250) NOT NULL,
	[MaSP] [nvarchar](250) NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
	[KhuyenMai] [float] NULL,
 CONSTRAINT [PK_TBL_ChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_ChiTietHoaDonNhap]    Script Date: 11/6/2020 9:02:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_ChiTietHoaDonNhap](
	[MaHDN] [nvarchar](250) NOT NULL,
	[MaSP] [nvarchar](250) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ThanhTien] [money] NULL,
	[KhuyenMai] [float] NULL,
 CONSTRAINT [PK_TBL_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_HoaDonBan]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_HoaDonBan](
	[MaHDB] [nvarchar](250) NULL,
	[NgayBan] [datetime] NULL,
	[MaNV] [nvarchar](250) NULL,
	[MaKH] [nvarchar](250) NULL,
	[TongTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_HoaDonNhap]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_HoaDonNhap](
	[MaHoaDonNhap] [nvarchar](250) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNV] [nvarchar](250) NULL,
	[MaNCC] [nvarchar](250) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_TBL_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_KhachHang]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KhachHang](
	[MaKhach] [nvarchar](250) NOT NULL,
	[TenKhach] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Loai]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Loai](
	[MaLoai] [nvarchar](250) NOT NULL,
	[TenLoai] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_ManHinh]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_ManHinh](
	[MaManHinh] [nvarchar](250) NOT NULL,
	[TenManHinh] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_ManHinh] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_NhaCungCap]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_NhaCungCap](
	[MaNhaCungCap] [nvarchar](250) NOT NULL,
	[TenNhaCungCap] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_NhanHieu]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_NhanHieu](
	[MaNhanHieu] [nvarchar](250) NOT NULL,
	[TenNhanHieu] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_NhanHieu] PRIMARY KEY CLUSTERED 
(
	[MaNhanHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_NhanVien]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_NhanVien](
	[MaNhanVien] [nvarchar](250) NOT NULL,
	[TenNhanVien] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[GioiTinh] [nvarchar](250) NULL,
	[NgaySinh] [datetime] NULL,
	[MaQue] [nvarchar](250) NULL,
	[SDT] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Que]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Que](
	[MaQue] [nvarchar](250) NOT NULL,
	[TenQue] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_Que] PRIMARY KEY CLUSTERED 
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SanPham]    Script Date: 11/6/2020 9:02:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SanPham](
	[MaSP] [nvarchar](250) NOT NULL,
	[TenSP] [nvarchar](250) NULL,
	[MaLoai] [nvarchar](250) NULL,
	[MaNhanHien] [nvarchar](250) NULL,
	[GiaNhap] [money] NULL,
	[GiaBan] [money] NULL,
	[SoLuong] [int] NULL,
	[ThoiGianBaoHanh] [datetime] NULL,
	[MaManHinh] [nvarchar](250) NULL,
	[AmThanh] [nvarchar](250) NULL,
	[Anh] [nvarchar](500) NULL,
	[ChupAnh] [nvarchar](250) NULL,
 CONSTRAINT [PK_TBL_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
