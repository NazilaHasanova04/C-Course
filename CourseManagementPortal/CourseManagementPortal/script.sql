USE [Students]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](15) NULL,
	[Duration_months] [int] NULL,
	[Price] [int] NULL,
	[CreationTime] [date] NULL,
	[ModificationTime] [date] NULL,
	[StudentCount] [int] NULL,
	[StartDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departments]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maths]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maths](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[15-12-2024] [nvarchar](100) NULL,
	[19-12-2024] [nvarchar](100) NULL,
	[23-12-2024] [nvarchar](100) NULL,
	[26-12-2024] [nvarchar](100) NULL,
	[30-12-2024] [nvarchar](100) NULL,
	[02-01-2025] [nvarchar](100) NULL,
	[06-01-2025] [nvarchar](100) NULL,
	[09-01-2025] [nvarchar](100) NULL,
	[13-01-2025] [nvarchar](100) NULL,
	[16-01-2025] [nvarchar](100) NULL,
	[20-01-2025] [nvarchar](100) NULL,
	[23-01-2025] [nvarchar](100) NULL,
	[27-01-2025] [nvarchar](100) NULL,
	[30-01-2025] [nvarchar](100) NULL,
	[03-02-2025] [nvarchar](100) NULL,
	[06-02-2025] [nvarchar](100) NULL,
	[10-02-2025] [nvarchar](100) NULL,
	[13-02-2025] [nvarchar](100) NULL,
	[17-02-2025] [nvarchar](100) NULL,
	[20-02-2025] [nvarchar](100) NULL,
	[24-02-2025] [nvarchar](100) NULL,
	[27-02-2025] [nvarchar](100) NULL,
	[03-03-2025] [nvarchar](100) NULL,
	[06-03-2025] [nvarchar](100) NULL,
	[10-03-2025] [nvarchar](100) NULL,
	[13-03-2025] [nvarchar](100) NULL,
	[17-03-2025] [nvarchar](100) NULL,
	[20-03-2025] [nvarchar](100) NULL,
	[24-03-2025] [nvarchar](100) NULL,
	[27-03-2025] [nvarchar](100) NULL,
	[31-03-2025] [nvarchar](100) NULL,
	[03-04-2025] [nvarchar](100) NULL,
	[07-04-2025] [nvarchar](100) NULL,
	[10-04-2025] [nvarchar](100) NULL,
	[14-04-2025] [nvarchar](100) NULL,
	[17-04-2025] [nvarchar](100) NULL,
	[21-04-2025] [nvarchar](100) NULL,
	[24-04-2025] [nvarchar](100) NULL,
	[28-04-2025] [nvarchar](100) NULL,
	[01-05-2025] [nvarchar](100) NULL,
	[05-05-2025] [nvarchar](100) NULL,
	[08-05-2025] [nvarchar](100) NULL,
	[12-05-2025] [nvarchar](100) NULL,
	[15-05-2025] [nvarchar](100) NULL,
	[19-05-2025] [nvarchar](100) NULL,
	[22-05-2025] [nvarchar](100) NULL,
	[26-05-2025] [nvarchar](100) NULL,
	[29-05-2025] [nvarchar](100) NULL,
	[02-06-2025] [nvarchar](100) NULL,
	[05-06-2025] [nvarchar](100) NULL,
	[09-06-2025] [nvarchar](100) NULL,
	[12-06-2025] [nvarchar](100) NULL,
	[16-06-2025] [nvarchar](100) NULL,
	[19-06-2025] [nvarchar](100) NULL,
	[23-06-2025] [nvarchar](100) NULL,
	[26-06-2025] [nvarchar](100) NULL,
	[30-06-2025] [nvarchar](100) NULL,
	[03-07-2025] [nvarchar](100) NULL,
	[07-07-2025] [nvarchar](100) NULL,
	[10-07-2025] [nvarchar](100) NULL,
	[14-07-2025] [nvarchar](100) NULL,
	[17-07-2025] [nvarchar](100) NULL,
	[21-07-2025] [nvarchar](100) NULL,
	[24-07-2025] [nvarchar](100) NULL,
	[28-07-2025] [nvarchar](100) NULL,
	[31-07-2025] [nvarchar](100) NULL,
	[04-08-2025] [nvarchar](100) NULL,
	[07-08-2025] [nvarchar](100) NULL,
	[11-08-2025] [nvarchar](100) NULL,
	[14-08-2025] [nvarchar](100) NULL,
	[18-08-2025] [nvarchar](100) NULL,
	[21-08-2025] [nvarchar](100) NULL,
	[25-08-2025] [nvarchar](100) NULL,
	[28-08-2025] [nvarchar](100) NULL,
	[01-09-2025] [nvarchar](100) NULL,
	[04-09-2025] [nvarchar](100) NULL,
	[08-09-2025] [nvarchar](100) NULL,
	[11-09-2025] [nvarchar](100) NULL,
	[15-09-2025] [nvarchar](100) NULL,
	[18-09-2025] [nvarchar](100) NULL,
	[22-09-2025] [nvarchar](100) NULL,
	[25-09-2025] [nvarchar](100) NULL,
	[29-09-2025] [nvarchar](100) NULL,
	[02-10-2025] [nvarchar](100) NULL,
	[06-10-2025] [nvarchar](100) NULL,
	[09-10-2025] [nvarchar](100) NULL,
	[13-10-2025] [nvarchar](100) NULL,
	[16-10-2025] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maths_Notes]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maths_Notes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[15-12-2024] [nvarchar](100) NULL,
	[19-12-2024] [nvarchar](100) NULL,
	[23-12-2024] [nvarchar](100) NULL,
	[26-12-2024] [nvarchar](100) NULL,
	[30-12-2024] [nvarchar](100) NULL,
	[02-01-2025] [nvarchar](100) NULL,
	[06-01-2025] [nvarchar](100) NULL,
	[09-01-2025] [nvarchar](100) NULL,
	[13-01-2025] [nvarchar](100) NULL,
	[16-01-2025] [nvarchar](100) NULL,
	[20-01-2025] [nvarchar](100) NULL,
	[23-01-2025] [nvarchar](100) NULL,
	[27-01-2025] [nvarchar](100) NULL,
	[30-01-2025] [nvarchar](100) NULL,
	[03-02-2025] [nvarchar](100) NULL,
	[06-02-2025] [nvarchar](100) NULL,
	[10-02-2025] [nvarchar](100) NULL,
	[13-02-2025] [nvarchar](100) NULL,
	[17-02-2025] [nvarchar](100) NULL,
	[20-02-2025] [nvarchar](100) NULL,
	[24-02-2025] [nvarchar](100) NULL,
	[27-02-2025] [nvarchar](100) NULL,
	[03-03-2025] [nvarchar](100) NULL,
	[06-03-2025] [nvarchar](100) NULL,
	[10-03-2025] [nvarchar](100) NULL,
	[13-03-2025] [nvarchar](100) NULL,
	[17-03-2025] [nvarchar](100) NULL,
	[20-03-2025] [nvarchar](100) NULL,
	[24-03-2025] [nvarchar](100) NULL,
	[27-03-2025] [nvarchar](100) NULL,
	[31-03-2025] [nvarchar](100) NULL,
	[03-04-2025] [nvarchar](100) NULL,
	[07-04-2025] [nvarchar](100) NULL,
	[10-04-2025] [nvarchar](100) NULL,
	[14-04-2025] [nvarchar](100) NULL,
	[17-04-2025] [nvarchar](100) NULL,
	[21-04-2025] [nvarchar](100) NULL,
	[24-04-2025] [nvarchar](100) NULL,
	[28-04-2025] [nvarchar](100) NULL,
	[01-05-2025] [nvarchar](100) NULL,
	[05-05-2025] [nvarchar](100) NULL,
	[08-05-2025] [nvarchar](100) NULL,
	[12-05-2025] [nvarchar](100) NULL,
	[15-05-2025] [nvarchar](100) NULL,
	[19-05-2025] [nvarchar](100) NULL,
	[22-05-2025] [nvarchar](100) NULL,
	[26-05-2025] [nvarchar](100) NULL,
	[29-05-2025] [nvarchar](100) NULL,
	[02-06-2025] [nvarchar](100) NULL,
	[05-06-2025] [nvarchar](100) NULL,
	[09-06-2025] [nvarchar](100) NULL,
	[12-06-2025] [nvarchar](100) NULL,
	[16-06-2025] [nvarchar](100) NULL,
	[19-06-2025] [nvarchar](100) NULL,
	[23-06-2025] [nvarchar](100) NULL,
	[26-06-2025] [nvarchar](100) NULL,
	[30-06-2025] [nvarchar](100) NULL,
	[03-07-2025] [nvarchar](100) NULL,
	[07-07-2025] [nvarchar](100) NULL,
	[10-07-2025] [nvarchar](100) NULL,
	[14-07-2025] [nvarchar](100) NULL,
	[17-07-2025] [nvarchar](100) NULL,
	[21-07-2025] [nvarchar](100) NULL,
	[24-07-2025] [nvarchar](100) NULL,
	[28-07-2025] [nvarchar](100) NULL,
	[31-07-2025] [nvarchar](100) NULL,
	[04-08-2025] [nvarchar](100) NULL,
	[07-08-2025] [nvarchar](100) NULL,
	[11-08-2025] [nvarchar](100) NULL,
	[14-08-2025] [nvarchar](100) NULL,
	[18-08-2025] [nvarchar](100) NULL,
	[21-08-2025] [nvarchar](100) NULL,
	[25-08-2025] [nvarchar](100) NULL,
	[28-08-2025] [nvarchar](100) NULL,
	[01-09-2025] [nvarchar](100) NULL,
	[04-09-2025] [nvarchar](100) NULL,
	[08-09-2025] [nvarchar](100) NULL,
	[11-09-2025] [nvarchar](100) NULL,
	[15-09-2025] [nvarchar](100) NULL,
	[18-09-2025] [nvarchar](100) NULL,
	[22-09-2025] [nvarchar](100) NULL,
	[25-09-2025] [nvarchar](100) NULL,
	[29-09-2025] [nvarchar](100) NULL,
	[02-10-2025] [nvarchar](100) NULL,
	[06-10-2025] [nvarchar](100) NULL,
	[09-10-2025] [nvarchar](100) NULL,
	[13-10-2025] [nvarchar](100) NULL,
	[16-10-2025] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[BirthDate] [date] NULL,
	[RegistrationTime] [date] NULL,
	[PhoneNumber] [varchar](18) NULL,
	[Email] [varchar](25) NULL,
	[Course] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentsCourses]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentsCourses](
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 8/7/2024 7:08:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[BirthDate] [date] NULL,
	[Profession] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [CourseName], [Duration_months], [Price], [CreationTime], [ModificationTime], [StudentCount], [StartDate]) VALUES (5, N'Physics', 5, 170, CAST(N'2024-06-25' AS Date), CAST(N'2024-07-10' AS Date), 0, CAST(N'2024-10-16' AS Date))
