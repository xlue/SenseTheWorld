using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SenseLue.Domain.Entity
{
	/// <summary>
	/// 类Sys_User。
	/// </summary>

	public class UserEntity : IEntity<UserEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {

		#region Model
		private string _f_id;
        private string _f_account;
		private string _f_fullname;
		private string _f_penname;
		private bool _f_gender;
		private string _f_email;
		private string _f_qq;
		private string _f_wechat;
		private string _f_resume;
		private DateTime? _f_birthday;
		private string _f_headicon;
		private string _f_mobilephone;
		private bool _f_isadministrator;
		private int? _f_sortcode;
		private bool? _f_deletemark;
		private bool? _f_enabledmark;
		private DateTime? _f_creatortime;
		private string _f_creatoruserid;
		private DateTime? _f_lastmodifytime;
		private string _f_lastmodifyuserid;
		private DateTime? _f_deletetime;
		private string _f_deleteuserid;
		/// <summary>
		/// 
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string F_Account
        {
            set { _f_account = value; }
            get { return _f_account; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string F_FullName
		{
			set{ _f_fullname=value;}
			get{return _f_fullname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_PenName
		{
			set{ _f_penname=value;}
			get{return _f_penname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool F_Gender
		{
			set{ _f_gender=value;}
			get{return _f_gender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_Email
		{
			set{ _f_email=value;}
			get{return _f_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_QQ
		{
			set{ _f_qq=value;}
			get{return _f_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_WeChat
		{
			set{ _f_wechat=value;}
			get{return _f_wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_Resume
		{
			set{ _f_resume=value;}
			get{return _f_resume;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? F_Birthday
		{
			set{ _f_birthday=value;}
			get{return _f_birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_HeadIcon
		{
			set{ _f_headicon=value;}
			get{return _f_headicon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_MobilePhone
		{
			set{ _f_mobilephone=value;}
			get{return _f_mobilephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool F_IsAdministrator
		{
			set{ _f_isadministrator=value;}
			get{return _f_isadministrator;}
		}
		/// <summary>
		/// 排序码
		/// </summary>
		public int? F_SortCode
		{
			set{ _f_sortcode=value;}
			get{return _f_sortcode;}
		}
		/// <summary>
		/// 删除标志
		/// </summary>
		public bool? F_DeleteMark
		{
			set{ _f_deletemark=value;}
			get{return _f_deletemark;}
		}
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool? F_EnabledMark
		{
			set{ _f_enabledmark=value;}
			get{return _f_enabledmark;}
		}
		/// <summary>
		/// 写时间
		/// </summary>
		public DateTime? F_CreatorTime
		{
			set{ _f_creatortime=value;}
			get{return _f_creatortime;}
		}
		/// <summary>
		/// 写用户
		/// </summary>
		public string F_CreatorUserId
		{
			set{ _f_creatoruserid=value;}
			get{return _f_creatoruserid;}
		}
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime? F_LastModifyTime
		{
			set{ _f_lastmodifytime=value;}
			get{return _f_lastmodifytime;}
		}
		/// <summary>
		/// 最后修改用户
		/// </summary>
		public string F_LastModifyUserId
		{
			set{ _f_lastmodifyuserid=value;}
			get{return _f_lastmodifyuserid;}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? F_DeleteTime
		{
			set{ _f_deletetime=value;}
			get{return _f_deletetime;}
		}
		/// <summary>
		/// 删除用户
		/// </summary>
		public string F_DeleteUserId
		{
			set{ _f_deleteuserid=value;}
			get{return _f_deleteuserid;}
		}
		#endregion Model

	}
}

