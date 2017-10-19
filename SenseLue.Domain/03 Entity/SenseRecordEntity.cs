using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SenseLue.Domain.Entity
{
	/// <summary>
	/// 类Sys_SenseRecord。
	/// </summary>

	public class SenseRecordEntity : IEntity<SenseRecordEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {

		#region Model
		private string _f_id;
        private string _f_title;
        private string _f_description;
		private string _f_mindmapfilepath;
		private string _f_mindmapimagepath;
		private string _f_senseword;
		private int? _f_sortcode;
        private string _f_label;
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
        public string F_Title
        {
            set { _f_title = value; }
            get { return _f_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string F_Description
        {
            set { _f_description = value; }
            get { return _f_description; }
        }
        

        /// <summary>
        /// 
        /// </summary>
        public string F_MindMapFilePath
		{
			set{ _f_mindmapfilepath=value;}
			get{return _f_mindmapfilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_MindMapImagePath
		{
			set{ _f_mindmapimagepath=value;}
			get{return _f_mindmapimagepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string F_SenseWord
		{
			set{ _f_senseword=value;}
			get{return _f_senseword;}
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
        /// 标签
        /// </summary>
        public string F_Label {
            set { _f_label = value; }
            get { return _f_label; }
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
		/// 写日期
		/// </summary>
		public DateTime? F_CreatorTime
		{
			set{ _f_creatortime=value;}
			get{return _f_creatortime;}
		}
		/// <summary>
		/// 写用户主键
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

