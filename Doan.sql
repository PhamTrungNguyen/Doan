CREATE DATABASE doan
GO

USE doan
GO

-------------KhachHang-------------
CREATE TABLE [dbo].[KhachHang] (
    [idKhachHang] NVARCHAR (50)  NOT NULL,
    [HoTenKH]     NVARCHAR (MAX) NOT NULL,
    [NgaySinhKH]  NVARCHAR (MAX) NOT NULL,
    [DiaChiKH]    NVARCHAR (MAX) NULL,
    [SDTKH]       NVARCHAR (MAX) NULL,
    [CMNDKH]      NVARCHAR (MAX) NOT NULL,
    [DiemTichLuy] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED ([idKhachHang] ASC)
);
GO
-------------NhanVien-------------
CREATE TABLE [dbo].[NhanVien] (
    [idNhanVien] NVARCHAR (50)  NOT NULL,
    [TenNV]      NVARCHAR (MAX) NOT NULL,
    [NgaySinhNV] DATE           NOT NULL,
    [DiaChiNV]   NVARCHAR (MAX) NULL,
    [SDTNV]      NVARCHAR (MAX) NULL,
    [CMNDNV]     INT            NOT NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([idNhanVien] ASC)
);
GO
-------------TaiKhoan-------------
CREATE TABLE [dbo].[TaiKhoan] (
    [UserName]   NVARCHAR (MAX) NULL,
    [Pass]       NVARCHAR (MAX) NULL,
    [LoaiTK]     NVARCHAR (MAX) NULL,
    [idNhanVien] NVARCHAR (50) NULL,
	FOREIGN KEY ([idNhanVien]) REFERENCES dbo.NhanVien([idNhanVien])
);
GO
------------- TheLoai -------------
CREATE TABLE [dbo].[TheLoai] (
    [IDTheLoai]  NVARCHAR (50)  NOT NULL,
    [TenTheLoai] NVARCHAR (MAX) NULL,
    [MoTa]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED ([IDTheLoai] ASC)
);
GO

------------- [Phim] --------------------
CREATE TABLE [dbo].[Phim] (
    [IDPhim]        NVARCHAR (50) NOT NULL,
    [TenPhim]       NVARCHAR (50) NULL,
    [ThoiLuong]     FLOAT (53)    NULL,
    [NgayKhoiChieu] DATE          NULL,
    [NgayKetThuc]   DATE          NULL,
    [SanXuat]       NVARCHAR (50) NULL,
    [DaoDien]       NVARCHAR (50) NULL,
    [NamSX]         INT           NULL,
    [IDTheLoai]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED ([IDPhim] ASC),
    CONSTRAINT [FK_Phim_TheLoai1] FOREIGN KEY ([IDTheLoai]) REFERENCES [dbo].[TheLoai] ([IDTheLoai])
);


GO

------------- [LoaiManHinh] -----------------
CREATE TABLE [dbo].[LoaiManHinh] (
    [IDLoaiManHinh] NVARCHAR (50)  NOT NULL,
    [TenManHinh]    NVARCHAR (MAX) NULL,
	CONSTRAINT [PK_LoaiManHinh] PRIMARY KEY ([IDLoaiManHinh])
);

------------- [DinhDangPhim] -----------------
CREATE TABLE [dbo].[DinhDangPhim] (
    [IDDinhDangPhim] NVARCHAR (50) NOT NULL,
    [IDPhim]         NVARCHAR (50) NOT NULL,
    [IDLoaiManHinh]  NVARCHAR (50) NOT NULL,
	CONSTRAINT [PK_DinhDangPhim] PRIMARY KEY ([IDDinhDangPhim]),
	FOREIGN KEY ([IDPhim]) REFERENCES dbo.Phim([IDPhim]),
	FOREIGN KEY ([IDLoaiManHinh]) REFERENCES dbo.LoaiManHinh([IDLoaiManHinh])
);


