using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Utility
{
    public class  JWTUtility
    {
        /// <summary>
        /// 创建Encoder对象
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        private static JwtEncoder EncoderFactory()
        {
            //哈希运算消息认证码
            IJwtAlgorithm algorihtm = new HMACSHA256Algorithm();
            //Json序列化
            IJsonSerializer netSerializer = new JsonNetSerializer();
            //Base64编码
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            JwtEncoder encoder = new JwtEncoder(algorihtm, netSerializer, urlEncoder);
            return encoder;
        }

        /// <summary>
        /// 创建Decoder对象
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        private static JwtDecoder DecoderFactory()
        {
            //Json序列化
            IJsonSerializer netSerializer = new JsonNetSerializer();
            //日期提供程序
            IDateTimeProvider dateTimeProvider = new UtcDateTimeProvider();
            //验证器
            IJwtValidator validator = new JwtValidator(netSerializer, dateTimeProvider);
            //Base64编码
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            //哈希运算消息认证码
            IJwtAlgorithm algorihtm = new HMACSHA256Algorithm();
            JwtDecoder decoder = new JwtDecoder(netSerializer, validator, urlEncoder, algorihtm);
            return decoder;
        }

        /// <summary>
        /// Jwt编码对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string JwtEncode(object obj,string jwtSecret)
        {
            return EncoderFactory().Encode(obj, jwtSecret);
        }

        /// <summary>
        /// Jwt解码对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tokenStr"></param>
        /// <param name="jwtSecret"></param>
        /// <returns></returns>
        public static T JwtDecode<T>(string tokenStr, string jwtSecret)
        {
            try
            {
                return DecoderFactory().DecodeToObject<T>(tokenStr, jwtSecret, true);
            }
            catch
            {
                return default(T);
            }
        }
    }
}
