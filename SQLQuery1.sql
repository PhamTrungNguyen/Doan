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
-- Add Lo?i màn hình
