using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using TestApp.Model;

namespace TestApp
{
    public static class RedisStore
    {
        private static readonly  string redisConnection ="localhost:6379";

        private static readonly Lazy<ConnectionMultiplexer> lazyConnection;

        static RedisStore()
        {
            var configOption = new ConfigurationOptions { EndPoints = { redisConnection } };
            lazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(configOption));
        }

        //public static ConnectionMultiplexer Connection => lazyConnection.Value;
        public static IDatabase RedisCache => lazyConnection.Value.GetDatabase();
       // var redisCustomers = RedisCache.As<Student>();


        public static void Set(string cacheKey,object cacheValue)
        {
            var x = Searialize(cacheValue);
            RedisCache.StringSet(cacheKey, x);
        }

        private static byte[] Searialize(object obj)
        {
            if (obj == null) return null;
            var binaryFormatter = new BinaryFormatter();
            using(var memoryStream =new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);
                var objByte = memoryStream.ToArray();
                return objByte;
            }
        }


        public static T Get<T>(string cacheKey)
        {
            var x = RedisCache.StringGet(cacheKey);
            return Deserialize<T>(x);
        }

        private static T Deserialize<T>(byte[] byteArr)
        {
            if (byteArr == null) return default(T);
            var binaryFormatter = new BinaryFormatter();
            using(var memoryStram=new MemoryStream(byteArr))
            {
                var result = (T)binaryFormatter.Deserialize(memoryStram);
                return result;
            }
        }


    }
}
