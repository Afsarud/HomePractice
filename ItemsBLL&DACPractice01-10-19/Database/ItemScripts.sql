USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/2/2019 3:12:46 AM ******/
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
/****** Object:  Table [dbo].[Items]    Script Date: 10/2/2019 3:12:47 AM ******/
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
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (1, N'Monir', N'089387493', N'Mohammadpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (2, N'Monir', N'089387493', N'Mohammadpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (3, N'Afsar', N'089387493', N'Dhaka')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (4, N'Sohel', N'089387493', N'Mirpur')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (5, N'Tanbir', N'089387493', N'Baridhara')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (6, N'Salma', N'089387493', N'Khalist')
INSERT [dbo].[Customer] ([C_ID], [Name], [Contact], [Address]) VALUES (7, N'dsfd', N'2343', N'sfds')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (44, N'Black', 120)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (45, N'Col', 100)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (46, N'Hor', 90)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (47, N'afsareff', 765)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (48, N'Sumia', 180)
INSERT [dbo].[Items] ([ItemId], [Name], [Price]) VALUES (50, N'Sumai', 76)
SET IDENTITY_INSERT [dbo].[Items] OFF
