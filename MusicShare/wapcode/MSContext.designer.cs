﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicShare
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbMusicShare")]
	public partial class MSContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdminUser(AdminUser instance);
    partial void UpdateAdminUser(AdminUser instance);
    partial void DeleteAdminUser(AdminUser instance);
    partial void InsertUserUploader(UserUploader instance);
    partial void UpdateUserUploader(UserUploader instance);
    partial void DeleteUserUploader(UserUploader instance);
    partial void InsertTracksWraper(TracksWraper instance);
    partial void UpdateTracksWraper(TracksWraper instance);
    partial void DeleteTracksWraper(TracksWraper instance);
    #endregion
		
		public MSContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbMusicShareConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MSContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AdminUser> AdminUsers
		{
			get
			{
				return this.GetTable<AdminUser>();
			}
		}
		
		public System.Data.Linq.Table<UserUploader> UserUploaders
		{
			get
			{
				return this.GetTable<UserUploader>();
			}
		}
		
		public System.Data.Linq.Table<TracksWraper> TracksWrapers
		{
			get
			{
				return this.GetTable<TracksWraper>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminUser")]
	public partial class AdminUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _UserName;
		
		private string _EmailID;
		
		private string _UserPW;
		
		private System.Nullable<bool> _IsActive;
		
		private System.Nullable<System.DateTime> _DateAdded;
		
		private EntitySet<TracksWraper> _TracksWrapers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailIDChanging(string value);
    partial void OnEmailIDChanged();
    partial void OnUserPWChanging(string value);
    partial void OnUserPWChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateAddedChanged();
    #endregion
		
		public AdminUser()
		{
			this._TracksWrapers = new EntitySet<TracksWraper>(new Action<TracksWraper>(this.attach_TracksWrapers), new Action<TracksWraper>(this.detach_TracksWrapers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(100)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailID", DbType="NVarChar(50)")]
		public string EmailID
		{
			get
			{
				return this._EmailID;
			}
			set
			{
				if ((this._EmailID != value))
				{
					this.OnEmailIDChanging(value);
					this.SendPropertyChanging();
					this._EmailID = value;
					this.SendPropertyChanged("EmailID");
					this.OnEmailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPW", DbType="NVarChar(100)")]
		public string UserPW
		{
			get
			{
				return this._UserPW;
			}
			set
			{
				if ((this._UserPW != value))
				{
					this.OnUserPWChanging(value);
					this.SendPropertyChanging();
					this._UserPW = value;
					this.SendPropertyChanged("UserPW");
					this.OnUserPWChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._DateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AdminUser_TracksWraper", Storage="_TracksWrapers", ThisKey="ID", OtherKey="ApprovedBy")]
		public EntitySet<TracksWraper> TracksWrapers
		{
			get
			{
				return this._TracksWrapers;
			}
			set
			{
				this._TracksWrapers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TracksWrapers(TracksWraper entity)
		{
			this.SendPropertyChanging();
			entity.AdminUser = this;
		}
		
		private void detach_TracksWrapers(TracksWraper entity)
		{
			this.SendPropertyChanging();
			entity.AdminUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserUploader")]
	public partial class UserUploader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _UserName;
		
		private string _EmailID;
		
		private string _UserPW;
		
		private string _MobileNo;
		
		private string _GmailUrl;
		
		private string _FacebookUrl;
		
		private string _UserImage;
		
		private System.Nullable<System.DateTime> _DateAdded;
		
		private System.Nullable<System.DateTime> _DateModified;
		
		private System.Nullable<bool> _IsDeleted;
		
		private EntitySet<TracksWraper> _TracksWrapers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailIDChanging(string value);
    partial void OnEmailIDChanged();
    partial void OnUserPWChanging(string value);
    partial void OnUserPWChanged();
    partial void OnMobileNoChanging(string value);
    partial void OnMobileNoChanged();
    partial void OnGmailUrlChanging(string value);
    partial void OnGmailUrlChanged();
    partial void OnFacebookUrlChanging(string value);
    partial void OnFacebookUrlChanged();
    partial void OnUserImageChanging(string value);
    partial void OnUserImageChanged();
    partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateAddedChanged();
    partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateModifiedChanged();
    partial void OnIsDeletedChanging(System.Nullable<bool> value);
    partial void OnIsDeletedChanged();
    #endregion
		
		public UserUploader()
		{
			this._TracksWrapers = new EntitySet<TracksWraper>(new Action<TracksWraper>(this.attach_TracksWrapers), new Action<TracksWraper>(this.detach_TracksWrapers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(100)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailID", DbType="NVarChar(50)")]
		public string EmailID
		{
			get
			{
				return this._EmailID;
			}
			set
			{
				if ((this._EmailID != value))
				{
					this.OnEmailIDChanging(value);
					this.SendPropertyChanging();
					this._EmailID = value;
					this.SendPropertyChanged("EmailID");
					this.OnEmailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPW", DbType="NVarChar(100)")]
		public string UserPW
		{
			get
			{
				return this._UserPW;
			}
			set
			{
				if ((this._UserPW != value))
				{
					this.OnUserPWChanging(value);
					this.SendPropertyChanging();
					this._UserPW = value;
					this.SendPropertyChanged("UserPW");
					this.OnUserPWChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileNo", DbType="NVarChar(50)")]
		public string MobileNo
		{
			get
			{
				return this._MobileNo;
			}
			set
			{
				if ((this._MobileNo != value))
				{
					this.OnMobileNoChanging(value);
					this.SendPropertyChanging();
					this._MobileNo = value;
					this.SendPropertyChanged("MobileNo");
					this.OnMobileNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GmailUrl", DbType="NVarChar(50)")]
		public string GmailUrl
		{
			get
			{
				return this._GmailUrl;
			}
			set
			{
				if ((this._GmailUrl != value))
				{
					this.OnGmailUrlChanging(value);
					this.SendPropertyChanging();
					this._GmailUrl = value;
					this.SendPropertyChanged("GmailUrl");
					this.OnGmailUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FacebookUrl", DbType="NVarChar(50)")]
		public string FacebookUrl
		{
			get
			{
				return this._FacebookUrl;
			}
			set
			{
				if ((this._FacebookUrl != value))
				{
					this.OnFacebookUrlChanging(value);
					this.SendPropertyChanging();
					this._FacebookUrl = value;
					this.SendPropertyChanged("FacebookUrl");
					this.OnFacebookUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserImage", DbType="NVarChar(200)")]
		public string UserImage
		{
			get
			{
				return this._UserImage;
			}
			set
			{
				if ((this._UserImage != value))
				{
					this.OnUserImageChanging(value);
					this.SendPropertyChanging();
					this._UserImage = value;
					this.SendPropertyChanged("UserImage");
					this.OnUserImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._DateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._DateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDeleted", DbType="Bit")]
		public System.Nullable<bool> IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserUploader_TracksWraper", Storage="_TracksWrapers", ThisKey="ID", OtherKey="UsrId")]
		public EntitySet<TracksWraper> TracksWrapers
		{
			get
			{
				return this._TracksWrapers;
			}
			set
			{
				this._TracksWrapers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TracksWrapers(TracksWraper entity)
		{
			this.SendPropertyChanging();
			entity.UserUploader = this;
		}
		
		private void detach_TracksWrapers(TracksWraper entity)
		{
			this.SendPropertyChanging();
			entity.UserUploader = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TracksWraper")]
	public partial class TracksWraper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _SongTitle;
		
		private string _AlbumName;
		
		private string _SingerName;
		
		private System.Nullable<int> _TrackCount;
		
		private System.Nullable<System.DateTime> _AlbumReleaseOn;
		
		private string _CoverImage;
		
		private string _SongUrl;
		
		private System.Nullable<decimal> _UsrId;
		
		private System.Nullable<System.DateTime> _DateAdded;
		
		private System.Nullable<decimal> _ApprovedBy;
		
		private System.Nullable<System.DateTime> _DateApproved;
		
		private System.Nullable<bool> _IsApproved;
		
		private string _MetaTags;
		
		private string _MetaDescription;
		
		private System.Nullable<decimal> _DownloadCount;
		
		private EntityRef<AdminUser> _AdminUser;
		
		private EntityRef<UserUploader> _UserUploader;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnSongTitleChanging(string value);
    partial void OnSongTitleChanged();
    partial void OnAlbumNameChanging(string value);
    partial void OnAlbumNameChanged();
    partial void OnSingerNameChanging(string value);
    partial void OnSingerNameChanged();
    partial void OnTrackCountChanging(System.Nullable<int> value);
    partial void OnTrackCountChanged();
    partial void OnAlbumReleaseOnChanging(System.Nullable<System.DateTime> value);
    partial void OnAlbumReleaseOnChanged();
    partial void OnCoverImageChanging(string value);
    partial void OnCoverImageChanged();
    partial void OnSongUrlChanging(string value);
    partial void OnSongUrlChanged();
    partial void OnUsrIdChanging(System.Nullable<decimal> value);
    partial void OnUsrIdChanged();
    partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateAddedChanged();
    partial void OnApprovedByChanging(System.Nullable<decimal> value);
    partial void OnApprovedByChanged();
    partial void OnDateApprovedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateApprovedChanged();
    partial void OnIsApprovedChanging(System.Nullable<bool> value);
    partial void OnIsApprovedChanged();
    partial void OnMetaTagsChanging(string value);
    partial void OnMetaTagsChanged();
    partial void OnMetaDescriptionChanging(string value);
    partial void OnMetaDescriptionChanged();
    partial void OnDownloadCountChanging(System.Nullable<decimal> value);
    partial void OnDownloadCountChanged();
    #endregion
		
		public TracksWraper()
		{
			this._AdminUser = default(EntityRef<AdminUser>);
			this._UserUploader = default(EntityRef<UserUploader>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SongTitle", DbType="NVarChar(200)")]
		public string SongTitle
		{
			get
			{
				return this._SongTitle;
			}
			set
			{
				if ((this._SongTitle != value))
				{
					this.OnSongTitleChanging(value);
					this.SendPropertyChanging();
					this._SongTitle = value;
					this.SendPropertyChanged("SongTitle");
					this.OnSongTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlbumName", DbType="NVarChar(100)")]
		public string AlbumName
		{
			get
			{
				return this._AlbumName;
			}
			set
			{
				if ((this._AlbumName != value))
				{
					this.OnAlbumNameChanging(value);
					this.SendPropertyChanging();
					this._AlbumName = value;
					this.SendPropertyChanged("AlbumName");
					this.OnAlbumNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SingerName", DbType="NVarChar(200)")]
		public string SingerName
		{
			get
			{
				return this._SingerName;
			}
			set
			{
				if ((this._SingerName != value))
				{
					this.OnSingerNameChanging(value);
					this.SendPropertyChanging();
					this._SingerName = value;
					this.SendPropertyChanged("SingerName");
					this.OnSingerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackCount", DbType="Int")]
		public System.Nullable<int> TrackCount
		{
			get
			{
				return this._TrackCount;
			}
			set
			{
				if ((this._TrackCount != value))
				{
					this.OnTrackCountChanging(value);
					this.SendPropertyChanging();
					this._TrackCount = value;
					this.SendPropertyChanged("TrackCount");
					this.OnTrackCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlbumReleaseOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AlbumReleaseOn
		{
			get
			{
				return this._AlbumReleaseOn;
			}
			set
			{
				if ((this._AlbumReleaseOn != value))
				{
					this.OnAlbumReleaseOnChanging(value);
					this.SendPropertyChanging();
					this._AlbumReleaseOn = value;
					this.SendPropertyChanged("AlbumReleaseOn");
					this.OnAlbumReleaseOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoverImage", DbType="NVarChar(200)")]
		public string CoverImage
		{
			get
			{
				return this._CoverImage;
			}
			set
			{
				if ((this._CoverImage != value))
				{
					this.OnCoverImageChanging(value);
					this.SendPropertyChanging();
					this._CoverImage = value;
					this.SendPropertyChanged("CoverImage");
					this.OnCoverImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SongUrl", DbType="NVarChar(300)")]
		public string SongUrl
		{
			get
			{
				return this._SongUrl;
			}
			set
			{
				if ((this._SongUrl != value))
				{
					this.OnSongUrlChanging(value);
					this.SendPropertyChanging();
					this._SongUrl = value;
					this.SendPropertyChanged("SongUrl");
					this.OnSongUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsrId", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> UsrId
		{
			get
			{
				return this._UsrId;
			}
			set
			{
				if ((this._UsrId != value))
				{
					if (this._UserUploader.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsrIdChanging(value);
					this.SendPropertyChanging();
					this._UsrId = value;
					this.SendPropertyChanged("UsrId");
					this.OnUsrIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._DateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApprovedBy", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ApprovedBy
		{
			get
			{
				return this._ApprovedBy;
			}
			set
			{
				if ((this._ApprovedBy != value))
				{
					if (this._AdminUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnApprovedByChanging(value);
					this.SendPropertyChanging();
					this._ApprovedBy = value;
					this.SendPropertyChanged("ApprovedBy");
					this.OnApprovedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateApproved", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateApproved
		{
			get
			{
				return this._DateApproved;
			}
			set
			{
				if ((this._DateApproved != value))
				{
					this.OnDateApprovedChanging(value);
					this.SendPropertyChanging();
					this._DateApproved = value;
					this.SendPropertyChanged("DateApproved");
					this.OnDateApprovedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsApproved", DbType="Bit")]
		public System.Nullable<bool> IsApproved
		{
			get
			{
				return this._IsApproved;
			}
			set
			{
				if ((this._IsApproved != value))
				{
					this.OnIsApprovedChanging(value);
					this.SendPropertyChanging();
					this._IsApproved = value;
					this.SendPropertyChanged("IsApproved");
					this.OnIsApprovedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MetaTags", DbType="NVarChar(300)")]
		public string MetaTags
		{
			get
			{
				return this._MetaTags;
			}
			set
			{
				if ((this._MetaTags != value))
				{
					this.OnMetaTagsChanging(value);
					this.SendPropertyChanging();
					this._MetaTags = value;
					this.SendPropertyChanged("MetaTags");
					this.OnMetaTagsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MetaDescription", DbType="NVarChar(260)")]
		public string MetaDescription
		{
			get
			{
				return this._MetaDescription;
			}
			set
			{
				if ((this._MetaDescription != value))
				{
					this.OnMetaDescriptionChanging(value);
					this.SendPropertyChanging();
					this._MetaDescription = value;
					this.SendPropertyChanged("MetaDescription");
					this.OnMetaDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DownloadCount", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> DownloadCount
		{
			get
			{
				return this._DownloadCount;
			}
			set
			{
				if ((this._DownloadCount != value))
				{
					this.OnDownloadCountChanging(value);
					this.SendPropertyChanging();
					this._DownloadCount = value;
					this.SendPropertyChanged("DownloadCount");
					this.OnDownloadCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AdminUser_TracksWraper", Storage="_AdminUser", ThisKey="ApprovedBy", OtherKey="ID", IsForeignKey=true)]
		public AdminUser AdminUser
		{
			get
			{
				return this._AdminUser.Entity;
			}
			set
			{
				AdminUser previousValue = this._AdminUser.Entity;
				if (((previousValue != value) 
							|| (this._AdminUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AdminUser.Entity = null;
						previousValue.TracksWrapers.Remove(this);
					}
					this._AdminUser.Entity = value;
					if ((value != null))
					{
						value.TracksWrapers.Add(this);
						this._ApprovedBy = value.ID;
					}
					else
					{
						this._ApprovedBy = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("AdminUser");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserUploader_TracksWraper", Storage="_UserUploader", ThisKey="UsrId", OtherKey="ID", IsForeignKey=true)]
		public UserUploader UserUploader
		{
			get
			{
				return this._UserUploader.Entity;
			}
			set
			{
				UserUploader previousValue = this._UserUploader.Entity;
				if (((previousValue != value) 
							|| (this._UserUploader.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserUploader.Entity = null;
						previousValue.TracksWrapers.Remove(this);
					}
					this._UserUploader.Entity = value;
					if ((value != null))
					{
						value.TracksWrapers.Add(this);
						this._UsrId = value.ID;
					}
					else
					{
						this._UsrId = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("UserUploader");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591