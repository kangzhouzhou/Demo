using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.InterfaceDto.Base
{
    /// <summary>
    /// 响应体基类
    /// </summary>
    public class ResponseBody
    {
        /// <summary>
        /// 随机数一致
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// 时间戳一致
        /// </summary>
        public string Timestamp { get; set; }

        public bool Success { get; set; }

        public string Err { get; set; }

        public ErrProcess ErrProcess { get; set; }
    }

    public class ResponseBody<T> : ResponseBody
    { 
        public T Data { get; set; }
    }

    public class PageResponseBody<T> : ResponseBody<T>
    {
        /// <summary>
        ///  获取或设置页面大小。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置页码。
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置总记录数。
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// 获取总页数。
        /// </summary>
        public int TotalPages
        {
            get { return (TotalRecords + PageSize - 1) / PageSize; }
        }
    }
}
