USE [TaxCalculator]
GO
/****** Object:  Table [dbo].[PostalCode]    Script Date: 4/27/2023 4:31:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostalCode](
	[Id] [uniqueidentifier] NOT NULL,
	[Code] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTaxCalculation]    Script Date: 4/27/2023 4:31:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTaxCalculation](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[CalculationDate] [datetime] NULL,
	[PostalCode] [varchar](50) NULL,
	[TaxCalculation] [decimal](18, 2) NULL,
	[AnnualIncome] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[PostalCode] ([Id], [Code]) VALUES (N'2c1fc349-3108-406c-a3bf-a39a08c16418', N'7441                                              ')
INSERT [dbo].[PostalCode] ([Id], [Code]) VALUES (N'672320db-1942-41e6-b537-e4d83532d9d6', N'A100                                              ')
INSERT [dbo].[PostalCode] ([Id], [Code]) VALUES (N'40f72605-ad6e-48e8-8520-008664ae7417', N'7000                                              ')
INSERT [dbo].[PostalCode] ([Id], [Code]) VALUES (N'fb91afc6-26c3-4e2e-80cb-4bb1bdfea017', N'1000                                              ')
GO
INSERT [dbo].[UserTaxCalculation] ([Id], [Name], [EmailAddress], [CalculationDate], [PostalCode], [TaxCalculation], [AnnualIncome]) VALUES (N'f2fe8167-0abe-4237-a273-b66bd75909c2', NULL, N'monraybowles@gmail.com', CAST(N'2023-04-27T16:08:35.060' AS DateTime), N'7000                                              ', CAST(9878.99 AS Decimal(18, 2)), CAST(800000.00 AS Decimal(18, 2)))
GO
ALTER TABLE [dbo].[PostalCode] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[UserTaxCalculation] ADD  DEFAULT (newid()) FOR [Id]
GO
