

using Jwt;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TestApp.Model;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student st = new Student(1, "aaa", "bb", 20);
            //var result = JsonConvert.SerializeObject(st);
            //var buffer = Encoding.UTF8.GetBytes(result);
            //var byteContent = new ByteArrayContent(buffer);
            //Console.WriteLine(byteContent);

            //var redis = RedisStore.RedisCache;

            //redis with string
            //redis.StringSet("testKey", "testValue1");
            //var value = redis.StringGet("testKey");

            //redis with list
            // List<Student> list = new List<Student> { new Student(1, "name1", "addr1", 10), new Student(2, "name2", "addr2", 20), new Student(3, "name3", "addr3", 30) };
            //redis.ListRightPushAsync("student", JsonConvert.SerializeObject(new Student(1, "name1", "addr1", 10)));
            //redis.ListRightPushAsync("student", JsonConvert.SerializeObject(new Student(1, "name1", "addr1", 20)));
            //var cacheList = redis.ListRange("students", 0, -1);
            //if (cacheList != null)
            //{
            //    List<Student> studentList = JsonConvert.DeserializeObject<List<Student>>(cacheList[0]);
            //}

            //redis with hashset
            //List<Student> list1 = new List<Student> { new Student(1, "name1", "addr1", 10), new Student(2, "name2", "addr2", 20), new Student(3, "name3", "addr3", 30) };
            //HashEntry[] listOfStudents = { new HashEntry("student", JsonConvert.SerializeObject(new Student(1, "name1", "addr1", 10))),
            //                            new HashEntry("student", JsonConvert.SerializeObject(new Student(2, "name2", "addr2", 20)))
            //};

            //redis.HashSet("studentHash", listOfStudents);



            //Guid
            //List<string> listGuid = new List<string>();
            //Stopwatch st = new Stopwatch();
            //st.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    var guid = Guid.NewGuid().ToString();
            //    if (!listGuid.Contains(guid))
            //        listGuid.Add(guid);
            //}
            //st.Stop();
            //Console.WriteLine("time :{0}", st.ElapsedMilliseconds);
            //Console.WriteLine(listGuid.Count);

            //use wcf service
            //Custm cstm = new Custm();
            //cstm.FirstName = "aa";
            //cstm.LastName = "bb";
            //TestProxyClient client = new TestProxyClient();
            //string x=await client.getNameAsync(cstm);
            //Console.Write(x);

            //Nullable
            //string x = null;
            // int? y = null;
            // Nullable<int> m = null;
            //if (string.IsNullOrEmpty(x))
            //{
            //    Console.WriteLine("null or empty");
            //    Console.WriteLine(System.Text.ASCIIEncoding.Unicode.GetByteCount(Guid.Empty.ToString()));
            //}

            //var guid1 = Guid.NewGuid().ToString();
            //var x = GetGenericValue<string>("param");
            //var y = GetGenericValue<Guid>(guid);
            //var z = GetGenericValue<int>("1");
            //var b = GetGenericValue<bool>("true");
            //var c = GetGenericValue<char>("c");
            //var d = GetGenericValue<decimal>("9.23");
            //var dt = GetGenericValue<DateTime>("2019-09-09");
            //var li = GetGenericValue<List<String>>("list");
            //Guid x = new Guid("fdad92a4-b126-40e5-91a0-fb10a8d3023f");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(x);
            //Console.ReadKey();

            //development branch changes 

            //store & retrive  object using redis cache
            //var guid = Guid.NewGuid();
            //Student student = null;
            //try
            //{
            //    student = RedisStore.Get<Student>("44f71c91-0a47-4aea-b5de-7cc31f970144");
            //    if (student == null)
            //    {
            //        Student st = new Student();
            //        st.Id = guid;
            //        st.Name = "pasi";
            //        st.Adress = "mor";
            //        st.Age = 25;
            //        RedisStore.Set(guid.ToString(), st);
            //    }
            //}
            //catch (Exception ex) { }

            //compare 2 byte arrays
            //Student st = new Student();
            //st.Id = 1;
            //st.Name = "pasi";
            //st.Adress = "mor";
            //st.Age = 2;
            //var arr1 = Searialize(st);
            //Student st1 = new Student();
            //st1.Id = 1;
            //st1.Name = "pasi";
            //st1.Adress = "mora";
            //st1.Age = 2;
            //var arr2 = Searialize(st1);
            //var x = ByteArrayCompare(arr1, arr2);
            //var y = x;


            //string startupPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).
            //                      Parent.Parent.Parent.FullName;
            //string filepath = Path.Combine(startupPath, "xsd","test.xml");

            //CustomerType type = new CustomerType
            //{
            //    CompanyName = "www",
            //    ContactTitle = "eee",
            //    ContactName = "sdsds",
            //    CustomerID="123",
            //    Fax="2222232",
            //    FullAddress= new AddressType { Address="adsadswedsd",City="wsdsds",Country="cccccc"},
            //    Phone="011"
            //};
            //XmlSerializer serializer = new XmlSerializer(typeof(CustomerType));

            ////write xml to file
            //using (TextWriter writer = new StreamWriter(filepath))
            //{
            //    serializer.Serialize(writer, type);
            //}

            ////get xml string
            //using (var sw = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sw))
            //    {
            //        serializer.Serialize(writer, type);
            //        var xml = sw.ToString(); 
            //    }
            //}

            //Request RequestMessage = new Request();
            //RequestMessage.Signature = null;// "Signature";
            //RequestMessage.Timestamp = DateTimeOffset.Now;
            //RequestMessage.Identifier = "Identifier";
            //RequestMessage.Algorithm = "Algorithm";
            //RequestMessage.TransactionId = "TransactionId";
            //RequestMessage.OrgUnitId = "OrgUnitId";
            //RequestMessage.Payload = new Payload() { BINs = new Bin[] { new Bin { AccountNumber = "AccountNumber", CardType = "CardType" } } };

            //var json =  JsonConvert.SerializeObject(RequestMessage,
            //    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });




            //string apiKey = "de8280a6-4a4c-40f0-8ca7-09bfd1b2c2d8";
            //string token = "yyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZWJkYWFiNjc5ODE3ZTBiMWRmODdhNTQiLCJpYXQiOjE1ODk4ODc3NzQsImV4cCI6MTU4OTg5NDk3NCwianRpIjoiYjFlZTBjODEtZjFlZS00ZTIzLTk2MDYtMzA4NTM3NGI3ZWQ5IiwiQ29uc3VtZXJTZXNzaW9uSWQiOiIwXzU2ODkyYzc4LTFiMWUtNGJhZi04OGZjLWRhN2Y1ZGFlNTNjNyIsImF1ZCI6Ijg4NTM1MWRkLWU0NWMtNGU5ZS05MjU4LWQzMmU4MDljZTY0NiIsIlBheWxvYWQiOnsiVmFsaWRhdGVkIjp0cnVlLCJQYXltZW50Ijp7IlR5cGUiOiJDQ0EiLCJQcm9jZXNzb3JUcmFuc2FjdGlvbklkIjoiemM3b3IyNk5OcVUxMXEwYWJzbzAiLCJFeHRlbmRlZERhdGEiOnsiRUNJRmxhZyI6IjA3IiwiRW5yb2xsZWQiOiJVIn19LCJBY3Rpb25Db2RlIjoiTk9BQ1RJT04iLCJFcnJvck51bWJlciI6MCwiRXJyb3JEZXNjcmlwdGlvbiI6IlN1Y2Nlc3MifX0.TUatxEGuU8yGQ9ZZzf-4Pxmd6Twz3rn13A1u8YhiOWU";
            //try
            //{
            //    JsonWebToken.Decode(token, apiKey, true);
            //}
            //catch(Exception ex) {

            //}

            //var jwt = GenerateJwt();
            //lookupApiAsync();

            //var xx = false.ToString();

            //string sample = "False";
            //bool myBool = bool.Parse(sample);

            string str = "False";

            var xx=bool.TryParse(str, out bool result);
            var yy = bool.Parse(str);
            //if (bool.TryParse(str, out bool result))
            //{
            //    //Correct conversion
            //}
            //else
            //{
            //   // result = false;
            //}

            Console.WriteLine(str);


            Console.ReadKey();



        }

        private static async Task lookupApiAsync()
        {
            string apiId = "5ebdaab679817e0b1df87a54";
            string OrgUnitId = "5ebb0041aa694a4adbe2d83d";
            string apiKey = "de8280a6-4a4c-40f0-8ca7-09bfd1b2c2d8";


            string xmlreq = @"<CardinalMPI>
    <Algorithm>SHA-256</Algorithm>
    <Amount>123045</Amount>
    <BillAddrPostCode>44060</BillAddrPostCode>
    <BillAddrState>OH</BillAddrState>
    <BillingAddress1>8100 Tyler Blvd</BillingAddress1>
    <BillingAddress2></BillingAddress2>
    <BillingCity>Mentor</BillingCity>
    <BillingCountryCode>840</BillingCountryCode>
    <BillingFirstName>John</BillingFirstName>
    <BillingFullName>John Doe</BillingFullName>
    <BillingLastName>Doe</BillingLastName>
    <BillingPostalCode>44060</BillingPostalCode>
    <BillingState>OH</BillingState>
    <BrowserColorDepth>32</BrowserColorDepth>
    <BrowserHeader>text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8</BrowserHeader>
    <BrowserHeader>text/html,application/xhtml+xml,application/xml;q=0.9,</BrowserHeader>
    <BrowserJavaEnabled>true</BrowserJavaEnabled>
    <BrowserLanguage>English</BrowserLanguage>
    <BrowserScreenHeight>980</BrowserScreenHeight>
    <BrowserScreenWidth>1080</BrowserScreenWidth>
    <BrowserTimeZone>25200</BrowserTimeZone>
    <CardExpMonth>02</CardExpMonth>
    <CardExpYear>2024</CardExpYear>
    <CardNumber>4000000000001091</CardNumber>
    <CurrencyCode>840</CurrencyCode>
    <DFReferenceId>c17dea31-9cf6-0c1b8f2d3c5</DFReferenceId>
    <DeviceChannel>browser</DeviceChannel>
    <Email>cardinal.mobile.test@gmail.com</Email>
    <IPAddress>112.134.210.76</IPAddress>
    <Identifier>$ApiId</Identifier>
    <MsgType>cmpi_lookup</MsgType>
    <OrderNumber>order-0001</OrderNumber>
    <OrgUnit>$OrgUnit</OrgUnit>
    <ShippingAddress1>8100 Tyler Blvd</ShippingAddress1>
    <ShippingAddress2></ShippingAddress2>
    <ShippingCity>44060</ShippingCity>
    <ShippingCountryCode>840</ShippingCountryCode>
    <ShippingPostalCode>44060</ShippingPostalCode>
    <ShippingState>OH</ShippingState>
    <Signature>$Signature</Signature>
    <Timestamp>$Timestamp</Timestamp>
    <TransactionType>C</TransactionType>   
    <Version>1.7</Version>
</CardinalMPI>";


            var timestamp = DateTime.UtcNow.ToUnixTimeMS().ToString();
            var preHash = timestamp+apiKey;
            //var hashed = ComputeSha256Hash(preHash);
            //var hashedTextBytes = Encoding.UTF8.GetBytes(hashed);
            string signature = ComputeSha256Hash(preHash);// Convert.ToBase64String(hashedTextBytes);

            var r = xmlreq.Replace("$Signature", signature).Replace("$Timestamp", timestamp).Replace("$ApiId", apiId).Replace("$OrgUnit", OrgUnitId);




            //CardinalMPI payload = new CardinalMPI();
            //payload.algorithm = "SHA-256";
            //payload.amount = 12345;
            //payload.billAddrPostCode = 44060;
            //payload.billAddrState = "OH";
            //payload.billingAddress1 = "8100 Tyler Blvd";
            //payload.billingAddress2 = "";
            //payload.billingCity = "Mentor";
            //payload.billingCountryCode = 840;
            //payload.billingFirstName = "John";
            //payload.billingFullName = "John Doe";
            //payload.billingLastName = "Doe";
            //payload.billingPostalCode = 44060;
            //payload.billingState = "OH";
            //payload.browserColorDepth = 32;
            //payload.browserHeader = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            //payload.browserJavaEnabled = true;
            //payload.browserLanguage = "English";
            //payload.browserScreenHeight = 980;
            //payload.browserScreenWidth = 1080;
            //payload.browserTimeZone = 25200;
            //payload.cardExpMonth = 02;
            //payload.cardExpYear = 2024;
            //payload.cardNumber = 4000000000001092;
            //payload.currencyCode = 840;
            //payload.dFReferenceId = "c17dea31-9cf6-0c1b8f2d3c5";
            //payload.deviceChannel = "browser";
            //payload.email = "cardinal.mobile.test@gmail.com";
            //payload.iPAddress = "67.17.219.20";
            //payload.identifier = apiId;
            //payload.msgType = "cmpi_lookup";
            //payload.orderNumber = "order-0001";
            //payload.orgUnit = OrgUnitId;
            //payload.shippingAddress1 = "8100 Tyler Blvd";
            //payload.shippingAddress2 = "";
            //payload.shippingCity = 44060;
            //payload.shippingCountryCode= 840;
            //payload.shippingPostalCode = 44060;
            //payload.shippingState = "OH";
            //payload.signature = signature;
            //payload.timestamp = timestamp;
            //payload.transactionType = "C";
            //payload.userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:30.0) Gecko/20100101 Firefox/30.0";
            //payload.version = "1.7";


            //create json
            //var json = JsonConvert.SerializeObject(payload,
            //    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            //create xml
            //var xml="";
            //XmlSerializer serializer = new XmlSerializer(typeof(CardinalMPI));
            //using (var sw = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sw))
            //    {
            //        serializer.Serialize(writer, payload);
            //         xml = sw.ToString();
            //    }
            //}


            var client = new HttpClient();

            //var requestContent = new FormUrlEncodedContent(new[] {
            //new KeyValuePair<string, string>
            //  (
            //    "cmpi_msg", json
            //  ),
            //});

            var reqBody = "cmpi_msg=\n" + r + "\n";

            var apiUrl =
               // "https://centinelapistag.cardinalcommerce.com/V1/Order/JWT/Start";
               "https://centineltest.cardinalcommerce.com/maps/txns.asp";

            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl)
            {
                Content = new StringContent(reqBody, Encoding.UTF8, "application/x-www-form-urlencoded")
            };
            var response = await client.SendAsync(request);
            var res = await response.Content.ReadAsStringAsync();
        }


        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            //using (SHA256 sha256Hash = SHA256.Create())
            //{
            //    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            //    StringBuilder builder = new StringBuilder();
            //    for (int i = 0; i < bytes.Length; i++)
            //    {
            //        builder.Append(bytes[i].ToString("x2"));
            //    }
            //    return builder.ToString();
            //}

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                var tt = Convert.ToBase64String(bytes);
                return tt;
            }
        }


        private static string GenerateJwt()
        {
          
            string apiKey = "de8280a6-4a4c-40f0-8ca7-09bfd1b2c2d8";
            string apiId = "5ebdaab679817e0b1df87a54";

            //step 1
            //var accessKey = Encoding.UTF8.GetBytes(key);
            //var signingKey = new SymmetricSecurityKey(accessKey);

            //var header = new JwtHeader(new SigningCredentials(
            //                          signingKey, SecurityAlgorithms.HmacSha256));


            //var claims = new List<Claim>();
            //claims.Add(new Claim("exp", ToUnixTime(DateTime.UtcNow.AddHours(2)).ToString()));
            //claims.Add(new Claim("iat", ToUnixTime(DateTime.Now).ToString()));
            //claims.Add(new Claim("jti", Guid.NewGuid().ToString()));
            //claims.Add(new Claim("iss", apiId));
            //claims.Add(new Claim("OrgUnitId", "5ebb0041aa694a4adbe2d83d"));
            //claims.Add(new Claim("ObjectifyPayload", "false"));
            //var OrderDetails = new OrderDetails
            //{
            //    OrderNumber = "order1",
            //    Amount = 100,
            //    CurrencyCode = "840"
            //};
            //var orderPayload = new Order
            //{
            //    OrderDetails = OrderDetails
            //};
            //var ob = JsonConvert.SerializeObject(orderPayload);
            //claims.Add(new Claim("Payload", ob));
            //JwtPayload payload = new JwtPayload(claims);
            //JwtSecurityToken jwtToken = new JwtSecurityToken(header, payload);
            //return new JwtSecurityTokenHandler().WriteToken(jwtToken);



            //step 2

            //var od = new OrderDetails() { Amount = 8000, CurrencyCode = "840", OrderNumber = Guid.NewGuid().ToString() };
            //var payload1 = new JwtPayload
            //{
            //    {"Orderdetails",od }
            //};
            //long epc = (long)(DateTimeOffset.Now - DateTimeOffset.UnixEpoch).TotalSeconds;
            //long exp = (long)(DateTimeOffset.Now.AddHours(2) - DateTimeOffset.UnixEpoch).TotalSeconds;
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            ////HmacSha256Signature
            //var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
            //               (securityKey, SecurityAlgorithms.HmacSha256);

            ////  Finally create a Token
            //var header1 = new JwtHeader(credentials);
            //header1.Add("jti", Guid.NewGuid().ToString());
            //header1.Add("iat", epc);
            //header1.Add("iss", apiId);
            //header1.Add("OrgUnitId", "5ebb0041aa694a4adbe2d83d");
            //header1.Add("ObjectifyPayload", true);
            //header1.Add("ReferenceId", Guid.NewGuid().ToString());
            //header1.Add("exp", exp);
            //header1.Add("ConfirmUrl", "");



            //var secToken = new JwtSecurityToken(header1, payload1);
            //var handler = new JwtSecurityTokenHandler();

            //// Token to String so you can use it in your client
            //var tokenString = handler.WriteToken(secToken);
            //return tokenString;



            //step 3
            var orderNumber = Guid.NewGuid().ToString();
            var payload = new Dictionary<string, object>
            {
                {"exp", DateTime.UtcNow.AddHours(10).ToUnixTime()},
                {"iat", DateTime.UtcNow.ToUnixTime()},
                {"jti", Guid.NewGuid().ToString()},
                {"iss", apiId},
                {"OrgUnitId", "5ebb0041aa694a4adbe2d83d"},
                {
                    "Payload", new Order
                    {
                        OrderDetails = new OrderDetails
                        {
                            OrderNumber = orderNumber
                        }
                    }
                }
            };

            return  JsonWebToken.Encode(payload, apiKey, JwtHashAlgorithm.HS256);



        }

        private static long ToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalSeconds);

        }


        private static byte[] Searialize(object obj)
        {
            if (obj == null) return null;
            var binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);
                var objByte = memoryStream.ToArray();
                return objByte;
            }
        }

        private static bool ByteArrayCompare(byte[]arr1,byte[] arr2)
        {
            IStructuralEquatable eq1 = arr1;
            return eq1.Equals(arr2, StructuralComparisons.StructuralEqualityComparer);
        }

        private static T GetGenericValue<T>(string param)
        {
            var returnValue = default(T);
            if (!string.IsNullOrEmpty(param))
            {
                if (typeof(T) == typeof(Guid))
                {
                    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(param);
                }
                else
                {
                    return (T)Convert.ChangeType(param, typeof(T));
                }
            }
            return returnValue;
            
           
        }

        
    }

    public static class DateTimeHelper
    {
        public static long ToUnixTime(this DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalSeconds);
        }

        public static long ToUnixTimeMS(this DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalMilliseconds);
        }
    }


    public class Request
    {

        [JsonProperty("Signature")]
        public string Signature { get; set; }

        [JsonProperty("Timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("Identifier")]
        public string Identifier { get; set; }

        [JsonProperty("Algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("TransactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("OrgUnitId")]
        public string OrgUnitId { get; set; }

        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

    }

    public class Payload
    {
        [JsonProperty("BINs")]
        public Bin[] BINs { get; set; }
    }

    public class Bin
    {
        [JsonProperty("AccountNumber")]
        public ulong AccountNumber { get; set; }

        [JsonProperty("CardType")]
        public string CardType { get; set; }
    }

    public class Order
    {
        public OrderDetails OrderDetails { get; set; }
    }
    public class OrderDetails
    {
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }


    
    public class CardinalMPI
    {
        [JsonProperty("Algorithm")]
        public string algorithm { get; set; }

        [JsonProperty("Amount")]
        public decimal amount { get; set; }

        [JsonProperty("BillAddrPostCode")]
        public ushort billAddrPostCode { get; set; }

        [JsonProperty("BillAddrState")]
        public string billAddrState { get; set; }

        [JsonProperty("BillingAddress1")]
        public string billingAddress1 { get; set; }

        [JsonProperty("BillingAddress2")]
        public object billingAddress2 { get; set; }

        [JsonProperty("BillingCity")]
        public string billingCity { get; set; }

        [JsonProperty("BillingCountryCode")]
        public ushort billingCountryCode { get; set; }

        [JsonProperty("BillingFirstName")]
        public string billingFirstName { get; set; }

        [JsonProperty("BillingFullName")]
        public string billingFullName { get; set; }

        [JsonProperty("BillingLastName")]
        public string billingLastName { get; set; }

        [JsonProperty("BillingPostalCode")]
        public ushort billingPostalCode { get; set; }

        [JsonProperty("BillingState")]
        public string billingState { get; set; }

        [JsonProperty("BrowserColorDepth")]
        public byte browserColorDepth { get; set; }

        [JsonProperty("BrowserHeader")]
        public string browserHeader { get; set; }

        [JsonProperty("BrowserJavaEnabled")]
        public bool browserJavaEnabled { get; set; }

        [JsonProperty("BrowserLanguage")]
        public string browserLanguage { get; set; }

        [JsonProperty("BrowserScreenHeight")]
        public ushort browserScreenHeight { get; set; }

        [JsonProperty("BrowserScreenWidth")]
        public ushort browserScreenWidth { get; set; }

        [JsonProperty("BrowserTimeZone")]
        public ushort browserTimeZone { get; set; }

        [JsonProperty("CardExpMonth")]
        public int cardExpMonth { get; set; }

        [JsonProperty("CardExpYear")]
        public int cardExpYear { get; set; }

        [JsonProperty("CardNumber")]
        public ulong cardNumber { get; set; }

        [JsonProperty("CurrencyCode")]
        public ushort currencyCode { get; set; }

        [JsonProperty("DFReferenceId")]
        public string dFReferenceId { get; set; }

        [JsonProperty("DeviceChannel")]
        public string deviceChannel { get; set; }

        [JsonProperty("Email")]
        public string email { get; set; }

        [JsonProperty("IPAddress")]
        public string iPAddress { get; set; }

        [JsonProperty("Identifier")]
        public string identifier { get; set; }

        [JsonProperty("MsgType")]
        public string msgType { get; set; }

        [JsonProperty("OrderNumber")]
        public string orderNumber { get; set; }

        [JsonProperty("OrgUnit")]
        public string orgUnit { get; set; }

        [JsonProperty("ShippingAddress1")]
        public string shippingAddress1 { get; set; }

        [JsonProperty("ShippingAddress2")]
        public object shippingAddress2 { get; set; }

        [JsonProperty("ShippingCity")]
        public ushort shippingCity { get; set; }

        [JsonProperty("ShippingCountryCode")]
        public ushort shippingCountryCode { get; set; }

        [JsonProperty("ShippingPostalCode")]
        public ushort shippingPostalCode { get; set; }

        [JsonProperty("ShippingState")]
        public string shippingState { get; set; }

        [JsonProperty("Signature")]
        public string signature { get; set; }

        [JsonProperty("Timestamp")]
        public long timestamp { get; set; }

        [JsonProperty("TransactionType")]
        public string transactionType { get; set; }

        [JsonProperty("UserAgent")]
        public string userAgent { get; set; }

        [JsonProperty("Version")]
        public string version { get; set; }


    }




}
