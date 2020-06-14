using Mall.IEntity.Base;
using Mall.IEntity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.IEntity.Structure
{
    public class ThirdPartyOrgMap :BaseEntity<ThirdPartyOrgMapKey>, IEntityVisible, IEntityEnable
    {
        /// <summary>
        /// 组织第三方映射
        /// </summary>
        public string ThirdPartyOrgId
        {
            get { return Key.ThirdPartyOrgId; }
            set { Key.ThirdPartyOrgId = value; }
        }

        public ThirdPartyApp ThirdPartyApp
        {
            get { return Key.ThirdPartyApp; }
            set { Key.ThirdPartyApp = value; }
        }

        /// <summary>
        /// 第三方组织名称
        /// </summary>
        public string ThirdPartyOrgName { get; set; }

        /// <summary>
        /// 关联的第三方应用ID
        /// </summary>
        public string ThirdPartyAppId { get; set; }

        /// <summary>
        /// 第三方应用名称
        /// </summary>
        public string ThirdPartyAppName { get; set; }

        /// <summary>
        /// 永久授权码
        /// </summary>
        public string PermanentCode { get; set; }

        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        public bool IsEnable { get; set; }

        public bool IsVisible { get; set; }
    }
}
