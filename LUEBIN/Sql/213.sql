USE [master]
GO
/****** Object:  Database [SenseWorldDB]    Script Date: 2017/8/7 17:57:27 ******/
CREATE DATABASE [SenseWorldDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReadBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ReadBase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ReadBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ReadBase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SenseWorldDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SenseWorldDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SenseWorldDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SenseWorldDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SenseWorldDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SenseWorldDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SenseWorldDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SenseWorldDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SenseWorldDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SenseWorldDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SenseWorldDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SenseWorldDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SenseWorldDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SenseWorldDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SenseWorldDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SenseWorldDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SenseWorldDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SenseWorldDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SenseWorldDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SenseWorldDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SenseWorldDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SenseWorldDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SenseWorldDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SenseWorldDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SenseWorldDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SenseWorldDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SenseWorldDB] SET  MULTI_USER 
GO
ALTER DATABASE [SenseWorldDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SenseWorldDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SenseWorldDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SenseWorldDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SenseWorldDB]
GO
/****** Object:  Table [dbo].[Sys_Book]    Script Date: 2017/8/7 17:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_Book](
	[F_Id] [varchar](50) NOT NULL,
	[F_Name] [varchar](50) NULL,
	[F_Author] [varchar](50) NULL,
	[F_CoverPath] [varchar](50) NULL,
	[F_Tag] [varchar](50) NULL,
	[F_Description] [varchar](500) NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [varchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [varchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [varchar](500) NULL,
 CONSTRAINT [PK_Sys_Book] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sys_MinWord]    Script Date: 2017/8/7 17:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_MinWord](
	[F_Id] [varchar](50) NOT NULL,
	[F_UserId] [varchar](50) NULL,
	[F_Title] [nvarchar](50) NULL,
	[F_Content] [text] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [varchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [varchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_MinWord] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sys_SenseRecord]    Script Date: 2017/8/7 17:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_SenseRecord](
	[F_Id] [varchar](50) NOT NULL,
	[F_UserId] [nchar](10) NULL,
	[F_MindMapFilePath] [nchar](10) NULL,
	[F_MindMapImagePath] [nchar](10) NULL,
	[F_SenseWord] [text] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [varchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [varchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_SenseRecord] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sys_User]    Script Date: 2017/8/7 17:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_User](
	[F_Id] [varchar](50) NOT NULL,
	[F_FullName] [varchar](50) NULL,
	[F_PenName] [varchar](50) NULL,
	[F_Gender] [bit] NULL,
	[F_Email] [varchar](50) NULL,
	[F_QQ] [varchar](20) NULL,
	[F_WeChat] [varchar](50) NULL,
	[F_Resume] [varchar](500) NULL,
	[F_Birthday] [datetime] NULL,
	[F_HeadIcon] [varchar](50) NULL,
	[F_MobilePhone] [varchar](20) NULL,
	[F_IsAdministrator] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [varchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [varchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [varchar](500) NULL,
 CONSTRAINT [PK_Sys_User] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Book', @level2type=N'COLUMN',@level2name=N'F_DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MinWord', @level2type=N'COLUMN',@level2name=N'F_SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MinWord', @level2type=N'COLUMN',@level2name=N'F_DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MinWord', @level2type=N'COLUMN',@level2name=N'F_EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建用户主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SenseRecord', @level2type=N'COLUMN',@level2name=N'F_DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'F_DeleteUserId'
GO
USE [master]
GO
ALTER DATABASE [SenseWorldDB] SET  READ_WRITE 
GO
