USE [banhangsieuthi]
GO
/****** Object:  Table [dbo].[chitiepphieunhap]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiepphieunhap](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[manhap] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[mahoadon] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieugiaoca]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieugiaoca](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[magiaoca] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[maxuat] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[ma] [nvarchar](20) NOT NULL,
	[ngaylap] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[thanhtien] [float] NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[uudai] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachmuahang]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachmuahang](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[makhachhang] [nvarchar](20) NULL,
	[mahoadon] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khohang]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khohang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mathang]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mathang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[loaimathang] [nvarchar](50) NULL,
	[donvitinh] [nvarchar](10) NULL,
	[maquay] [nvarchar](20) NULL,
	[manhacc] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[machucvu] [nvarchar](20) NULL,
	[taikhoan] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieugiaoca]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieugiaoca](
	[ma] [nvarchar](20) NOT NULL,
	[ngay] [datetime] NULL,
	[ca] [int] NULL,
	[maquay] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieukiemke]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieukiemke](
	[ma] [nvarchar](20) NOT NULL,
	[ngaylap] [datetime] NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[manhanvien] [nvarchar](20) NULL,
	[makhohang] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieunhapkho]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhapkho](
	[ma] [nvarchar](20) NOT NULL,
	[makhohang] [nvarchar](20) NULL,
	[ngaynhap] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[manhacungcap] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieuxuatkho]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuatkho](
	[ma] [nvarchar](20) NOT NULL,
	[ngayxuat] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[makhohang] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
	[maquay] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[quayhang]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quayhang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[vitri] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[chitiepphieunhap]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitiepphieunhap]  WITH CHECK ADD FOREIGN KEY([manhap])
REFERENCES [dbo].[phieunhapkho] ([ma])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([ma])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitietphieugiaoca]  WITH CHECK ADD FOREIGN KEY([magiaoca])
REFERENCES [dbo].[phieugiaoca] ([ma])
GO
ALTER TABLE [dbo].[chitietphieugiaoca]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD FOREIGN KEY([maxuat])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD FOREIGN KEY([maxuat])
REFERENCES [dbo].[phieuxuatkho] ([ma])
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[khachmuahang]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([ma])
GO
ALTER TABLE [dbo].[khachmuahang]  WITH CHECK ADD FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([ma])
GO
ALTER TABLE [dbo].[mathang]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
ALTER TABLE [dbo].[mathang]  WITH CHECK ADD  CONSTRAINT [FK_mathang_nhacungcap] FOREIGN KEY([maquay])
REFERENCES [dbo].[nhacungcap] ([ma])
GO
ALTER TABLE [dbo].[mathang] CHECK CONSTRAINT [FK_mathang_nhacungcap]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([machucvu])
REFERENCES [dbo].[chucvu] ([ma])
GO
ALTER TABLE [dbo].[phieugiaoca]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieugiaoca]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[nhacungcap] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
/****** Object:  StoredProcedure [dbo].[sp_dangnhap]    Script Date: 5/4/2017 9:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dangnhap] @username nvarchar(50), @password nvarchar(50)
as
begin
	select taikhoan, matkhau from nhanvien where
	taikhoan=@username and matkhau=@password
end 
GO
