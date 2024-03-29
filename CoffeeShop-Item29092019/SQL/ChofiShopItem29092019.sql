USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/30/2019 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[C_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 9/30/2019 8:50:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 9/30/2019 8:50:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[OrderIID] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[ProductName] [varchar](50) NULL,
	[Qty] [int] NULL,
	[Price] [float] NULL,
	[Description] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (1, N'Monir', N'089387493', N'Mohammadpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (2, N'Monir', N'089387493', N'Mohammadpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (3, N'Afsar', N'089387493', N'Dhaka')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (4, N'Sohel', N'089387493', N'Mirpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (5, N'Tanbir', N'089387493', N'Baridhara')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (6, N'Salma', N'089387493', N'Khalist')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (13, N'qw', 12)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (14, N'efd', 10)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (15, N'jyjhg', 48)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (16, N'black', 120)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (17, N'sd', 12)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (18, N'sd', 12)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (22, N'sdgd', 200)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (23, N'dsdg', 1200)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (24, N'sdffd', 577)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (31, N'Mahedi', 120)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (32, N'Afsar', 23)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (33, N'Afsar', 20)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (35, N'Afsar', 43)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (36, N'monir', 45)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (37, N'afdf', 34)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (38, N'adad', 343)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (39, N'qwe', 20)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (40, N'ddsfdsf', 32)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderIID], [ItemId], [ProductName], [Qty], [Price], [Description]) VALUES (1, NULL, N'AUDDINFSDAR', 3, 200, N'SFDSF')
INSERT [dbo].[Order] ([OrderIID], [ItemId], [ProductName], [Qty], [Price], [Description]) VALUES (2, NULL, N'HOCFD', 3, 250, N'DS ASFDSF FDSFSD')
INSERT [dbo].[Order] ([OrderIID], [ItemId], [ProductName], [Qty], [Price], [Description]) VALUES (3, NULL, N'DFSFS', 3, 220, N'BVDGRZDFCS SZDFDF ZDS')
SET IDENTITY_INSERT [dbo].[Order] OFF
