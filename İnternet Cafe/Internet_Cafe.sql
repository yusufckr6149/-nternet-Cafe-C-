USE [InternetCafe2]
GO
/****** Object:  Table [dbo].[TBLHareketler]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLHareketler](
	[HareketID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[MasaID] [int] NOT NULL,
	[Masa] [varchar](50) NOT NULL,
	[İstekTuru] [varchar](150) NOT NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLKullanici]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NULL,
	[Adres] [varchar](500) NULL,
	[Email] [varchar](50) NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Sifre] [varchar](50) NOT NULL,
	[Gorevi] [varchar](50) NOT NULL,
	[Tarih] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLMasalar]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLMasalar](
	[MasaID] [int] IDENTITY(1,1) NOT NULL,
	[Masalar] [varchar](50) NOT NULL,
	[Durumu] [varchar](50) NOT NULL,
	[Aciklama] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MasaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSaatUcreti]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSaatUcreti](
	[SaatUcretiID] [int] IDENTITY(1,1) NOT NULL,
	[SaatUcreti] [decimal](18, 2) NOT NULL,
	[UcretTuru] [varchar](500) NULL,
	[Aciklama] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaatUcretiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSatis]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSatis](
	[SatisID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[MasaID] [int] NOT NULL,
	[AcilisTuru] [varchar](50) NULL,
	[BaslangicSaati] [datetime] NOT NULL,
	[BitisSaati] [datetime] NOT NULL,
	[Sure] [decimal](18, 2) NOT NULL,
	[Tutar] [decimal](18, 2) NULL,
	[Aciklama] [varchar](500) NOT NULL,
	[Tarih] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SatisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSepet]    Script Date: 8.07.2024 19:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSepet](
	[SepetID] [int] IDENTITY(1,1) NOT NULL,
	[MasaID] [int] NOT NULL,
	[Masa] [varchar](50) NOT NULL,
	[AcilisTuru] [varchar](50) NOT NULL,
	[Baslangic] [datetime] NOT NULL,
	[Tarih] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SepetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLHareketler] ON 

INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (1, 1, 5, N'Masa 3', N'60', N'yapılmadı', CAST(N'2024-06-17T17:58:00.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (5, 2, 10, N'Masa 10', N'90', N'Yapılmadı', CAST(N'2024-07-17T12:00:00.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (27, 1, 3, N'Masa -3', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:12:31.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (28, 1, 3, N'Masa -3', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:32:51.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (29, 1, 3, N'Masa -3', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:39:12.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (30, 1, 4, N'Masa -4', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:39:26.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (31, 1, 4, N'Masa -4', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:39:31.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (32, 1, 4, N'Masa -4', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:39:44.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (33, 1, 4, N'Masa -4', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:41:40.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (34, 1, 3, N'Masa -3', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T21:41:45.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (35, 1, 5, N'Masa -5', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-04T22:02:38.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (36, 1, 1, N'Masa -1', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-05T11:47:31.000' AS DateTime))
INSERT [dbo].[TBLHareketler] ([HareketID], [KullaniciID], [MasaID], [Masa], [İstekTuru], [Aciklama], [Tarih]) VALUES (37, 1, 3, N'Masa -3', N'Süresiz masa Acma İsteği Gönderdi', N'Yapılmadı', CAST(N'2024-07-05T12:09:12.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBLHareketler] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLKullanici] ON 

INSERT [dbo].[TBLKullanici] ([KullaniciID], [AdiSoyadi], [Telefon], [Adres], [Email], [KullaniciAdi], [Sifre], [Gorevi], [Tarih]) VALUES (1, N'Yusuf Çakır', N'5358770469', N'of', N'cakiry200@gmail.com', N'admin', N'123', N'Yönetici', CAST(N'2024-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[TBLKullanici] ([KullaniciID], [AdiSoyadi], [Telefon], [Adres], [Email], [KullaniciAdi], [Sifre], [Gorevi], [Tarih]) VALUES (2, N'Kerem yıldırım', N'231231312', N'samsun', N'yıldırım@gmail.com', N'kullanici', N'456', N'Kullanıcı', CAST(N'2020-02-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBLKullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLMasalar] ON 

INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (1, N'Masa-1', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (2, N'Masa-2', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (3, N'Masa-3', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (4, N'Masa-4', N'DOLU', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (5, N'Masa-5', N'DOLU', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (6, N'Masa-6', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (7, N'Masa-7', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (8, N'Masa-8', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (9, N'Masa-9', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (10, N'Masa-10', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (11, N'Masa-11', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (12, N'Masa-12', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (13, N'Masa-13', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (14, N'Masa-14', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (15, N'Masa-15', N'BOŞ', N'Açıklama Yapılmadı')
INSERT [dbo].[TBLMasalar] ([MasaID], [Masalar], [Durumu], [Aciklama]) VALUES (16, N'Masa-16', N'DOLU', N'Açıklama Yapılmadı')
SET IDENTITY_INSERT [dbo].[TBLMasalar] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLSaatUcreti] ON 

INSERT [dbo].[TBLSaatUcreti] ([SaatUcretiID], [SaatUcreti], [UcretTuru], [Aciklama]) VALUES (1, CAST(2.00 AS Decimal(18, 2)), N'Normal', N'Yapılmadı')
INSERT [dbo].[TBLSaatUcreti] ([SaatUcretiID], [SaatUcreti], [UcretTuru], [Aciklama]) VALUES (2, CAST(1.50 AS Decimal(18, 2)), N'İndirimli', N'Yapılmadı')
SET IDENTITY_INSERT [dbo].[TBLSaatUcreti] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLSatis] ON 

INSERT [dbo].[TBLSatis] ([SatisID], [KullaniciID], [MasaID], [AcilisTuru], [BaslangicSaati], [BitisSaati], [Sure], [Tutar], [Aciklama], [Tarih]) VALUES (1002, 1, 16, N'45', CAST(N'2024-07-03T19:52:57.000' AS DateTime), CAST(N'2024-07-04T21:41:09.000' AS DateTime), CAST(25.80 AS Decimal(18, 2)), CAST(51.61 AS Decimal(18, 2)), N'Açıklama Yapılmadı', CAST(N'2024-07-03T19:52:57.000' AS DateTime))
INSERT [dbo].[TBLSatis] ([SatisID], [KullaniciID], [MasaID], [AcilisTuru], [BaslangicSaati], [BitisSaati], [Sure], [Tutar], [Aciklama], [Tarih]) VALUES (1003, 1, 8, N'Süresiz', CAST(N'2024-07-04T21:41:49.000' AS DateTime), CAST(N'2024-07-04T22:02:32.000' AS DateTime), CAST(0.35 AS Decimal(18, 2)), CAST(0.69 AS Decimal(18, 2)), N'Açıklama Yapılmadı', CAST(N'2024-07-04T21:41:49.000' AS DateTime))
INSERT [dbo].[TBLSatis] ([SatisID], [KullaniciID], [MasaID], [AcilisTuru], [BaslangicSaati], [BitisSaati], [Sure], [Tutar], [Aciklama], [Tarih]) VALUES (1004, 1, 16, N'Süresiz', CAST(N'2024-06-17T19:58:24.000' AS DateTime), CAST(N'2024-07-04T22:03:08.000' AS DateTime), CAST(410.08 AS Decimal(18, 2)), CAST(820.16 AS Decimal(18, 2)), N'Açıklama Yapılmadı', CAST(N'2024-06-17T19:58:24.000' AS DateTime))
INSERT [dbo].[TBLSatis] ([SatisID], [KullaniciID], [MasaID], [AcilisTuru], [BaslangicSaati], [BitisSaati], [Sure], [Tutar], [Aciklama], [Tarih]) VALUES (1005, 1, 11, N'Süresiz', CAST(N'2024-07-04T21:59:06.000' AS DateTime), CAST(N'2024-07-05T11:46:30.000' AS DateTime), CAST(13.79 AS Decimal(18, 2)), CAST(27.58 AS Decimal(18, 2)), N'Açıklama Yapılmadı', CAST(N'2024-07-04T21:59:06.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBLSatis] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLSepet] ON 

INSERT [dbo].[TBLSepet] ([SepetID], [MasaID], [Masa], [AcilisTuru], [Baslangic], [Tarih]) VALUES (4014, 12, N'Masa-12', N'Süresiz', CAST(N'2024-07-05T11:46:49.070' AS DateTime), CAST(N'2024-07-05T11:46:49.070' AS DateTime))
INSERT [dbo].[TBLSepet] ([SepetID], [MasaID], [Masa], [AcilisTuru], [Baslangic], [Tarih]) VALUES (4015, 8, N'MASA -8', N'Süresiz', CAST(N'2024-06-17T19:58:10.000' AS DateTime), CAST(N'2024-06-17T19:58:10.000' AS DateTime))
INSERT [dbo].[TBLSepet] ([SepetID], [MasaID], [Masa], [AcilisTuru], [Baslangic], [Tarih]) VALUES (4016, 4, N'Masa-4', N'Süresiz', CAST(N'2024-07-05T12:10:23.270' AS DateTime), CAST(N'2024-07-05T12:10:23.270' AS DateTime))
INSERT [dbo].[TBLSepet] ([SepetID], [MasaID], [Masa], [AcilisTuru], [Baslangic], [Tarih]) VALUES (4017, 5, N'MASA -5', N'30', CAST(N'2024-07-04T21:41:53.000' AS DateTime), CAST(N'2024-07-04T21:41:53.000' AS DateTime))
INSERT [dbo].[TBLSepet] ([SepetID], [MasaID], [Masa], [AcilisTuru], [Baslangic], [Tarih]) VALUES (4018, 16, N'Masa-16', N'Süresiz', CAST(N'2024-07-05T12:11:34.643' AS DateTime), CAST(N'2024-07-05T12:11:34.643' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBLSepet] OFF
GO
ALTER TABLE [dbo].[TBLHareketler]  WITH CHECK ADD  CONSTRAINT [FK_TBLHareketler_TBLKullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[TBLKullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[TBLHareketler] CHECK CONSTRAINT [FK_TBLHareketler_TBLKullanici]
GO
ALTER TABLE [dbo].[TBLHareketler]  WITH CHECK ADD  CONSTRAINT [FK_TBLHareketler_TBLMasalar] FOREIGN KEY([MasaID])
REFERENCES [dbo].[TBLMasalar] ([MasaID])
GO
ALTER TABLE [dbo].[TBLHareketler] CHECK CONSTRAINT [FK_TBLHareketler_TBLMasalar]
GO
ALTER TABLE [dbo].[TBLSatis]  WITH CHECK ADD  CONSTRAINT [FK_TBLSatis_TBLKullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[TBLKullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[TBLSatis] CHECK CONSTRAINT [FK_TBLSatis_TBLKullanici]
GO
ALTER TABLE [dbo].[TBLSatis]  WITH CHECK ADD  CONSTRAINT [FK_TBLSatis_TBLMasalar] FOREIGN KEY([MasaID])
REFERENCES [dbo].[TBLMasalar] ([MasaID])
GO
ALTER TABLE [dbo].[TBLSatis] CHECK CONSTRAINT [FK_TBLSatis_TBLMasalar]
GO
ALTER TABLE [dbo].[TBLSatis]  WITH CHECK ADD  CONSTRAINT [FK_TBLSatis_TBLMasalar1] FOREIGN KEY([MasaID])
REFERENCES [dbo].[TBLMasalar] ([MasaID])
GO
ALTER TABLE [dbo].[TBLSatis] CHECK CONSTRAINT [FK_TBLSatis_TBLMasalar1]
GO
ALTER TABLE [dbo].[TBLSepet]  WITH CHECK ADD  CONSTRAINT [FK_TBLSepet_TBLMasalar] FOREIGN KEY([MasaID])
REFERENCES [dbo].[TBLMasalar] ([MasaID])
GO
ALTER TABLE [dbo].[TBLSepet] CHECK CONSTRAINT [FK_TBLSepet_TBLMasalar]
GO
