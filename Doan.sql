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
create TABLE [dbo].[Ve]
(
    [IDVe]       int identity(1,1)  NOT NULL ,
    [LoaiVe]      INT  DEFAULT '0',
    [IDLichChieu] NVARCHAR (50)  NULL,
    [MaGheNgoi]   NVARCHAR (50)  NULL,
    [IDKhachHang] NVARCHAR (50)  NULL,
    [TrangThai]   INT NOT NULL DEFAULT '0',
    [TienBanVe]   MONEY DEFAULT '0',
    CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED ([IDVe] ASC),
	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu([IDLichChieu]),
	FOREIGN KEY ([IDKhachHang]) REFERENCES dbo.KhachHang([idKhachHang])
);

--------------------------------------
alter PROC USP_GetAllListShowTimes
AS
BEGIN
	select pc.TenPhong ,l.IDLichChieu, p.TenPhim, l.ThoiGianChieu, d.IDDinhDangPhim as idDinhDang, l.GiaVe, l.TrangThai
	from Phim p ,DinhDangPhim d, LichChieu l, PhongChieu pc
	where p.IDPhim = d.idPhim and d.IDDinhDangPhim = l.idDinhDang and l.idPhong = pc.IDPhongChieu
	order by l.ThoiGianChieu
END
GO
---
CREATE PROC USP_GetListShowTimesNotCreateTickets
AS
BEGIN
	select  pc.TenPhong,l.IDLichChieu, p.TenPhim, l.ThoiGianChieu, d.IDDinhDangPhim as idDinhDang, l.GiaVe, l.TrangThai
	from Phim p ,DinhDangPhim d, LichChieu l, PhongChieu pc
	where p.IDPhim = d.idPhim and d.IDDinhDangPhim = l.idDinhDang and l.idPhong = pc.IDPhongChieu and l.TrangThai = 0
	order by l.ThoiGianChieu
END
GO
---
CREATE PROC USP_InsertTicketByShowTimes
@idlichChieu VARCHAR(50), @maGheNgoi VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Ve
	(
		idLichChieu,
		MaGheNgoi,
		idKhachHang
	)
	VALUES
	(
		@idlichChieu,
		@maGheNgoi,
		NULL
	)
END
GO
--------------
CREATE PROC USP_UpdateStatusShowTimes
@idLichChieu NVARCHAR(50), @status int
AS
BEGIN
	UPDATE dbo.LichChieu
	SET TrangThai = @status
	WHERE IDLichChieu = @idLichChieu
END



GO
CREATE PROC USP_DeleteTicketsByShowTimes
@idlichChieu VARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.Ve
	WHERE idLichChieu = @idlichChieu
END
GO
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
--Add Khách hàg
INSERT [dbo].[KhachHang] ([idKhachHang], [HoTenKH], [NgaySinhKH], [DiaChiKH], [SDTKH], [CMNDKH], [DiemTichLuy]) VALUES (N'KH01', N'Nguyễn Văn A', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161554, 0)
INSERT [dbo].[KhachHang] ([idKhachHang], [HoTenKH], [NgaySinhKH], [DiaChiKH], [SDTKH], [CMNDKH], [DiemTichLuy]) VALUES (N'KH02', N'Nguyễn Văn B', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161564, 0)
INSERT [dbo].[KhachHang] ([idKhachHang], [HoTenKH], [NgaySinhKH], [DiaChiKH], [SDTKH], [CMNDKH], [DiemTichLuy]) VALUES (N'KH03', N'Nguyễn Văn B', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161654, 0)


SET IDENTITY_INSERT [dbo].[Ve] ON
GO

INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (1, 0, N'LC01', N'A1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (2, 0, N'LC01', N'A2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (3, 0, N'LC01', N'A3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (4, 0, N'LC01', N'A4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (5, 0, N'LC01', N'A5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (6, 0, N'LC01', N'A6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (7, 0, N'LC01', N'A7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (8, 0, N'LC01', N'A8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (9, 0, N'LC01', N'A9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (10, 0, N'LC01', N'A10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (11, 0, N'LC01', N'A11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (12, 0, N'LC01', N'A12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (13, 0, N'LC01', N'A13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (14, 0, N'LC01', N'A14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (15, 0, N'LC01', N'B1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (16, 0, N'LC01', N'B2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (17, 0, N'LC01', N'B3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (18, 0, N'LC01', N'B4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (19, 0, N'LC01', N'B5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (20, 0, N'LC01', N'B6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (21, 0, N'LC01', N'B7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (22, 0, N'LC01', N'B8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (23, 0, N'LC01', N'B9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (24, 0, N'LC01', N'B10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (25, 0, N'LC01', N'B11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (26, 0, N'LC01', N'B12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (27, 0, N'LC01', N'B13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (28, 0, N'LC01', N'B14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (29, 0, N'LC01', N'C1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (30, 0, N'LC01', N'C2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (31, 0, N'LC01', N'C3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (32, 0, N'LC01', N'C4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (33, 0, N'LC01', N'C5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (34, 0, N'LC01', N'C6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (35, 0, N'LC01', N'C7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (36, 0, N'LC01', N'C8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (37, 0, N'LC01', N'C9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (38, 0, N'LC01', N'C10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (39, 0, N'LC01', N'C11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (40, 0, N'LC01', N'C12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (41, 0, N'LC01', N'C13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (42, 0, N'LC01', N'C14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (43, 0, N'LC01', N'D1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (44, 0, N'LC01', N'D2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (45, 0, N'LC01', N'D3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (46, 0, N'LC01', N'D4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (47, 0, N'LC01', N'D5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (48, 0, N'LC01', N'D6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (49, 0, N'LC01', N'D7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (50, 0, N'LC01', N'D8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (51, 0, N'LC01', N'D9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (52, 0, N'LC01', N'D10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (53, 0, N'LC01', N'D11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (54, 0, N'LC01', N'D12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (55, 0, N'LC01', N'D13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (56, 0, N'LC01', N'D14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (57, 0, N'LC01', N'E1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (58, 0, N'LC01', N'E2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (59, 0, N'LC01', N'E3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (60, 1, N'LC01', N'E4', NULL, 1, 85000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (61, 1, N'LC01', N'E5', NULL, 1, 85000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (62, 2, N'LC01', N'E6', NULL, 1, 68000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (63, 2, N'LC01', N'E7', NULL, 1, 68000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (64, 0, N'LC01', N'E8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (65, 0, N'LC01', N'E9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (66, 0, N'LC01', N'E10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (67, 0, N'LC01', N'E11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (68, 0, N'LC01', N'E12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (69, 0, N'LC01', N'E13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (70, 0, N'LC01', N'E14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (71, 0, N'LC01', N'F1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (72, 0, N'LC01', N'F2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (73, 0, N'LC01', N'F3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (74, 0, N'LC01', N'F4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (75, 0, N'LC01', N'F5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (76, 3, N'LC01', N'F6', NULL, 1, 59500.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (77, 2, N'LC01', N'F7', NULL, 1, 68000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (78, 3, N'LC01', N'F8', NULL, 1, 59500.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (79, 1, N'LC01', N'F9', NULL, 1, 85000.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (80, 0, N'LC01', N'F10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (81, 0, N'LC01', N'F11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (82, 0, N'LC01', N'F12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (83, 0, N'LC01', N'F13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (84, 0, N'LC01', N'F14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (85, 0, N'LC01', N'G1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (86, 0, N'LC01', N'G2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (87, 0, N'LC01', N'G3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (88, 0, N'LC01', N'G4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (89, 0, N'LC01', N'G5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (90, 2, N'LC01', N'G6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (91, 1, N'LC01', N'G7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (92, 0, N'LC01', N'G8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (93, 0, N'LC01', N'G9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (94, 0, N'LC01', N'G10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (95, 0, N'LC01', N'G11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (96, 0, N'LC01', N'G12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (97, 0, N'LC01', N'G13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (98, 0, N'LC01', N'G14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (99, 0, N'LC01', N'J1', NULL, 0, 0.0000)
GO
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (100, 0, N'LC01', N'J2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (101, 0, N'LC01', N'J3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (102, 0, N'LC01', N'J4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (103, 0, N'LC01', N'J5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (104, 0, N'LC01', N'J6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (105, 0, N'LC01', N'J7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (106, 0, N'LC01', N'J8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (107, 0, N'LC01', N'J9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (108, 0, N'LC01', N'J10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (109, 0, N'LC01', N'J11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (110, 0, N'LC01', N'J12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (111, 0, N'LC01', N'J13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (112, 0, N'LC01', N'J14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (113, 0, N'LC01', N'I1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (114, 0, N'LC01', N'I2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (115, 0, N'LC01', N'I3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (116, 0, N'LC01', N'I4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (117, 0, N'LC01', N'I5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (118, 0, N'LC01', N'I6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (119, 0, N'LC01', N'I7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (120, 0, N'LC01', N'I8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (121, 0, N'LC01', N'I9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (122, 0, N'LC01', N'I10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (123, 0, N'LC01', N'I11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (124, 0, N'LC01', N'I12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (125, 0, N'LC01', N'I13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (126, 0, N'LC01', N'I14', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (127, 0, N'LC01', N'K1', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (128, 0, N'LC01', N'K2', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (129, 0, N'LC01', N'K3', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (130, 0, N'LC01', N'K4', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (131, 0, N'LC01', N'K5', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (132, 0, N'LC01', N'K6', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (133, 0, N'LC01', N'K7', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (134, 0, N'LC01', N'K8', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (135, 0, N'LC01', N'K9', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (136, 0, N'LC01', N'K10', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (137, 0, N'LC01', N'K11', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (138, 0, N'LC01', N'K12', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (139, 0, N'LC01', N'K13', NULL, 0, 0.0000)
INSERT [dbo].[Ve] ([IDVe], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [TrangThai], [TienBanVe]) VALUES (140, 0, N'LC01', N'K14', NULL, 0, 0.0000)

SET IDENTITY_INSERT [dbo].[Ve] OFF
GO
