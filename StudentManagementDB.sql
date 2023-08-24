USE [master]
GO
/****** Object:  Database [StudentManagement]    Script Date: 8/6/2022 10:46:42 PM ******/
CREATE DATABASE [StudentManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StudentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudentManagement] SET QUERY_STORE = OFF
GO
USE [StudentManagement]
GO
/****** Object:  Table [dbo].[DayHoc]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DayHoc](
	[MaDayHoc] [int] NOT NULL,
	[MaMonHoc] [int] NOT NULL,
	[MaLop] [varchar](6) NOT NULL,
	[MaGV] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDayHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSV] [varchar](6) NOT NULL,
	[MaMonHoc] [int] NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [varchar](6) NOT NULL,
	[Ten] [varchar](20) NOT NULL,
	[DiaChi] [varchar](50) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc_SinhVien]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc_SinhVien](
	[MaLop] [varchar](6) NOT NULL,
	[MaSV] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [int] NOT NULL,
	[TenMonHoc] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [varchar](6) NOT NULL,
	[Ten] [varchar](20) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 8/6/2022 10:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[Ngay] [datetime] NOT NULL,
	[MaDayHoc] [int] NOT NULL,
	[Slot] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (1, 1, N'SE0001', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (2, 1, N'SE0002', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (3, 1, N'SE0003', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (4, 2, N'SE0001', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (5, 2, N'SE0004', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (6, 3, N'SE0003', N'TuanVM')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (7, 4, N'SE0003', N'TuanVM')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (8, 5, N'SE0002', N'KienMH')
INSERT [dbo].[DayHoc] ([MaDayHoc], [MaMonHoc], [MaLop], [MaGV]) VALUES (9, 6, N'SE0001', N'TuanVM')
GO
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0001', 1, 8)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0001', 2, 7)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0001', 3, 8)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0001', 4, 9)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0002', 1, 6)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0002', 2, 7)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0002', 3, 9)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0002', 4, 8)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0003', 3, 8)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0004', 2, 7)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV0006', 3, 7)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV01', 3, 7.5)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV03', 2, 8)
INSERT [dbo].[Diem] ([MaSV], [MaMonHoc], [Diem]) VALUES (N'SV03', 3, 7.5)
GO
INSERT [dbo].[GiangVien] ([MaGV], [Ten], [DiaChi], [Email], [GioiTinh], [NgaySinh]) VALUES (N'HaiLT', N'Luong The Hai', N'HN', N'hailt@gmail.com', 1, CAST(N'1980-04-04T00:00:00.000' AS DateTime))
INSERT [dbo].[GiangVien] ([MaGV], [Ten], [DiaChi], [Email], [GioiTinh], [NgaySinh]) VALUES (N'KienMH', N'Mai Hoang Kien', N'Ha Noi', N'kienmh@fpt.edu.vn', 1, CAST(N'1987-05-28T00:00:00.000' AS DateTime))
INSERT [dbo].[GiangVien] ([MaGV], [Ten], [DiaChi], [Email], [GioiTinh], [NgaySinh]) VALUES (N'TuanVM', N'Van Mai Tuan', N'Hai Duong', N'tuanvm@fpt.edu.vn', 1, CAST(N'1980-04-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'L00001')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'L00002')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'L00003')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'SE0001')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'SE0002')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'SE0003')
INSERT [dbo].[LopHoc] ([MaLop]) VALUES (N'SE0004')
GO
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'L00001', N'SV0001')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'L00001', N'SV0002')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV01')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV03')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV05')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV07')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV09')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV11')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV13')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0001', N'SV19')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0002', N'SV15')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0002', N'SV17')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0002', N'SV20')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0002', N'SV21')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0003', N'SV24')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0003', N'SV27')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0003', N'SV30')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0003', N'SV31')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0004', N'SV33')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0004', N'SV34')
INSERT [dbo].[LopHoc_SinhVien] ([MaLop], [MaSV]) VALUES (N'SE0004', N'SV35')
GO
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (1, N'PRN211')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (2, N'SWP391')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (3, N'SWR302')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (4, N'SWT301')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (5, N'PRF192')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (6, N'PRO192')
GO
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0001', N'Nguyen Van A', N'Ha Noi', 1, N'sv150001@gmail.com', CAST(N'2001-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0002', N'Nguyen Van B', N'Ha Noi', 1, N'sv150002@gmail.com', CAST(N'2001-02-02T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0003', N'Nguyen Thi C', N'Ha Noi', 0, N'sv150003@gmail.com', CAST(N'2001-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0004', N'Nguyen Thi D', N'Ha Noi', 0, N'sv150004@gmail.com', CAST(N'2001-04-04T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0006', N'Nguyen Van H', N'TP. HCM', 1, N'sv150006@gmail.com', CAST(N'2001-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0007', N'Pham Huy Hoang', N'Can Tho', 1, N'sv0007@gmail.com', CAST(N'2004-02-01T17:20:37.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV0008', N'Pham Huy Hoang Son', N'Da Nang', 1, N'sv0008@gmail.com', CAST(N'2004-02-01T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV01', N'Nguyen Van Long', N'HaNoi', 1, N'longnv@sv', CAST(N'2000-11-01T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV03', N'Nguyen Van Dung', N'BacNimh', 1, N'dungnv@sv', CAST(N'2000-11-02T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV05', N'Tran Thi Mai', N'HaiDuong', 0, N'maitt@sv', CAST(N'2000-10-03T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV07', N'Nguyen Van Toan', N'haiPhong', 1, N'toannv@sv', CAST(N'2000-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV09', N'Ly Van Sieu', N'TienDu', 1, N'sieulv@sv', CAST(N'2000-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV11', N'Nguyen Thi Bich', N'HaNoi', 0, N'bichnt@sv', CAST(N'2000-09-23T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV13', N'Ly Thi Tho', N'HaNoi', 0, N'tholt@sv', CAST(N'2000-07-22T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV15', N'Nguyen Huu Trinh', N'HaiDuong', 1, N'trinhnh@sv', CAST(N'2000-04-29T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV17', N'Le Thi Duong', N'HaNoi', 0, N'duonglt@sv', CAST(N'2000-01-17T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV19', N'Ly Quoc toan', N'BacNimh', 1, N'toanlq@sv', CAST(N'2000-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV20', N'Ly Van Sieu', N'BacNimh', 1, N'sieulv@sv', CAST(N'2000-01-19T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV21', N'Nguyen Thi Tho', N'BacNimh', 0, N'thont@sv', CAST(N'2000-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV24', N'Le Van Long', N'haiPhong', 1, N'longlv@sv', CAST(N'2000-12-14T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV27', N'Tran Quoc Tien', N'HaNoi', 1, N'tientq@sv', CAST(N'2000-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV30', N'Nguyen Mai Long', N'haiPhong', 0, N'longnm@sv', CAST(N'2000-07-06T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV31', N'Ly Van Duong', N'HaiDuong', 1, N'duonglv@sv', CAST(N'2000-03-09T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV33', N'Le Van Tuan', N'HaNoi', 1, N'tuannv@sv', CAST(N'2000-02-07T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV34', N'Tran Mai Long', N'TienDu', 0, N'longtm@sv', CAST(N'2000-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[SinhVien] ([MaSV], [Ten], [DiaChi], [GioiTinh], [Email], [NgaySinh]) VALUES (N'SV35', N'Nguyen Van Viet', N'TienDu', 1, N'vietnv@sv', CAST(N'2000-10-21T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[LopHoc_SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[LopHoc_SinhVien]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD FOREIGN KEY([MaDayHoc])
REFERENCES [dbo].[DayHoc] ([MaDayHoc])
GO
USE [master]
GO
ALTER DATABASE [StudentManagement] SET  READ_WRITE 
GO
