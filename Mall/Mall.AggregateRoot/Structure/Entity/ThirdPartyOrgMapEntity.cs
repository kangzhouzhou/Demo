using Mall.Aggregate.Base;
using Mall.Aggregate.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Aggregate.Structure.ValueObject
{
    public class ThirdPartyOrgMapEntity : IValueObject<ThirdPartyOrgMapKey>, IEntity<ThirdPartyOrgMapKey>, IsEnable
    {
        public ThirdPartyOrgMapEntity()
        {
            KeyValue = new ThirdPartyOrgMapKey();
        }

        public ThirdPartyOrgMapEntity(ThirdPartyOrgMapKey thirdPartyOrgMapKey)
        {
            KeyValue = thirdPartyOrgMapKey;
        }

        public ThirdPartyOrgMapKey KeyValue { get; set; }

        /// <summary>
        /// 组织第三方映射
        /// </summary>
        public string ThirdPartyOrgId
        {
            get { return KeyValue.ThirdPartyOrgId; }
            set { KeyValue.ThirdPartyOrgId = value; }
        }

        public ThirdPartyApp ThirdPartyApp
        {
            get { return KeyValue.ThirdPartyApp; }
            set { KeyValue.ThirdPartyApp = value; }
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

        public bool IsEnable { get; set; }
    }
}
