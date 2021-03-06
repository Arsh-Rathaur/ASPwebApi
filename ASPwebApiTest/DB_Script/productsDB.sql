USE [master]
GO
/****** Object:  Database [productsDB]    Script Date: 24-03-2020 13:41:08 ******/
CREATE DATABASE [productsDB]

GO
ALTER DATABASE [productsDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [productsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [productsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [productsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [productsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [productsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [productsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [productsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [productsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [productsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [productsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [productsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [productsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [productsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [productsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [productsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [productsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [productsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [productsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [productsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [productsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [productsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [productsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [productsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [productsDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [productsDB] SET  MULTI_USER 
GO
ALTER DATABASE [productsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [productsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [productsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [productsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [productsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [productsDB] SET QUERY_STORE = OFF
GO
USE [productsDB]
GO
/****** Object:  Table [dbo].[products]    Script Date: 24-03-2020 13:41:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[product_id]  AS ('UID'+right('00000000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED,
	[product_name] [varchar](200) NOT NULL,
	[stock_available] [varchar](200) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([ID], [product_name], [stock_available], [created_at], [updated_at]) VALUES (1, N'Nevia Football', N'200', CAST(N'2020-03-24T11:25:22.060' AS DateTime), CAST(N'2020-03-24T11:27:17.770' AS DateTime))
SET IDENTITY_INSERT [dbo].[products] OFF
ALTER TABLE [dbo].[products] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
/****** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 24-03-2020 13:41:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllProducts]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [ID]
	      ,[product_id]
	      ,[product_name]
	      ,[stock_available]
	  FROM [dbo].[products]

END
GO
USE [master]
GO
ALTER DATABASE [productsDB] SET  READ_WRITE 
GO
