USE [master]
GO
/****** Object:  Database [Percobaan]    Script Date: 05/12/2022 03:38:37 ******/
CREATE DATABASE [Percobaan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Percobaan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Percobaan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Percobaan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Percobaan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Percobaan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Percobaan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Percobaan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Percobaan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Percobaan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Percobaan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Percobaan] SET ARITHABORT OFF 
GO
ALTER DATABASE [Percobaan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Percobaan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Percobaan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Percobaan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Percobaan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Percobaan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Percobaan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Percobaan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Percobaan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Percobaan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Percobaan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Percobaan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Percobaan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Percobaan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Percobaan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Percobaan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Percobaan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Percobaan] SET RECOVERY FULL 
GO
ALTER DATABASE [Percobaan] SET  MULTI_USER 
GO
ALTER DATABASE [Percobaan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Percobaan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Percobaan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Percobaan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Percobaan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Percobaan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Percobaan', N'ON'
GO
ALTER DATABASE [Percobaan] SET QUERY_STORE = OFF
GO
USE [Percobaan]
GO
/****** Object:  Table [dbo].[DetailPenjualan]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPenjualan](
	[NoKwitansi] [varchar](20) NOT NULL,
	[KodeBarang] [char](4) NOT NULL,
	[Jumlah] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barang](
	[KodeBarang] [char](4) NOT NULL,
	[NamaBarang] [varchar](50) NULL,
	[Harga] [int] NULL,
	[Stok] [int] NULL,
	[Satuan] [varchar](20) NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[KodeBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_detail]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_detail]
AS
SELECT dbo.DetailPenjualan.NoKwitansi, dbo.DetailPenjualan.KodeBarang, dbo.Barang.NamaBarang, dbo.Barang.Harga, dbo.Barang.Satuan, dbo.DetailPenjualan.Jumlah
FROM   dbo.Barang INNER JOIN
             dbo.DetailPenjualan ON dbo.Barang.KodeBarang = dbo.DetailPenjualan.KodeBarang
GO
/****** Object:  Table [dbo].[Pelanggan]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelanggan](
	[PelangganId] [char](4) NOT NULL,
	[PelangganNama] [varchar](50) NULL,
	[Alamat] [varchar](100) NULL,
	[NoTelp] [varchar](13) NULL,
 CONSTRAINT [PK_Pelanggan] PRIMARY KEY CLUSTERED 
(
	[PelangganId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Penjualan]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Penjualan](
	[NoKwitansi] [varchar](20) NOT NULL,
	[TglKwitansi] [date] NULL,
	[PelangganId] [char](4) NULL,
 CONSTRAINT [PK_Penjualan] PRIMARY KEY CLUSTERED 
(
	[NoKwitansi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_penjualan]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_penjualan]
AS
SELECT dbo.Penjualan.NoKwitansi, dbo.Penjualan.TglKwitansi, dbo.Penjualan.PelangganId, dbo.Pelanggan.PelangganNama
FROM   dbo.Penjualan INNER JOIN
             dbo.Pelanggan ON dbo.Penjualan.PelangganId = dbo.Pelanggan.PelangganId
GO
/****** Object:  View [dbo].[vw_Cetak]    Script Date: 05/12/2022 03:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Cetak]
AS
SELECT dbo.DetailPenjualan.NoKwitansi, dbo.Penjualan.TglKwitansi, dbo.Penjualan.PelangganId, dbo.Pelanggan.PelangganNama, dbo.DetailPenjualan.KodeBarang, dbo.Barang.NamaBarang, dbo.Barang.Harga, dbo.DetailPenjualan.Jumlah, 
             dbo.Barang.Harga * dbo.DetailPenjualan.Jumlah AS JumlahBayar
FROM   dbo.Barang INNER JOIN
             dbo.DetailPenjualan ON dbo.Barang.KodeBarang = dbo.DetailPenjualan.KodeBarang INNER JOIN
             dbo.Penjualan ON dbo.DetailPenjualan.NoKwitansi = dbo.Penjualan.NoKwitansi CROSS JOIN
             dbo.Pelanggan
GO
ALTER TABLE [dbo].[DetailPenjualan]  WITH CHECK ADD  CONSTRAINT [FK_DetailPenjualan_Penjualan] FOREIGN KEY([NoKwitansi])
REFERENCES [dbo].[Penjualan] ([NoKwitansi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailPenjualan] CHECK CONSTRAINT [FK_DetailPenjualan_Penjualan]
GO
ALTER TABLE [dbo].[Penjualan]  WITH CHECK ADD  CONSTRAINT [FK_Penjualan_Pelanggan] FOREIGN KEY([PelangganId])
REFERENCES [dbo].[Pelanggan] ([PelangganId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Penjualan] CHECK CONSTRAINT [FK_Penjualan_Pelanggan]
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
         Begin Table = "Barang"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DetailPenjualan"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pelanggan"
            Begin Extent = 
               Top = 147
               Left = 798
               Bottom = 344
               Right = 1032
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Penjualan"
            Begin Extent = 
               Top = 218
               Left = 552
               Bottom = 388
               Right = 774
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Cetak'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Cetak'
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
         Begin Table = "Barang"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "DetailPenjualan"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
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
         Begin Table = "Pelanggan"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 570
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Penjualan"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 179
               Right = 279
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
USE [master]
GO
ALTER DATABASE [Percobaan] SET  READ_WRITE 
GO
