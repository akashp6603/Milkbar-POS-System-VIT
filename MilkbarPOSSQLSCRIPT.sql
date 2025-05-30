USE [master]
GO
/****** Object:  Database [MilkbarPOS]    Script Date: 18-May-2025 9:24:54 AM ******/
CREATE DATABASE [MilkbarPOS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MilkbarPOS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MilkbarPOS.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MilkbarPOS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MilkbarPOS_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MilkbarPOS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MilkbarPOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MilkbarPOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MilkbarPOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MilkbarPOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MilkbarPOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MilkbarPOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [MilkbarPOS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MilkbarPOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MilkbarPOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MilkbarPOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MilkbarPOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MilkbarPOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MilkbarPOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MilkbarPOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MilkbarPOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MilkbarPOS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MilkbarPOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MilkbarPOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MilkbarPOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MilkbarPOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MilkbarPOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MilkbarPOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MilkbarPOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MilkbarPOS] SET RECOVERY FULL 
GO
ALTER DATABASE [MilkbarPOS] SET  MULTI_USER 
GO
ALTER DATABASE [MilkbarPOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MilkbarPOS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MilkbarPOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MilkbarPOS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MilkbarPOS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MilkbarPOS', N'ON'
GO
USE [MilkbarPOS]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[QuantityInStock] [int] NOT NULL,
	[Category] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionItems]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionItems](
	[TransactionItemID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[TransactionDate] [datetime] NULL DEFAULT (getdate()),
	[TotalAmount] [decimal](10, 2) NULL,
	[PaymentMethod] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[PasswordHash] [varchar](255) NOT NULL,
	[FullName] [varchar](100) NULL,
	[RoleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[TransactionItems]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[TransactionItems]  WITH CHECK ADD FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([TransactionID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
/****** Object:  StoredProcedure [dbo].[AddTransaction]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddTransaction]
    @userID INT,
    @totalAmount DECIMAL(10,2),
    @paymentMethod VARCHAR(20),
    @transactionID INT OUTPUT
AS
BEGIN
    INSERT INTO Transactions (UserID, TotalAmount, PaymentMethod)
    VALUES (@userID, @totalAmount, @paymentMethod);

    SET @transactionID = SCOPE_IDENTITY();
END;

GO
/****** Object:  StoredProcedure [dbo].[AddTransactionItem]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddTransactionItem]
    @transactionID INT,
    @productID INT,
    @quantity INT,
    @price DECIMAL(10,2)
AS
BEGIN
    INSERT INTO TransactionItems (TransactionID, ProductID, Quantity, Price)
    VALUES (@transactionID, @productID, @quantity, @price);
END;

GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProducts]
AS
BEGIN
    SELECT * FROM Products;
END;

GO
/****** Object:  StoredProcedure [dbo].[GetUserByCredentials]    Script Date: 18-May-2025 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUserByCredentials]
    @username VARCHAR(50),
    @password VARCHAR(255)
AS
BEGIN
    SELECT UserID, RoleID FROM Users WHERE Username = @username AND PasswordHash = @password;
END;

GO
USE [master]
GO
ALTER DATABASE [MilkbarPOS] SET  READ_WRITE 
GO
