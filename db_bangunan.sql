USE [db_bangunan]
GO
/****** Object:  Table [dbo].[l_member]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_member](
	[id_member] [varchar](10) NOT NULL,
	[nama] [varchar](50) NULL,
	[tgl_daftar] [date] NULL,
	[jenis_kelamin] [varchar](10) NULL,
	[no_hp] [bigint] NULL,
	[alamat] [varchar](50) NULL,
 CONSTRAINT [PK_l_member] PRIMARY KEY CLUSTERED 
(
	[id_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_jenis]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_jenis](
	[id_jenis] [varchar](10) NOT NULL,
	[nama_jenis] [varchar](30) NULL,
 CONSTRAINT [PK_l_jenis] PRIMARY KEY CLUSTERED 
(
	[id_jenis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_barang]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_barang](
	[id_barang] [varchar](10) NOT NULL,
	[nama_barang] [varchar](50) NULL,
	[id_satuan] [varchar](10) NULL,
	[id_jenis] [varchar](10) NULL,
	[stok] [int] NULL,
	[harga_beli] [int] NULL,
	[harga_jual] [int] NULL,
 CONSTRAINT [PK_l_barang] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_angsuran]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_angsuran](
	[id_angsuran] [varchar](10) NOT NULL,
	[tanggal] [date] NULL,
	[id_member] [varchar](10) NULL,
	[jml_angsuran] [int] NULL,
 CONSTRAINT [PK_l_angsuran] PRIMARY KEY CLUSTERED 
(
	[id_angsuran] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_user]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_user](
	[id_user] [varchar](10) NOT NULL,
	[nama] [varchar](50) NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [PK_l_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_supplier]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_supplier](
	[id_supplier] [varchar](10) NOT NULL,
	[nama_supplier] [varchar](50) NULL,
	[alamat] [varchar](50) NULL,
	[no_telp] [varchar](12) NULL,
 CONSTRAINT [PK_l_supplier] PRIMARY KEY CLUSTERED 
(
	[id_supplier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_satuan]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_satuan](
	[id_satuan] [varchar](10) NOT NULL,
	[nama_satuan] [varchar](30) NULL,
 CONSTRAINT [PK_l_satuan] PRIMARY KEY CLUSTERED 
(
	[id_satuan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_penjualan]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_penjualan](
	[id_penjualan] [varchar](255) NOT NULL,
	[no_faktur] [varchar](50) NULL,
	[id_member] [varchar](10) NULL,
	[tanggal] [datetime] NULL,
	[id_barang] [varchar](10) NULL,
	[harga_jual] [int] NULL,
	[jumlah] [int] NULL,
	[sub_total] [int] NULL,
	[pembayaran] [varchar](10) NULL,
	[jml_bayar] [int] NULL,
	[kembalian] [int] NULL,
 CONSTRAINT [PK_l_penjualan_1] PRIMARY KEY CLUSTERED 
(
	[id_penjualan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_pembelian]    Script Date: 01/02/2023 23:02:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_pembelian](
	[no_faktur] [varchar](50) NOT NULL,
	[tanggal] [datetime] NULL,
	[id_supplier] [varchar](10) NULL,
	[id_barang] [varchar](10) NULL,
	[harga_beli] [int] NULL,
	[jumlah] [int] NULL,
	[total_harga] [int] NULL,
 CONSTRAINT [PK_l_pembelian] PRIMARY KEY CLUSTERED 
(
	[no_faktur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[deleteuser]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteuser]
	@id_user varchar(20)
AS
	BEGIN
		delete from l_user where id_user=@id_user
	END
GO
/****** Object:  StoredProcedure [dbo].[deletesupplier]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletesupplier]
	@id_supplier varchar(10)
AS
	BEGIN
		delete from l_supplier where id_supplier=@id_supplier
	END
GO
/****** Object:  StoredProcedure [dbo].[deletesatuan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletesatuan]
	@id_satuan varchar(10)
AS
	BEGIN
		delete from l_satuan where id_satuan=@id_satuan
	END
GO
/****** Object:  StoredProcedure [dbo].[updatemember]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatemember]
	@id_member varchar(10),
	@nama varchar(50),
	@tgl_daftar date,
	@jenis_kelamin varchar(10),
	@no_hp bigint,
	@alamat varchar(50)
AS
	BEGIN
		Update l_member set nama=@nama,tgl_daftar=@tgl_daftar,jenis_kelamin=@jenis_kelamin,no_hp=@no_hp,alamat=@alamat
		where id_member=@id_member
	END
GO
/****** Object:  StoredProcedure [dbo].[updatejenis]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatejenis]
	@id_jenis varchar(10),
	@nama_jenis varchar(30)
AS
	BEGIN
		update l_jenis set nama_jenis=@nama_jenis where id_jenis=@id_jenis
	END
GO
/****** Object:  StoredProcedure [dbo].[updatebarang]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatebarang]
	@id_barang varchar(10),
	@nama_barang varchar(50),
	@id_satuan varchar(10),
	@id_jenis varchar(10),
	@stok int,
	@harga_beli int,
	@harga_jual int
AS
	BEGIN
	update l_barang set nama_barang=@nama_barang,id_satuan=@id_satuan,id_jenis=@id_jenis,stok=@stok,harga_beli=@harga_beli,harga_jual=@harga_jual where id_barang=@id_barang
	END
GO
/****** Object:  StoredProcedure [dbo].[saveuser]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[saveuser]
	@id_user varchar(10),
	@nama varchar(50),
	@username varchar(20),
	@password varchar(20)
AS
	BEGIN
		insert into l_user(id_user,nama,username,password) values (@id_user,@nama,@username,@password)
	END
GO
/****** Object:  StoredProcedure [dbo].[savesupplier]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savesupplier]
	@id_supplier varchar(10),
	@nama_supplier varchar(50),
	@alamat varchar(50),
	@no_telp varchar(12)
AS
	BEGIN
		insert into l_supplier values (@id_supplier,@nama_supplier,@alamat,@no_telp)
	END
GO
/****** Object:  StoredProcedure [dbo].[savesatuan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savesatuan]
	@id_satuan varchar(10),
	@nama_satuan varchar(30)
AS
	BEGIN
		insert into l_satuan values (@id_satuan,@nama_satuan)
	END
GO
/****** Object:  StoredProcedure [dbo].[savemember]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savemember]
	@id_member varchar(10),
	@nama varchar(50),
	@tgl_daftar date,
	@jenis_kelamin varchar(10),
	@no_hp bigint,
	@alamat varchar(50)
AS
	BEGIN
		insert into l_member values (@id_member,@nama,@tgl_daftar,@jenis_kelamin,@no_hp,@alamat)
	END
GO
/****** Object:  StoredProcedure [dbo].[savejenis]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savejenis]
	@id_jenis varchar(10),
	@nama_jenis varchar(30)
AS
	BEGIN
		insert into l_jenis values (@id_jenis,@nama_jenis)
	END
GO
/****** Object:  StoredProcedure [dbo].[savebarang]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savebarang]
	@id_barang varchar(10),
	@nama_barang varchar(50),
	@id_satuan varchar(10),
	@id_jenis varchar(10),
	@stok int,
	@harga_beli int,
	@harga_jual int
AS
	BEGIN
	insert into l_barang values (@id_barang,@nama_barang,@id_satuan,@id_jenis,@stok,@harga_beli,@harga_jual)
	END
GO
/****** Object:  StoredProcedure [dbo].[saveangsuran]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[saveangsuran]
	@id_angsuran varchar(10),
	@tanggal date,
	@id_member varchar(10),
	@jml_angsuran int
AS
	BEGIN
		insert into l_angsuran values (@id_angsuran,@tanggal,@id_member,@jml_angsuran)
	END
GO
/****** Object:  StoredProcedure [dbo].[updateuser]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateuser]
	@id_user varchar(20),
	@nama varchar(50),
	@username varchar(20),
	@password varchar(20)
AS
	BEGIN
		update l_user set nama=@nama,username=@username,password=@password where id_user=@id_user
	END
GO
/****** Object:  StoredProcedure [dbo].[updatesupplier]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatesupplier]
	@id_supplier varchar(10),
	@nama_supplier varchar(50),
	@alamat varchar(50),
	@no_telp varchar(12)
AS
	BEGIN
		update l_supplier set nama_supplier=@nama_supplier,alamat=@alamat,no_telp=@no_telp where id_supplier=@id_supplier
	END
GO
/****** Object:  StoredProcedure [dbo].[updatesatuan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatesatuan]
	@id_satuan varchar(10),
	@nama_satuan varchar(30)
AS
	BEGIN
		update l_satuan set nama_satuan=@nama_satuan where id_satuan=@id_satuan
	END
GO
/****** Object:  View [dbo].[v_rstokbarang]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rstokbarang]
AS
SELECT     dbo.l_barang.id_barang, dbo.l_barang.nama_barang, dbo.l_satuan.nama_satuan, dbo.l_jenis.nama_jenis, dbo.l_barang.stok
FROM         dbo.l_barang INNER JOIN
                      dbo.l_satuan ON dbo.l_barang.id_satuan = dbo.l_satuan.id_satuan INNER JOIN
                      dbo.l_jenis ON dbo.l_barang.id_jenis = dbo.l_jenis.id_jenis
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_satuan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 96
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_jenis"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 96
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rstokbarang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rstokbarang'
GO
/****** Object:  StoredProcedure [dbo].[deletemember]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletemember]
	@id_member varchar(10)
AS
	BEGIN
		delete from l_member where id_member=@id_member;
	END
GO
/****** Object:  StoredProcedure [dbo].[deletejenis]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletejenis]
	@id_jenis varchar(10)
AS
	BEGIN
		delete from l_jenis where id_jenis=@id_jenis
	END
GO
/****** Object:  StoredProcedure [dbo].[deletebarang]    Script Date: 01/02/2023 23:02:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletebarang]
	@id_barang varchar(10)
AS
	BEGIN
		delete from l_barang where id_barang=@id_barang
	END
GO
/****** Object:  View [dbo].[v_barang]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_barang]
AS
SELECT        dbo.l_barang.id_barang, dbo.l_barang.nama_barang, dbo.l_satuan.nama_satuan, dbo.l_jenis.nama_jenis, dbo.l_barang.stok, dbo.l_barang.harga_beli, dbo.l_barang.harga_jual
FROM            dbo.l_barang INNER JOIN
                         dbo.l_satuan ON dbo.l_barang.id_satuan = dbo.l_satuan.id_satuan INNER JOIN
                         dbo.l_jenis ON dbo.l_barang.id_jenis = dbo.l_jenis.id_jenis
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_satuan"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_jenis"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 217
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_barang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_barang'
GO
/****** Object:  View [dbo].[v_angsuran]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_angsuran]
AS
SELECT     dbo.l_member.nama, dbo.l_angsuran.tanggal, dbo.l_penjualan.kembalian, dbo.l_angsuran.jml_angsuran, dbo.l_penjualan.kembalian + dbo.l_angsuran.jml_angsuran AS sisa_hutang
FROM         dbo.l_angsuran INNER JOIN
                      dbo.l_member ON dbo.l_angsuran.id_member = dbo.l_member.id_member INNER JOIN
                      dbo.l_penjualan ON dbo.l_member.id_member = dbo.l_penjualan.id_member
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_angsuran"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 175
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 162
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 207
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_angsuran'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_angsuran'
GO
/****** Object:  View [dbo].[v_rpertahunpenjualan]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rpertahunpenjualan]
AS
SELECT     dbo.l_penjualan.no_faktur, dbo.l_member.nama, CASE WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'January' THEN 'Januari' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'February' THEN 'Februari' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'March' THEN 'Maret' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'April' THEN 'April' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'May' THEN 'Mei' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'June' THEN 'Juni' WHEN DATENAME(MONTH, 
                      dbo.l_penjualan.tanggal) = 'July' THEN 'Juli' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'August' THEN 'Agustus' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'September' THEN 'September' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'October' THEN 'Oktober' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'November' THEN 'November' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'December' THEN 'Desember' END AS bulan, YEAR(dbo.l_penjualan.tanggal) AS tahun, 
                      dbo.l_barang.nama_barang, dbo.l_barang.harga_beli, dbo.l_penjualan.harga_jual, dbo.l_penjualan.jumlah, dbo.l_penjualan.sub_total, 
                      dbo.l_penjualan.sub_total - dbo.l_barang.harga_beli * dbo.l_penjualan.jumlah AS laba
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
WHERE     (dbo.l_penjualan.pembayaran = 'Tunai')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpertahunpenjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpertahunpenjualan'
GO
/****** Object:  View [dbo].[v_rpertahunpembelian]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rpertahunpembelian]
AS
SELECT     dbo.l_pembelian.no_faktur, YEAR(dbo.l_pembelian.tanggal) AS tahun, dbo.l_supplier.nama_supplier, dbo.l_barang.nama_barang, dbo.l_pembelian.harga_beli, dbo.l_pembelian.jumlah, 
                      dbo.l_pembelian.total_harga
FROM         dbo.l_barang INNER JOIN
                      dbo.l_pembelian ON dbo.l_barang.id_barang = dbo.l_pembelian.id_barang INNER JOIN
                      dbo.l_supplier ON dbo.l_pembelian.id_supplier = dbo.l_supplier.id_supplier
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_pembelian"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_supplier"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpertahunpembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpertahunpembelian'
GO
/****** Object:  View [dbo].[v_rperpenjualan]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rperpenjualan]
AS
SELECT     dbo.l_penjualan.no_faktur, dbo.l_member.nama, dbo.l_penjualan.tanggal, dbo.l_barang.nama_barang, dbo.l_penjualan.harga_jual, dbo.l_penjualan.jumlah, dbo.l_penjualan.sub_total, 
                      dbo.l_penjualan.pembayaran, dbo.l_penjualan.jml_bayar, dbo.l_penjualan.kembalian
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperpenjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperpenjualan'
GO
/****** Object:  View [dbo].[v_rpernamapembelian]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rpernamapembelian]
AS
SELECT     dbo.l_pembelian.no_faktur, dbo.l_barang.nama_barang, dbo.l_pembelian.tanggal, dbo.l_supplier.nama_supplier, dbo.l_pembelian.harga_beli, dbo.l_pembelian.jumlah, 
                      dbo.l_pembelian.total_harga
FROM         dbo.l_barang INNER JOIN
                      dbo.l_pembelian ON dbo.l_barang.id_barang = dbo.l_pembelian.id_barang INNER JOIN
                      dbo.l_supplier ON dbo.l_pembelian.id_supplier = dbo.l_supplier.id_supplier
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 196
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_pembelian"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 189
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_supplier"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 168
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpernamapembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rpernamapembelian'
GO
/****** Object:  View [dbo].[v_rperbulanpenjualan]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rperbulanpenjualan]
AS
SELECT     dbo.l_penjualan.no_faktur, dbo.l_member.nama, CASE WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'January' THEN 'Januari' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'February' THEN 'Februari' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'March' THEN 'Maret' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'April' THEN 'April' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'May' THEN 'Mei' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'June' THEN 'Juni' WHEN DATENAME(MONTH, 
                      dbo.l_penjualan.tanggal) = 'July' THEN 'Juli' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'August' THEN 'Agustus' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'September' THEN 'September' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'October' THEN 'Oktober' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) 
                      = 'November' THEN 'November' WHEN DATENAME(MONTH, dbo.l_penjualan.tanggal) = 'December' THEN 'Desember' END AS bulan, YEAR(dbo.l_penjualan.tanggal) AS tahun, 
                      dbo.l_barang.nama_barang, dbo.l_barang.harga_beli, dbo.l_penjualan.harga_jual, dbo.l_penjualan.jumlah, dbo.l_penjualan.sub_total, 
                      dbo.l_penjualan.sub_total - dbo.l_barang.harga_beli * dbo.l_penjualan.jumlah AS laba
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
WHERE     (dbo.l_penjualan.pembayaran = 'Tunai')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -5
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperbulanpenjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperbulanpenjualan'
GO
/****** Object:  View [dbo].[v_rperbulanpembelian]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rperbulanpembelian]
AS
SELECT     dbo.l_pembelian.no_faktur, CASE WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'January' THEN 'Januari' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) 
                      = 'February' THEN 'Februari' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'March' THEN 'Maret' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) 
                      = 'April' THEN 'April' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'May' THEN 'Mei' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'June' THEN 'Juni' WHEN DATENAME(MONTH, 
                      dbo.l_pembelian.tanggal) = 'July' THEN 'Juli' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'August' THEN 'Agustus' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) 
                      = 'September' THEN 'September' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'October' THEN 'Oktober' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) 
                      = 'November' THEN 'November' WHEN DATENAME(MONTH, dbo.l_pembelian.tanggal) = 'December' THEN 'Desember' END AS bulan, dbo.l_supplier.nama_supplier, dbo.l_barang.nama_barang, 
                      dbo.l_pembelian.harga_beli, dbo.l_pembelian.jumlah, dbo.l_pembelian.total_harga
FROM         dbo.l_barang INNER JOIN
                      dbo.l_pembelian ON dbo.l_barang.id_barang = dbo.l_pembelian.id_barang INNER JOIN
                      dbo.l_supplier ON dbo.l_pembelian.id_supplier = dbo.l_supplier.id_supplier
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_pembelian"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_supplier"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperbulanpembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rperbulanpembelian'
GO
/****** Object:  View [dbo].[v_rkredit]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rkredit]
AS
SELECT     dbo.l_penjualan.no_faktur, dbo.l_member.nama, dbo.l_penjualan.tanggal, dbo.l_barang.nama_barang, dbo.l_penjualan.harga_jual, dbo.l_penjualan.jumlah, dbo.l_penjualan.sub_total, 
                      dbo.l_penjualan.pembayaran, dbo.l_penjualan.jml_bayar, dbo.l_penjualan.kembalian
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
WHERE     (dbo.l_penjualan.pembayaran = 'Kredit')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[14] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1995
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rkredit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rkredit'
GO
/****** Object:  View [dbo].[v_rangsuran]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_rangsuran]
AS
SELECT     dbo.l_angsuran.id_angsuran, dbo.l_angsuran.tanggal, dbo.l_member.nama, dbo.l_penjualan.kembalian, dbo.l_angsuran.jml_angsuran, 
                      dbo.l_penjualan.kembalian + dbo.l_angsuran.jml_angsuran AS sisa_hutang
FROM         dbo.l_angsuran INNER JOIN
                      dbo.l_member ON dbo.l_angsuran.id_member = dbo.l_member.id_member INNER JOIN
                      dbo.l_penjualan ON dbo.l_member.id_member = dbo.l_penjualan.id_member
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_angsuran"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 150
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rangsuran'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_rangsuran'
GO
/****** Object:  View [dbo].[v_penjualan]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_penjualan]
AS
SELECT     dbo.l_penjualan.id_penjualan, dbo.l_penjualan.no_faktur, dbo.l_member.nama, dbo.l_penjualan.tanggal, dbo.l_barang.nama_barang, dbo.l_penjualan.harga_jual, dbo.l_penjualan.jumlah, 
                      dbo.l_penjualan.sub_total, dbo.l_penjualan.pembayaran, dbo.l_penjualan.jml_bayar, dbo.l_penjualan.kembalian
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[13] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_penjualan'
GO
/****** Object:  View [dbo].[v_pembelian]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_pembelian]
AS
SELECT        dbo.l_pembelian.no_faktur, dbo.l_pembelian.tanggal, dbo.l_supplier.nama_supplier, dbo.l_barang.nama_barang, dbo.l_pembelian.harga_beli, dbo.l_pembelian.jumlah, dbo.l_pembelian.total_harga
FROM            dbo.l_barang INNER JOIN
                         dbo.l_pembelian ON dbo.l_barang.id_barang = dbo.l_pembelian.id_barang INNER JOIN
                         dbo.l_supplier ON dbo.l_pembelian.id_supplier = dbo.l_supplier.id_supplier
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_pembelian"
            Begin Extent = 
               Top = 18
               Left = 237
               Bottom = 148
               Right = 407
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "l_supplier"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_pembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_pembelian'
GO
/****** Object:  View [dbo].[v_lkredit]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_lkredit]
AS
SELECT     dbo.l_penjualan.id_member, dbo.l_member.nama
FROM         dbo.l_penjualan INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
WHERE     (dbo.l_penjualan.pembayaran = 'Kredit')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_lkredit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_lkredit'
GO
/****** Object:  View [dbo].[v_kredit]    Script Date: 01/02/2023 23:02:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_kredit]
AS
SELECT     dbo.l_penjualan.no_faktur, dbo.l_member.nama, dbo.l_penjualan.tanggal, dbo.l_barang.nama_barang, dbo.l_penjualan.kembalian
FROM         dbo.l_barang INNER JOIN
                      dbo.l_penjualan ON dbo.l_barang.id_barang = dbo.l_penjualan.id_barang INNER JOIN
                      dbo.l_member ON dbo.l_member.id_member = dbo.l_penjualan.id_member
WHERE     (dbo.l_penjualan.pembayaran = 'Kredit')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[20] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "l_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_penjualan"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "l_member"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_kredit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_kredit'
GO
/****** Object:  StoredProcedure [dbo].[updatepenjualan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatepenjualan]
	@id_penjualan varchar(255),
	@no_faktur varchar(50),
	@id_member varchar(10),
	@tanggal datetime,
	@id_barang varchar(10),
	@harga_jual int,
	@jumlah int,
	@sub_total int,
	@pembayaran varchar(10),
	@jml_bayar int,
	@kembalian int
AS
	BEGIN
	update l_penjualan set no_faktur=@no_faktur,id_member=@id_member,tanggal=@tanggal,id_barang=@id_barang,harga_jual=@harga_jual,jumlah=@jumlah,sub_total=@sub_total,
							pembayaran=@pembayaran,jml_bayar=@jml_bayar,kembalian=@kembalian
	where id_penjualan=@id_penjualan
	END
GO
/****** Object:  StoredProcedure [dbo].[updatepembelian]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatepembelian]
	@no_faktur varchar(50),
	@tanggal datetime,
	@id_supplier varchar(10),
	@id_barang varchar(10),
	@harga_beli int,
	@jumlah int,
	@total_harga int
AS
	BEGIN
		update l_pembelian set no_faktur=@no_faktur,tanggal=@tanggal,@id_supplier=@id_supplier,id_barang=@id_barang,harga_beli=@harga_beli,jumlah=@jumlah,total_harga=@total_harga
		where no_faktur=@no_faktur
	END
GO
/****** Object:  StoredProcedure [dbo].[savepenjualan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savepenjualan]
	@no_faktur varchar(50),
	@id_member varchar(10),
	@tanggal datetime,
	@id_barang varchar(10),
	@harga_jual int,
	@jumlah int,
	@sub_total int,
	@pembayaran varchar(10),
	@jml_bayar int,
	@kembalian int
AS
	BEGIN
	insert into l_penjualan (no_faktur,id_member,tanggal,id_barang,harga_jual,jumlah,sub_total,pembayaran,jml_bayar,kembalian) values (@no_faktur,@id_member,@tanggal,@id_barang,@harga_jual,@jumlah,@sub_total,@pembayaran,@jml_bayar,@kembalian)
	END
GO
/****** Object:  StoredProcedure [dbo].[savepembelian]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[savepembelian]
	@no_faktur varchar(50),
	@tanggal datetime,
	@id_supplier varchar(10),
	@id_barang varchar(10),
	@harga_beli int,
	@jumlah int,
	@total_harga int
AS
	BEGIN
	insert into l_pembelian values (@no_faktur,@tanggal,@id_supplier,@id_barang,@harga_beli,@jumlah,@total_harga)
	END
GO
/****** Object:  StoredProcedure [dbo].[deletepenjualan]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletepenjualan]
	@id_penjualan varchar(255)
AS
	BEGIN
	delete from l_penjualan where id_penjualan=@id_penjualan
	END
GO
/****** Object:  StoredProcedure [dbo].[deletepembelian]    Script Date: 01/02/2023 23:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deletepembelian]
	@no_faktur varchar(50)
AS
	BEGIN
	delete from l_pembelian where no_faktur=@no_faktur
	END
GO
/****** Object:  Default [DF_l_penjualan_id_penjualan]    Script Date: 01/02/2023 23:02:21 ******/
ALTER TABLE [dbo].[l_penjualan] ADD  CONSTRAINT [DF_l_penjualan_id_penjualan]  DEFAULT (newid()) FOR [id_penjualan]
GO
