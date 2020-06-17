using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Dto.Base
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

        private string _err;
        /// <summary>
        /// 错误信息,会自动将ErrProcess设置为ErrProcess.InfoTips
        /// </summary>
        public string Err
        {
            get { return _err; }
            set
            {
                if (ErrProcess == ErrProcess.Ignore)
                    ErrProcess = ErrProcess.InfoTips;
                _err = value;
            }
        }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool Success
        {
            get
            {
                return string.IsNullOrEmpty(Err) ? true : false;
            }
        }

        /// <summary>
        /// 错误处理0,忽略错误，1进行错误提示，2跳转登录页
        /// </summary>
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