GO
------------- [PhongChieu] -----------------
CREATE TABLE [dbo].[PhongChieu] (
    [IDPhongChieu] NVARCHAR (50)  NOT NULL,
    [TenPhong]     NVARCHAR (MAX) NULL,
    [IDManHinh]    NVARCHAR (50)  NOT NULL,
    [SoChoNgoi]    INT            NULL,
    [TinhTrang]    NVARCHAR (50)  NULL,
    [SoHangGhe]    INT            NULL,
    [SoGheMotHang] INT            NULL,
	CONSTRAINT [PK_PhongChieu] PRIMARY KEY ([IDPhongChieu]),
	FOREIGN KEY ([IDManHinh]) REFERENCES dbo.LoaiManHinh([IDLoaiManHinh])
);
GO
------------- [LichChieu] -----------------
CREATE TABLE [dbo].[LichChieu] (
    [IDLichChieu]   NVARCHAR (50) NOT NULL,
    [ThoiGianChieu] DATETIME      NULL,
    [IDPhong]       NVARCHAR (50) NOT NULL,
    [IDDinhDang]    NVARCHAR (50) NOT NULL,
    [GiaVe]         NVARCHAR (50) NULL,
    [TrangThai]     NVARCHAR (20) NULL,
	CONSTRAINT [PK_LichChieu] PRIMARY KEY ([IDLichChieu]),
	FOREIGN KEY ([IDPhong]) REFERENCES dbo.PhongChieu([IDPhongChieu]),
	FOREIGN KEY ([IDDinhDang]) REFERENCES dbo.DinhDangPhim([IDDinhDangPhim]),
);
------------- Ve -----------------
CREATE TABLE [dbo].[Ve] (
    [IDVe]        NVARCHAR (50)  NOT NULL ,
    [LoaiVe]      NVARCHAR (MAX) NULL,
    [IDLichChieu] NVARCHAR (50)  NULL,
    [MaGheNgoi]   NVARCHAR (50)  NULL,
    [IDKhachHang] NVARCHAR (50)  NULL,
    [TrangThai]   NVARCHAR (50)  NULL,
    [TienBanVe]   FLOAT (53)     NULL,
    CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED ([IDVe] ASC),
	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu([IDLichChieu]),
	FOREIGN KEY ([IDKhachHang]) REFERENCES dbo.KhachHang([idKhachHang])
);

-------------------- ADD------------------
-- Add Th? Lo?i
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL01', N'Hành ??ng')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL02', N'Ho?t Hình')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL03', N'Hài')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL04', N'Vi?n T??ng')
-- Add Phim
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] ,[IDTheLoai]) VALUES (N'P01', N'Avengers: Cu?c Chi?n Vô C?c',  150, CAST(N'2022-05-01' AS Date), CAST(N'2022-06-01' AS Date), N'M?', N'Anthony Russo,  Joe Russo', 2022 , N'TL01')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P02', N'L?t M?t: 3 Chàng Khuy?t',  100, CAST(N'2022-05-01' AS Date), CAST(N'2022-06-01' AS Date), N'Vi?t Nam', N'Lý H?i', 2022 , N'TL02')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P03', N'100 Ngày Bên Em',  100, CAST(N'2022-05-01' AS Date), CAST(N'2022-06-01' AS Date), N'Vi?t Nam', N'V? Ng?c Ph??ng', 2022 , N'TL03')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P04', N'Ng?ng V?t Phiêu L?u Ký', 91, CAST(N'2022-05-01' AS Date), CAST(N'2022-06-01' AS Date), N'M?', N'Christopher Jenkins', 2022, N'TL04')
-- Add Loại màn hình
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH01', N'2D')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH02', N'3D')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH03', N'IMAX')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH04', N'4D')
-- Add Định dạng phim
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD01', N'P01', N'MH01')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD02', N'P01', N'MH03')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD03', N'P02', N'MH01')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD04', N'P03', N'MH02')
-- Add Phong Chiếu
INSERT [dbo].[PhongChieu] ([IDPhongChieu], [TenPhong], [IDManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC01', N'CINEMA 01', N'MH01', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([IDPhongChieu], [TenPhong], [IDManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC02', N'CINEMA 02', N'MH01', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([IDPhongChieu], [TenPhong], [IDManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC03', N'CINEMA 03', N'MH03', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([IDPhongChieu], [TenPhong], [IDManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC04', N'CINEMA 04', N'MH01', 140, 1, 10, 14)
--Add Lịch chiếu
INSERT [dbo].[LichChieu] ([IDLichChieu], [ThoiGianChieu], [IDPhong], [IDDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC01', CAST(N'2022-05-02T08:50:00.000' AS DateTime), N'PC01', N'DD01', 85000.0000, 1)
INSERT [dbo].[LichChieu] ([IDLichChieu], [ThoiGianChieu], [IDPhong], [IDDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC02', CAST(N'2022-05-02T08:05:00.000' AS DateTime), N'PC02', N'DD01', 85000.0000, 0)
INSERT [dbo].[LichChieu] ([IDLichChieu], [ThoiGianChieu], [IDPhong], [IDDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC03', CAST(N'2022-05-02T08:10:00.000' AS DateTime), N'PC03', N'DD02', 85000.0000, 0)
INSERT [dbo].[LichChieu] ([IDLichChieu], [ThoiGianChieu], [IDPhong], [IDDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC04', CAST(N'2022-05-02T09:20:00.000' AS DateTime), N'PC04', N'DD03', 85000.0000, 0)