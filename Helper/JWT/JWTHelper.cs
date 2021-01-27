using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;

namespace Helper.JWT
{
    public class JWTHelper
    {

            //私钥  web.config中配置
            public static string secret { set; get; } //= ConfigurationManager.AppSettings["Secret"].ToString();

            /// <summary>
    /// 生成JwtToken
    /// </summary>
    /// <param name="payload">不敏感的用户数据</param>
    /// <returns></returns>
    public static string SetJwtEncode(Dictionary<string, object> payload)
            {

                //格式如下
                //var payload = new Dictionary<string, object>
                //{
                //    { "username","admin" },
                //    { "pwd", "claim2-value" }
                //};

                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                IJsonSerializer serializer = new JsonNetSerializer();
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

                var token = encoder.Encode(payload, secret);
                return token;
            }

            /// <summary>
            /// 根据jwtToken  获取实体
            /// </summary>
            /// <param name="token">jwtToken</param>
            /// <returns></returns>
            public static object GetJwtDecode(string token)
            {
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
                var obj = decoder.DecodeToObject<object>(token, secret, verify: true);//token为之前生成的字符串
                return obj;
            }
        }
    
}

