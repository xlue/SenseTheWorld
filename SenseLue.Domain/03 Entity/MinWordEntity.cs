using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SenseLue.Domain.Entity
{
	/// <summary>
	/// 类Sys_MinWord。
	/// </summary>

	public class MinWordEntity : IEntity<MinWordEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {

		#region Model
		private string _f_id;
        private string _f_titile;
        private string _f_cover;
        private string _f_content;
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
        public string F_Cover {
            set { _f_cover = value; }
            get { return _f_cover; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string F_Title
        {
            set { _f_titile = value; }
            get { return _f_titile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string F_Content
		{
			set{ _f_content=value;}
			get{return _f_content;}
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
		/// 
		/// </summary>
		public DateTime? F_CreatorTime
		{
			set{ _f_creatortime=value;}
			get{return _f_creatortime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_CreatorUserId
		{
			set{ _f_creatoruserid=value;}
			get{return _f_creatoruserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? F_LastModifyTime
		{
			set{ _f_lastmodifytime=value;}
			get{return _f_lastmodifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_LastModifyUserId
		{
			set{ _f_lastmodifyuserid=value;}
			get{return _f_lastmodifyuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? F_DeleteTime
		{
			set{ _f_deletetime=value;}
			get{return _f_deletetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_DeleteUserId
		{
			set{ _f_deleteuserid=value;}
			get{return _f_deleteuserid;}
		}
		#endregion Model

	}
}

