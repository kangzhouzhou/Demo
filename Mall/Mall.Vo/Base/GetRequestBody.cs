using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Base
{
    public class GetRequestBody
    {
        /// <summary>
        /// 随机数
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string Timestamp { get; set; }
    }
}
