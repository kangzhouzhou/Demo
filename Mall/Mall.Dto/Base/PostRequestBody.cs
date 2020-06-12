using Mall.Dto.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Bases
{    /// <summary>
     /// POST请求体基类:Noce和Timesstamp请求排重
     /// </summary>
    public class PostRequestBody : RequestBody
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
