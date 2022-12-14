USE [dbMusicShare]
GO
/****** Object:  Table [dbo].[RecommendedMapping]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecommendedMapping](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SongID] [numeric](18, 0) NULL,
	[DateAdded] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Recommended] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[RecommendedMapping] ON
INSERT [dbo].[RecommendedMapping] ([ID], [SongID], [DateAdded], [IsActive]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(228 AS Numeric(18, 0)), CAST(0x0000A2B6012B7678 AS DateTime), 1)
INSERT [dbo].[RecommendedMapping] ([ID], [SongID], [DateAdded], [IsActive]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(231 AS Numeric(18, 0)), CAST(0x0000A2B6012B86D1 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[RecommendedMapping] OFF
/****** Object:  Table [dbo].[AdminUser]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUser](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[EmailID] [nvarchar](50) NULL,
	[UserPW] [nvarchar](100) NULL,
	[IsActive] [bit] NULL,
	[DateAdded] [datetime] NULL,
 CONSTRAINT [PK_AdminUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminUser] ON
INSERT [dbo].[AdminUser] ([ID], [UserName], [EmailID], [UserPW], [IsActive], [DateAdded]) VALUES (CAST(1 AS Numeric(18, 0)), N'sonu', N'sonustar.in@gmail.com', N'sonu', 1, CAST(0x0000A2A700000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[AdminUser] OFF
/****** Object:  Table [dbo].[Top20weekMapping]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Top20weekMapping](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SongID] [numeric](18, 0) NULL,
	[DateAdded] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Top20week] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Top20MonthMapping]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Top20MonthMapping](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SongID] [numeric](18, 0) NULL,
	[DateAdded] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Top20MonthMapping] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserUploader]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserUploader](
	[ID] [numeric](18, 0) IDENTITY(300,1) NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[EmailID] [nvarchar](50) NULL,
	[UserPW] [nvarchar](100) NULL,
	[MobileNo] [nvarchar](50) NULL,
	[GmailUrl] [nvarchar](50) NULL,
	[FacebookUrl] [nvarchar](50) NULL,
	[UserImage] [nvarchar](200) NULL,
	[DateAdded] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_UserUploader] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserUploader] ON
INSERT [dbo].[UserUploader] ([ID], [UserName], [EmailID], [UserPW], [MobileNo], [GmailUrl], [FacebookUrl], [UserImage], [DateAdded], [DateModified], [IsDeleted]) VALUES (CAST(300 AS Numeric(18, 0)), N'sonu', N'sonustar.in@gmail.com', N'sonu', N'9876672396', N'sonustar.in@gmail.com', N'sonustar.in', N'IMG_20131125_14322714092014060910.jpg', CAST(0x0000A2A700000000 AS DateTime), CAST(0x0000A2B3012DF9A0 AS DateTime), 0)
INSERT [dbo].[UserUploader] ([ID], [UserName], [EmailID], [UserPW], [MobileNo], [GmailUrl], [FacebookUrl], [UserImage], [DateAdded], [DateModified], [IsDeleted]) VALUES (CAST(301 AS Numeric(18, 0)), N'star', N'davinder.aspx@gmail.com', N'star', N'', N'davinder.aspx@gmail.com', N'sonustar.in', N'Canvas-HD-816032014120308.jpg', CAST(0x0000A2A700000000 AS DateTime), CAST(0x0000A2B50000DD16 AS DateTime), 0)
INSERT [dbo].[UserUploader] ([ID], [UserName], [EmailID], [UserPW], [MobileNo], [GmailUrl], [FacebookUrl], [UserImage], [DateAdded], [DateModified], [IsDeleted]) VALUES (CAST(302 AS Numeric(18, 0)), N'ravi', N'davsinsoft@gmail.com', N'ravi', NULL, NULL, NULL, NULL, CAST(0x0000A2B301393F8D AS DateTime), CAST(0x0000A2B301393F8E AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[UserUploader] OFF
/****** Object:  Table [dbo].[TracksWraper]    Script Date: 05/01/2015 22:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TracksWraper](
	[ID] [numeric](18, 0) IDENTITY(222,1) NOT NULL,
	[SongTitle] [nvarchar](200) NULL,
	[AlbumName] [nvarchar](100) NULL,
	[SingerName] [nvarchar](200) NULL,
	[TrackCount] [int] NULL,
	[AlbumReleaseOn] [datetime] NULL,
	[CoverImage] [nvarchar](200) NULL,
	[SongUrl] [nvarchar](300) NULL,
	[UsrId] [numeric](18, 0) NULL,
	[DateAdded] [datetime] NULL,
	[ApprovedBy] [numeric](18, 0) NULL,
	[DateApproved] [datetime] NULL,
	[IsApproved] [bit] NULL,
	[MetaTags] [nvarchar](300) NULL,
	[MetaDescription] [nvarchar](260) NULL,
	[DownloadCount] [numeric](18, 0) NULL,
 CONSTRAINT [PK_TracksWraper] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TracksWraper] ON
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(224 AS Numeric(18, 0)), N'any', N'any', N'test', 1, CAST(0x0000A2B300000000 AS DateTime), N'ada14442014064453.jpg', N'Malang Dhoom 3 320 Kbps_-(Jatt.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B300E79056 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C2016B8021 AS DateTime), 0, N'lsjfsl,ksfjls', N'sljfsdfjljf sfjslfjlsjdflj', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(225 AS Numeric(18, 0)), N'chadta', N'chadta', N'diljit', 1, CAST(0x0000A2C500000000 AS DateTime), N'azz51215_ivory_m14032014030352.jpg', N'Chhadta_-_www.DjPunjab.Com_-(Jatt.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B300F8415D AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C9B44 AS DateTime), 1, N'chatdta, diljit chatdta', N'chatdata song by diljit', CAST(28 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(226 AS Numeric(18, 0)), N'tut gaiyan ', N'tut gaiyan ', N'masha ali', 1, CAST(0x0000A2A700000000 AS DateTime), N'Canvas-HD-814512014035135.jpg', N'tut gaiyan masha ali_-(Jatt.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B301055D74 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C9AEB AS DateTime), 1, N'tut gaiyan masha ali', N'tut gaiyan masha ali', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(227 AS Numeric(18, 0)), N'Ferrari', N'Ferrari', N'gippy', 1, CAST(0x0000A2A800000000 AS DateTime), N'lshop14232014062314.jpg', N'Ferrari_-_www.DjPunjab.Com_-(Jatt.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B3012F03EF AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C9995 AS DateTime), 1, N'Ferrari, gippy', N'Ferrari', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(228 AS Numeric(18, 0)), N'Kabhi Jo Baadal Barse', N'Baadal Barse', N'Jackpot', 1, CAST(0x0000A2A700000000 AS DateTime), N'ada14442014064453.jpg', N'10 - Jackpot - Kabhi Jo Baadal Barse Remix By Rishi DJMaza-Info_-(Jatt.fm).mp3', CAST(301 AS Numeric(18, 0)), CAST(0x0000A2B30134F688 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C2016B801F AS DateTime), 0, N'Jackpot - Kabhi Jo Baadal Barse', N'Jackpot - Kabhi Jo Baadal Barse', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(229 AS Numeric(18, 0)), N'Dhoom', N'Dhoom', N'Dm', 1, CAST(0x0000A2A800000000 AS DateTime), N'swe15592014115951.jpg', N'Dhoom Machale Dhoom Dhoom 3_-(Jatt.fm).mp3', CAST(301 AS Numeric(18, 0)), CAST(0x0000A2B4018B77F8 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C97D9 AS DateTime), 1, N'Dhoom', N'Dhoom', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(230 AS Numeric(18, 0)), N'Top_Da_Shaukeen', N'punjabi virsa', N'kamal', 1, CAST(0x0000A2A700000000 AS DateTime), N'lshop17072014120741.jpg', N'Top_Da_Shaukeen_-(Jatt.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B600C7DDB1 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C963F AS DateTime), 1, N'Top_Da_Shaukeen', N'Top_Da_Shaukeen', CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(231 AS Numeric(18, 0)), N'Soch', N'soch', N' Hardy Sandhu', 1, CAST(0x0000A2A700000000 AS DateTime), N'azz51041_denim_m17092014120959.jpg', N'Soch.mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B600C87EF4 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C962B AS DateTime), 1, N'Soch,Hardy Sandhu', N'Soch,Hardy Sandhu', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(232 AS Numeric(18, 0)), N'Ferrari', N'Ferrari', N'gippy', 1, CAST(0x0000A2A800000000 AS DateTime), N'ada17112014121110.jpg', N'Ferrari.mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2B600C8D228 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C960A AS DateTime), 1, N'Ferrari', N'Ferrari', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(233 AS Numeric(18, 0)), N'Be Intehaan', N'race 2', N'pata ni', 1, CAST(0x0000A2C000000000 AS DateTime), N'logo27262014092619.png', N'Be-Intehaan.mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2C001614C24 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C1017C95E8 AS DateTime), 1, N'Be Intehaan', N'Be Intehaan', CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(234 AS Numeric(18, 0)), N'garh di shrab', N'bhaji in problem', N'gippy grewal', 1, CAST(0x0000A2C100000000 AS DateTime), N'images28572014025725.jpg', N'Ghar Di Sharaab-_(apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2C100F67C04 AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C2016B801C AS DateTime), 0, N'gippy ,bhaji in problem', N'gippy garh di shrab', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(235 AS Numeric(18, 0)), N'Enrique Iglesias', N'anhy', N'garry Sandhu', 1, CAST(0x0000A2C100000000 AS DateTime), N'star_corporation29012014100132.png', N'Enrique Iglesias  (Apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2C2016AF92C AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2C2016B7F7A AS DateTime), 1, N'Ja_Ni_Ja-', N'Ja_Ni_Ja-', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(236 AS Numeric(18, 0)), N'Bewafaai_Di_Sazaa', N'Bewafaai_Di_Sazaa ', N'pata ni', 1, CAST(0x0000A2D700000000 AS DateTime), N'azz51041_denim_m08562014095633.jpg', N'Bewafaai_Di_Sazaa (Apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2E801699A1E AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2E801700A7B AS DateTime), 1, N'Bewafaai_Di_Sazaa', N'Bewafaai_Di_Sazaa', CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(237 AS Numeric(18, 0)), N'Judaiyaan ', N'Judaiyaan ', N'Judaiyaan ', 1, CAST(0x0000A2F100000000 AS DateTime), N'azz51215_ivory_m08162014101639.jpg', N'Judaiyaan _-(Apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A2E8016F1F7D AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A2E801700A01 AS DateTime), 1, N'Judaiyaan ', N'Judaiyaan ', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(238 AS Numeric(18, 0)), N'Sanu Ik Pal Chain Na Aave', N'any album', N'kamal', 1, CAST(0x0000A30600000000 AS DateTime), N'images21082014040854.jpg', N'Aashiqui 2 Mashup 2013 - DJ Kiran Kamath DJMaza_-(Apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A314010A1F2D AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A314010C6F92 AS DateTime), 0, N'Sanu Ik Pal Chain Na Aave,any,user', N'Sanu Ik Pal Chain Na Aave,any,user', NULL)
INSERT [dbo].[TracksWraper] ([ID], [SongTitle], [AlbumName], [SingerName], [TrackCount], [AlbumReleaseOn], [CoverImage], [SongUrl], [UsrId], [DateAdded], [ApprovedBy], [DateApproved], [IsApproved], [MetaTags], [MetaDescription], [DownloadCount]) VALUES (CAST(239 AS Numeric(18, 0)), N'Chhadta', N'Always Talli', N'Inderjit Nikku', 1, CAST(0x0000A2C100000000 AS DateTime), N'imagesjj21162014041625.jpg', N'Feroz_Khan_-_Heeriye_-_www-DjPunjab-Com_-(Apna.fm).mp3', CAST(300 AS Numeric(18, 0)), CAST(0x0000A314010C2EED AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(0x0000A314010C6E8B AS DateTime), 1, N'ChhadtaChhadtaChhadtaChhadtaChhadtaChhadta', N'ChhadtaChhadtaChhadtaChhadta', CAST(3 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[TracksWraper] OFF
/****** Object:  StoredProcedure [dbo].[SelectMU]    Script Date: 05/01/2015 22:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectMU]
       @Action varchar(200)=null,
	   @songid bigint=null,
	   @monthid int=null,
	   @alphabit char(1)=null
AS
BEGIN
	SET NOCOUNT ON;

    Begin tran 
      BEGIN TRY 
          if(@Action='selectDetail')
           begin
             select tw.*, uu.UserName,uu.EmailID,uu.GmailUrl,uu.FacebookUrl,uu.UserImage  from TracksWraper tw inner join UserUploader uu on uu.ID=tw.UsrId where tw.ID=@songid AND tw.IsApproved=1
           end
           if(@Action='download')
            begin 
             
               select SongUrl from TracksWraper where IsApproved=1 and ID=@songid
               update TracksWraper set  DownloadCount=isnull(DownloadCount+1,1) where ID=@songid and IsApproved=1
               
            end
            
            if(@Action='bymonth')
            begin 
             
               select ID,SongTitle,SingerName from TracksWraper where IsApproved=1 and datepart(month, AlbumReleaseOn)=@monthid order by AlbumReleaseOn desc
                
            end
            
            if(@Action='Recommended')
             begin 
                 select top 20 tw.ID,SongTitle,SingerName from TracksWraper tw inner join RecommendedMapping r on r.SongID=tw.ID where tw.IsApproved=1 and r.IsActive=1 order by r.ID DESC
             end
            
            if(@Action='Top20week')
             begin 
                 select top 20 tw.ID,SongTitle,SingerName from TracksWraper tw inner join Top20weekMapping w on w.SongID=tw.ID where tw.IsApproved=1 and w.IsActive=1 order by w.ID DESC
             end
             
              if(@Action='Top20month')
             begin 
                 select top 20 tw.ID,SongTitle,SingerName from TracksWraper tw inner join Top20MonthMapping m on m.SongID=tw.ID where tw.IsApproved=1 and m.IsActive=1 order by m.ID DESC
             end
            
              if(@Action='namewise')
             begin 
              --@alphabit
                 select ID,SongTitle,SingerName from TracksWraper where IsApproved=1 and LOWER(SUBSTRING(SongTitle,1,1))=@alphabit order by AlbumReleaseOn desc
             end
             
             
      commit
	 END TRY 
	         
  BEGIN CATCH    
   RollBack	
     select  ERROR_MESSAGE()
  END CATCH 
END
GO
/****** Object:  Default [DF_Recommended_DateAdded]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[RecommendedMapping] ADD  CONSTRAINT [DF_Recommended_DateAdded]  DEFAULT (getdate()) FOR [DateAdded]
GO
/****** Object:  Default [DF_Recommended_IsActive]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[RecommendedMapping] ADD  CONSTRAINT [DF_Recommended_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Top20MonthMapping_DateAdded]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[Top20MonthMapping] ADD  CONSTRAINT [DF_Top20MonthMapping_DateAdded]  DEFAULT (getdate()) FOR [DateAdded]
GO
/****** Object:  Default [DF_Top20MonthMapping_IsActive]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[Top20MonthMapping] ADD  CONSTRAINT [DF_Top20MonthMapping_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Top20week_DateAdded]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[Top20weekMapping] ADD  CONSTRAINT [DF_Top20week_DateAdded]  DEFAULT (getdate()) FOR [DateAdded]
GO
/****** Object:  Default [DF_Top20week_IsActive]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[Top20weekMapping] ADD  CONSTRAINT [DF_Top20week_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_TracksWraper_IsApproved]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[TracksWraper] ADD  CONSTRAINT [DF_TracksWraper_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
/****** Object:  Default [DF_TracksWraper_DownloadCount]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[TracksWraper] ADD  CONSTRAINT [DF_TracksWraper_DownloadCount]  DEFAULT ((0)) FOR [DownloadCount]
GO
/****** Object:  Default [DF_UserUploader_IsDeleted]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[UserUploader] ADD  CONSTRAINT [DF_UserUploader_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  ForeignKey [FK_Recommended_Recommended]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[RecommendedMapping]  WITH CHECK ADD  CONSTRAINT [FK_Recommended_Recommended] FOREIGN KEY([ID])
REFERENCES [dbo].[RecommendedMapping] ([ID])
GO
ALTER TABLE [dbo].[RecommendedMapping] CHECK CONSTRAINT [FK_Recommended_Recommended]
GO
/****** Object:  ForeignKey [FK_TracksWraper_AdminUser]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[TracksWraper]  WITH CHECK ADD  CONSTRAINT [FK_TracksWraper_AdminUser] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[AdminUser] ([ID])
GO
ALTER TABLE [dbo].[TracksWraper] CHECK CONSTRAINT [FK_TracksWraper_AdminUser]
GO
/****** Object:  ForeignKey [FK_TracksWraper_UserUploader]    Script Date: 05/01/2015 22:47:17 ******/
ALTER TABLE [dbo].[TracksWraper]  WITH CHECK ADD  CONSTRAINT [FK_TracksWraper_UserUploader] FOREIGN KEY([UsrId])
REFERENCES [dbo].[UserUploader] ([ID])
GO
ALTER TABLE [dbo].[TracksWraper] CHECK CONSTRAINT [FK_TracksWraper_UserUploader]
GO
