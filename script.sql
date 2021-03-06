USE [QuanLyNhanVien]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[PhongBanId] [int] NULL,
	[Ho] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[DaXoa] [bit] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgaySua] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhongBan] [nvarchar](50) NOT NULL,
	[TenPhongBan] [nvarchar](50) NOT NULL,
	[DaXoa] [bit] NOT NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [PhongBanId], [Ho], [Ten], [DiaChi], [DienThoai], [Email], [DaXoa], [NgayTao], [NgaySua]) VALUES (1, 1, N'Nguyen', N'Binh', N'PhuDien', N'06548', N'Nguyen@gmail.com', 0, CAST(N'2020-09-16T12:09:49.357' AS DateTime), CAST(N'2020-09-16T12:09:49.357' AS DateTime))
INSERT [dbo].[NhanVien] ([MaNV], [PhongBanId], [Ho], [Ten], [DiaChi], [DienThoai], [Email], [DaXoa], [NgayTao], [NgaySua]) VALUES (2, 3, N'Truong', N'Binh', N'mykhanh', N'9877585', N'd@gmail.com', 0, CAST(N'2020-09-18T02:50:20.450' AS DateTime), CAST(N'2020-09-18T02:50:20.450' AS DateTime))
INSERT [dbo].[NhanVien] ([MaNV], [PhongBanId], [Ho], [Ten], [DiaChi], [DienThoai], [Email], [DaXoa], [NgayTao], [NgaySua]) VALUES (3, 1, N'Truong', N'Binh', N'mykhanh', N'9877585', N'd@gmail.com', 0, CAST(N'2020-09-18T02:53:06.993' AS DateTime), CAST(N'2020-09-18T02:53:06.993' AS DateTime))
INSERT [dbo].[NhanVien] ([MaNV], [PhongBanId], [Ho], [Ten], [DiaChi], [DienThoai], [Email], [DaXoa], [NgayTao], [NgaySua]) VALUES (4, 3, N'Truong', N'Binh', N'mykhanh', N'9877585', N'd@gmail.com', 0, CAST(N'2020-11-03T21:26:06.690' AS DateTime), CAST(N'2020-11-03T21:26:06.690' AS DateTime))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (1, N'PB02', N'CNTT', 0)
INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (3, N'PB01', N'KHMT', 0)
INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (4, N'PB03', N'Toán', 0)
INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (5, N'PB04', N'CNPM', 1)
INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (6, N'PB04', N'CNPM', 1)
INSERT [dbo].[PhongBan] ([ID], [MaPhongBan], [TenPhongBan], [DaXoa]) VALUES (7, N'PB05', N'KHMT', 1)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([PhongBanId])
REFERENCES [dbo].[PhongBan] ([ID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan1] FOREIGN KEY([PhongBanId])
REFERENCES [dbo].[PhongBan] ([ID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan1]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNhanVienTheoPhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<list department>
-- =============================================
CREATE PROCEDURE [dbo].[DanhSachNhanVienTheoPhongBan]
         @PhongBanId INT
AS
BEGIN
SELECT [MaNV]
      ,[PhongBanId]
      ,[Ho]
      ,[Ten]
      ,[DiaChi]
      ,[DienThoai]
      ,[Email]
      ,[NgayTao]
      ,[NgaySua]
  FROM [dbo].[NhanVien]
  WHERE PhongBanId = @PhongBanId AND DaXoa = 0
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachPhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<list department>
-- =============================================
CREATE PROCEDURE [dbo].[DanhSachPhongBan]

AS
BEGIN

SELECT [ID]
      ,[MaPhongBan]
      ,[TenPhongBan]
	  ,(SELECT COUNT(*) FROM NhanVien WHERE PhongBanId = ID) AS TongSoNhanVien
  FROM [dbo].[PhongBan]
  WHERE DaXoa = 0
END
GO
/****** Object:  StoredProcedure [dbo].[LayNhanVienTheoMaNV]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<list department>
-- =============================================
CREATE PROCEDURE [dbo].[LayNhanVienTheoMaNV]
         @MaNV INT
AS
BEGIN
SELECT [MaNV]
      ,[PhongBanId]
      ,[Ho]
      ,[Ten]
      ,[DiaChi]
      ,[DienThoai]
      ,[Email]
      ,[NgayTao]
      ,[NgaySua]
  FROM [dbo].[NhanVien]
  WHERE MaNV = @MaNV AND DaXoa = 0
END
GO
/****** Object:  StoredProcedure [dbo].[LayPhongBanID]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<list department>
-- =============================================
CREATE PROCEDURE [dbo].[LayPhongBanID]
         @Id INT

AS
BEGIN

IF(NOT EXISTS(SELECT * FROM [dbo].PhongBan WHERE DaXoa = 0 AND Id =@Id))
BEGIN
    RAISERROR('Invalid Deparment' , 1 , 100)
	RETURN
END
SELECT [ID]
      ,[MaPhongBan]
      ,[TenPhongBan]
  FROM [dbo].[PhongBan]
  WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Update emloyee department>
-- =============================================
CREATE PROCEDURE [dbo].[SuaNhanVien]
    @MaNV INT,
	@PhongBanId INT,
	@Ho NVARCHAR(50),
	@Ten NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@DienThoai NVARCHAR(50),
	@Email NVARCHAR(50)

AS
BEGIN

UPDATE [dbo].[NhanVien]
   SET [PhongBanId] = @PhongBanId
      ,[Ho] = @Ho
      ,[Ten] = @Ten
      ,[DiaChi] = @DiaChi
      ,[DienThoai] = @DienThoai
      ,[Email] = @Email
      ,[NgaySua] = GETDATE()
WHERE MaNV = @MaNV

SELECT @MaNV AS MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Update department>
-- =============================================
CREATE PROCEDURE [dbo].[SuaPhongBan]
	@Id INT,
	@MaPhongBan NVARCHAR(50),
	@TenPhongBan NVARCHAR(50)
AS
BEGIN

UPDATE [dbo].[PhongBan]
   SET [MaPhongBan] = @MaPhongBan
      ,[TenPhongBan] = @TenPhongBan
 WHERE Id = @Id

SELECT @Id AS Id
END
GO
/****** Object:  StoredProcedure [dbo].[TaoNhanVien]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Create Emloyee department>
-- =============================================
CREATE PROCEDURE [dbo].[TaoNhanVien]
	@PhongBanId INT,
	@Ho NVARCHAR(50),
	@Ten NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@DienThoai NVARCHAR(50),
	@Email NVARCHAR(50)

AS
BEGIN

INSERT INTO [dbo].[NhanVien]
           ([PhongBanId]
           ,[Ho]
           ,[Ten]
           ,[DiaChi]
           ,[DienThoai]
           ,[Email]
           ,[DaXoa]
           ,[NgayTao]
           ,[NgaySua])
     VALUES
           (@PhongBanId
           ,@Ho
           ,@Ten
           ,@DiaChi
           ,@DienThoai
           ,@Email
           ,0
           ,GETDATE()
           ,GETDATE())
DECLARE @MaNV INT
SET @MaNV = SCOPE_IDENTITY()
SELECT @MaNV AS MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[TaoPhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Create new department>
-- =============================================
CREATE PROCEDURE [dbo].[TaoPhongBan]
	-- Add the parameters for the stored procedure here
	@MaPhongBan NVARCHAR(50),
	@TenPhongBan NVARCHAR(50)
AS
BEGIN

INSERT INTO [dbo].[PhongBan]
           ([MaPhongBan]
           ,[TenPhongBan]
           ,[DaXoa])
VALUES
           (@MaPhongBan
           ,@TenPhongBan
           ,0)

DECLARE @Id INT
SET @Id = SCOPE_IDENTITY()
SELECT @Id AS Id
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Delete department>
-- =============================================
--lay gia tri int
/*ALTER PROCEDURE [dbo].[XoaPhongBan]
	@Id INT
	
AS
BEGIN

UPDATE [dbo].[PhongBan]
   SET [DaXoa] = 1
   WHERE Id = @Id
SELECT @Id AS Id
END*/
CREATE PROCEDURE [dbo].[XoaNhanVien]
	@MaNV INT
	
AS
BEGIN
DECLARE @Result BIT =0
BEGIN TRY
UPDATE [dbo].[NhanVien]
   SET [DaXoa] = 1
   WHERE MaNV = @MaNV
   SET @Result = 1
   END TRY
BEGIN CATCH
END CATCH
SELECT @Result AS Result
END
GO
/****** Object:  StoredProcedure [dbo].[XoaPhongBan]    Script Date: 11/4/2020 3:01:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Binh Nguyen>
-- Create date: <15/09/2020>
-- Description:	<Delete department>
-- =============================================
--lay gia tri int
/*ALTER PROCEDURE [dbo].[XoaPhongBan]
	@Id INT
	
AS
BEGIN

UPDATE [dbo].[PhongBan]
   SET [DaXoa] = 1
   WHERE Id = @Id
SELECT @Id AS Id
END*/
CREATE PROCEDURE [dbo].[XoaPhongBan]
	@Id INT
	
AS
BEGIN
DECLARE @Result BIT =0
BEGIN TRY
UPDATE [dbo].[PhongBan]
   SET [DaXoa] = 1
   WHERE Id = @Id
   SET @Result = 1
   END TRY
BEGIN CATCH
END CATCH
SELECT @Result AS Result
END
GO
