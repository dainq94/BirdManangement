CREATE DATABASE Bird
GO
USE [Bird]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[LastUpDatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Address] [nvarchar](400) NULL,
	[OrderTime] [datetime] NOT NULL,
	[Message] [nvarchar](400) NULL,
	[Status] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Price] [float] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[CategoryID] [int] NULL,
	[Image] [varchar](5000) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/11/2023 12:48:34 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[YOB] [int] NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](400) NOT NULL,
	[Image] [varchar](1000) NULL,
	[Role] [varchar](20) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Chim Cảnh')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Chim giống')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Cám chim')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Hạt')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Cám tăng trưởng')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (6, N'Máng nước')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (7, N'Máng thức ăn')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (8, N'Lồng chim cảnh')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (9, N'Nhà chim bồ câu')
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [Status]) VALUES (1, N'khanh', N'Nguyễn Phạm Khanh', N'0988888888', N'Đồng Nai', CAST(N'2023-06-15T16:01:40.000' AS DateTime), NULL, N'ORDERED')
INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [Status]) VALUES (2, N'dai', N'Nguyễn Quốc Đại', N'0999666888', N'Đồng Nai', CAST(N'2023-07-22T16:17:35.947' AS DateTime), NULL, N'SUCCESSFUL')
INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [Status]) VALUES (5, N'nghe', N'Đào Thị Nghé', N'0147258369', N'Tiền Giang', CAST(N'2023-05-12T00:00:00.000' AS DateTime), NULL, N'ORDERED')
INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [Status]) VALUES (6, N'bombo', N'Lê Thị Nữ', N'0236999888', N'Vĩnh Long', CAST(N'2023-08-20T00:00:00.000' AS DateTime), NULL, N'SUCCESFUL')
INSERT [dbo].[Order] ([ID], [Username], [Name], [Phone], [Address], [OrderTime], [Message], [Status]) VALUES (7, N'phuc', N'123456', N'0988888888', N'An Giang', CAST(N'2023-02-25T00:00:00.000' AS DateTime), NULL, N'SUCCESFUL')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (3, 1, 3, 350000, 3)
INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (4, 2, 6, 400000, 4)
INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (5, 5, 7, 450000, 5)
INSERT [dbo].[OrderDetail] ([ID], [OrderID], [ProductID], [Price], [Quantity]) VALUES (6, 6, 8, 550000, 3)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (3, N'Chim vành khuyên', N'Đây là mô tả', 30, 220000, 2, N'https://lh6.googleusercontent.com/-hM9IXjLEYFU/UhxhgueY4LI/AAAAAAAABXg/pWZ1Oda054c/w640-h402-no/ban-chim-vanh-khuyen.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (6, N'Vẹt xanh', N'Chim quý hiếm', 15, 110000, 1, N'https://jve62b.p3cdn1.secureserver.net/wp-content/uploads/2022/04/Ky-thuat-nuoi-vet-xanh-danh-cho-nguoi-moi.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (7, N'Chim Cu Gáy', N'Chim cu rừng Tây Nguyên, giống chim cu gáy rất hay. Thuộc dòng chim cu.', 33, 333333, 2, N'https://hoisvcvn.org.vn/Uploads/images/5-chat-giong-cua-chim-cu-gay.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (8, N'Chích chòe than', N'Chích chòe quý hiếm ở Châu Phi', 5, 400000, 2, N'https://vuongquocloaivat.com/wp-content/uploads/2019/02/choe-than-mai-compressed.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (9, N'Sáo đầu trắng', N'Sáo đầu trắng rất khôn, dễ nuôi', 33, 350000, 2, N'https://birdwatchingvietnam.net/images/bird/956/vinous-breasted-starling-2583.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (10, N'Chim họa mi bổi', N'Chim họa mi nhập khẩu Úc, rất đẹp', 55, 555000, 1, N'http://camtuanmi.vn/uploads/images/adf.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (11, N'Sáo đầu trắng', N'Dòng chim cực kì quý hiếm, sống ở Châu Mỹ', 10, 1000000, 2, N'https://birdwatchingvietnam.net/images/bird/956/vinous-breasted-starling-2583.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (12, N'Lồng chim vuông', N'Lồng chim có kích thước 30x30x30', 200, 100000, 8, N'https://minhocmit.com/wp-content/uploads/2022/03/z3282856349995_a4a6c60d2cf208336db7191051e9d6db-1024x1365.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (13, N'Cám chim', N'Cám dành cho nhiều loại chim: chim sáo, chim chích chòe', 300, 50000, 3, N'https://sanhangre.net/image/data/tugold/cam-chaomao.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (14, N'Lồng tròn xanh', N'Lồng tròn xanh dành cho chim sáo, đầu rìu', 222, 100000, 8, N'https://salt.tikicdn.com/cache/280x280/ts/product/63/f4/f7/26188aa5de5706edc9b1f8eee255f53d.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (15, N'Khay đựng nước', N'Khay đựng nước kích thức 5x5x5 dành cho chim', 555, 20000, 6, N'https://cf.shopee.vn/file/sg-11134201-7qvfu-lg39v7hgcgc57f.jpg', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Description], [Quantity], [Price], [CategoryID], [Image], [Status]) VALUES (16, N'Hạt dinh dưỡng cho chim', N'Hạt nhiều chất dinh dưỡng giúp chim phát triển tốt', 332, 50000, 4, N'https://hiepdongnai.com/wp-content/uploads/2022/12/z3959452634275_83a21ff9556bffb3c7311641e5592770-600x801.jpg', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'admin', N'123456', N'Administrator', N'admin@gmail.com', N'0988888888', 2002, N'Nam', N'TP.HCM', NULL, N'Admin', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'akaza', N'111111', N'Lương Tấn Hải', N'hai@gmail.com', N'0332456456', 2000, N'Nam', N'Bắc Ninh', NULL, N'User', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'bombo', N'222222', N'Lê Thị Nữ', N'nu@gmail.com', N'0236999888', 1999, N'Nữ', N'Vĩnh Long', NULL, N'User', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'dai', N'123456', N'Nguyễn Quốc Đại', N'dai@gmail.com', N'0111222666', 2002, N'Nam', N'Đồng Nai', NULL, N'User', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'khanh', N'123456', N'Nguyễ Phạm Khanh', N'khanh@gmail.com', N'0222333444', 2002, N'Nam', N'Đồng Nai', NULL, N'User', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'nghe', N'333333', N'Đào Thị Nghé', N'nghe@gmail.com', N'0147258369', 1998, N'Nữ', N'Tiền Giang', NULL, N'User', 0)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'phuc', N'123456', N'Nguyễn Tấn Phúc', N'phuc@gmail.com', N'0988888888', 2002, N'Nam', N'An Giang', NULL, N'Staff', 1)
INSERT [dbo].[User] ([Username], [Password], [Name], [Email], [Phone], [YOB], [Gender], [Address], [Image], [Role], [Status]) VALUES (N'teo', N'111111', N'Nguyễn Văn Tèo', N'teo@gmail.com', N'0355636363', 1995, N'Nam', N'Hà Nội', NULL, N'Staff', 0)
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
