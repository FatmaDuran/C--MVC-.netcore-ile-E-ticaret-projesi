using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Eshop.WebUI.Infrastructure
{
    public static class SessionExtension
    {
        public static void SetJson(this ISession session,string key,object value)
           
        {
            //key=cart
            session.SetString(key, JsonConvert.SerializeObject(value));

        }
        public static T GetJSon<T>(this ISession session,string key)
        {
            var data = session.GetString(key);
            return data == null ?
                default : JsonConvert.DeserializeObject<T>(data); //deserialize,jsondan tekrar objeye çevirecek
        }
    }
}
