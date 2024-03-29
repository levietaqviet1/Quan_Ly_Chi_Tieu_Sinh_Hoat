USE [QuanLyChiTieu]
GO
/****** Object:  Table [dbo].[ChiTieu]    Script Date: 12/26/2022 1:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTieu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[muc_dich_chi_tieu] [nvarchar](max) NULL,
	[gia_tien] [int] NULL,
	[loai_chi_tieu_id] [int] NULL,
	[thoi_gian] [date] NULL,
 CONSTRAINT [PK_ChiTieu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChiTieu]    Script Date: 12/26/2022 1:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChiTieu](
	[loai_chi_tieu_id] [int] IDENTITY(1,1) NOT NULL,
	[ten_chi_tieu] [nvarchar](50) NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_LoaiChiTieu] PRIMARY KEY CLUSTERED 
(
	[loai_chi_tieu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTieu_LoaiChiTieu] FOREIGN KEY([loai_chi_tieu_id])
REFERENCES [dbo].[LoaiChiTieu] ([loai_chi_tieu_id])
GO
ALTER TABLE [dbo].[ChiTieu] CHECK CONSTRAINT [FK_ChiTieu_LoaiChiTieu]
GO