INSERT [dbo].[Course] ([Id], [CourseName], [Duration_months], [Price], [CreationTime], [ModificationTime], [StudentCount], [StartDate]) VALUES (8, N'Algorithms', 10, 200, CAST(N'2024-07-09' AS Date), CAST(N'2024-07-09' AS Date), 0, CAST(N'2024-10-01' AS Date))
INSERT [dbo].[Course] ([Id], [CourseName], [Duration_months], [Price], [CreationTime], [ModificationTime], [StudentCount], [StartDate]) VALUES (10, N'Maths', 10, 250, CAST(N'2024-07-09' AS Date), NULL, 0, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[Course] ([Id], [CourseName], [Duration_months], [Price], [CreationTime], [ModificationTime], [StudentCount], [StartDate]) VALUES (1006, N'Chemistry', 7, 170, CAST(N'2024-07-10' AS Date), NULL, 0, CAST(N'2024-08-20' AS Date))
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[departments] ON 

INSERT [dbo].[departments] ([Id], [Name], [CreatedDate]) VALUES (1, N'Nazila', CAST(N'2004-12-09T12:00:00.000' AS DateTime))
INSERT [dbo].[departments] ([Id], [Name], [CreatedDate]) VALUES (5, N'Sabir', CAST(N'2004-08-14T00:00:00.000' AS DateTime))
INSERT [dbo].[departments] ([Id], [Name], [CreatedDate]) VALUES (6, N'Rasim', CAST(N'2000-08-23T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Maths] ON 

INSERT [dbo].[Maths] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (1, N'Nulana Gulmaliyeva', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+')
INSERT [dbo].[Maths] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (2, N'Seymur Babazade', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+')
INSERT [dbo].[Maths] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (3, N'Aga Hasanov', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+', N'+')
SET IDENTITY_INSERT [dbo].[Maths] OFF
GO
SET IDENTITY_INSERT [dbo].[Maths_Notes] ON 

INSERT [dbo].[Maths_Notes] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (1, N'Nulana Gulmaliyeva', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ')
INSERT [dbo].[Maths_Notes] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (2, N'Seymur Babazade', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ')
INSERT [dbo].[Maths_Notes] ([Id], [Name], [15-12-2024], [19-12-2024], [23-12-2024], [26-12-2024], [30-12-2024], [02-01-2025], [06-01-2025], [09-01-2025], [13-01-2025], [16-01-2025], [20-01-2025], [23-01-2025], [27-01-2025], [30-01-2025], [03-02-2025], [06-02-2025], [10-02-2025], [13-02-2025], [17-02-2025], [20-02-2025], [24-02-2025], [27-02-2025], [03-03-2025], [06-03-2025], [10-03-2025], [13-03-2025], [17-03-2025], [20-03-2025], [24-03-2025], [27-03-2025], [31-03-2025], [03-04-2025], [07-04-2025], [10-04-2025], [14-04-2025], [17-04-2025], [21-04-2025], [24-04-2025], [28-04-2025], [01-05-2025], [05-05-2025], [08-05-2025], [12-05-2025], [15-05-2025], [19-05-2025], [22-05-2025], [26-05-2025], [29-05-2025], [02-06-2025], [05-06-2025], [09-06-2025], [12-06-2025], [16-06-2025], [19-06-2025], [23-06-2025], [26-06-2025], [30-06-2025], [03-07-2025], [07-07-2025], [10-07-2025], [14-07-2025], [17-07-2025], [21-07-2025], [24-07-2025], [28-07-2025], [31-07-2025], [04-08-2025], [07-08-2025], [11-08-2025], [14-08-2025], [18-08-2025], [21-08-2025], [25-08-2025], [28-08-2025], [01-09-2025], [04-09-2025], [08-09-2025], [11-09-2025], [15-09-2025], [18-09-2025], [22-09-2025], [25-09-2025], [29-09-2025], [02-10-2025], [06-10-2025], [09-10-2025], [13-10-2025], [16-10-2025]) VALUES (3, N'Aga Hasanov', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ')
SET IDENTITY_INSERT [dbo].[Maths_Notes] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [RegistrationTime], [PhoneNumber], [Email], [Course]) VALUES (26, N'Nulana', N'Gulmaliyeva', CAST(N'2003-02-18' AS Date), CAST(N'2024-07-10' AS Date), N'(+994)55 342 78 45', N'nurlana.gul@gmail.com', N'Maths')
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [RegistrationTime], [PhoneNumber], [Email], [Course]) VALUES (27, N'Seymur', N'Babazade', CAST(N'1999-06-26' AS Date), CAST(N'2024-07-10' AS Date), N'(+994)77 654 23 12', N'seymur.babazade@gmail.com', N'Maths')
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [RegistrationTime], [PhoneNumber], [Email], [Course]) VALUES (28, N'Aga', N'Hasanov', CAST(N'1993-02-28' AS Date), CAST(N'2024-07-10' AS Date), N'(+994)55 341 87 67', N'aga.hasanov12@gmail.com', N'Maths')
INSERT [dbo].[Student] ([Id], [Name], [Surname], [BirthDate], [RegistrationTime], [PhoneNumber], [Email], [Course]) VALUES (1024, N'Fuad', N'Aliyev', CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date), N'(+994)77 345 12 43', N'fuad.aliyev@gmail.com', N'Chemistry')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
INSERT [dbo].[studentsCourses] ([StartDate], [EndDate], [CourseName], [TeacherName]) VALUES (CAST(N'2024-12-15' AS Date), CAST(N'2025-10-20' AS Date), N'Maths', N'Gulshan Hasanova')
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (1, N'Gulshan', N'Hasanova', CAST(N'1989-09-08' AS Date), N'Maths')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (2, N'Elchin', N'Abdullayev', CAST(N'1979-03-18' AS Date), N'Chemistry')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (3, N'Ali', N'Quliyev', CAST(N'1991-05-28' AS Date), N'Physics')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (4, N'Sabina', N'Ibadova', CAST(N'1999-05-10' AS Date), N'Programming')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (5, N'Sabuhi', N'Sultanov', CAST(N'2000-03-19' AS Date), N'Programming')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (6, N'Ceyhun', N'Huseynov', CAST(N'1995-08-29' AS Date), N'English')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (7, N'Sevda', N'Musayeva', CAST(N'1975-01-29' AS Date), N'Maths')
INSERT [dbo].[Teacher] ([Id], [Name], [Surname], [BirthDate], [Profession]) VALUES (1008, N'Shahla', N'Huseynova', CAST(N'1975-01-06' AS Date), N'Algorithms')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Course] ADD  DEFAULT ((0)) FOR [StudentCount]
GO
ALTER TABLE [dbo].[departments] ADD  CONSTRAINT [DF_Departments_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
