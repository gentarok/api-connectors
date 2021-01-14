using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BybitAPI.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        //private readonly JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        //{
        //    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        //};

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response);

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        public ApiClient()
        {
            Configuration = Client.Configuration.Default;
            RestClient = new RestClient("https://api.bybit.com");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path (https://api.bybit.com).
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config)
        {
            Configuration = config ?? Client.Configuration.Default;

            RestClient = new RestClient(Configuration.BasePath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(string basePath = "https://api.bybit.com")
        {
            if (string.IsNullOrEmpty(basePath))
            {
                throw new ArgumentException("basePath cannot be empty");
            }

            RestClient = new RestClient(basePath);
            Configuration = Client.Configuration.Default;
        }

        /// <summary>
        /// Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The default API client.</value>
        [Obsolete("ApiClient.Default is deprecated, please use 'Configuration.Default.ApiClient' instead.")]
        public static ApiClient? Default;

        /// <summary>
        /// Gets or sets an instance of the IReadableConfiguration.
        /// </summary>
        /// <value>An instance of the IReadableConfiguration.</value>
        /// <remarks>
        /// <see cref="IReadableConfiguration"/> helps us to avoid modifying possibly global
        /// configuration values from within a given client. It does not guarantee thread-safety
        /// of the <see cref="Configuration"/> instance in any way.
        /// </remarks>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public IRestClient RestClient { get; set; }

        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            string path, Method method, List<KeyValuePair<string, string>> queryParams, object? postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach (var param in pathParams)
            {
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);
            }

            // add header parameter, if any
            foreach (var param in headerParams)
            {
                request.AddHeader(param.Key, param.Value);
            }

            // add query parameter, if any
            foreach (var param in queryParams)
            {
                request.AddQueryParameter(param.Key, param.Value);
            }

            // add form parameter, if any
            foreach (var param in formParams)
            {
                request.AddParameter(param.Key, param.Value);
            }

            // add file parameter, if any
            foreach (var param in fileParams)
            {
                using var ms = new MemoryStream();
                param.Value.Writer.Invoke(ms);
                var bytes = ms.ToArray();
                request.AddFile(param.Value.Name, bytes, param.Value.FileName, param.Value.ContentType);
            }

            if (postBody is not null) // http body (model or byte[]) parameter
            {
                request.AddParameter(contentType, postBody, ParameterType.RequestBody);
            }

            return request;
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Object</returns>
        public object CallApi(
            string path, Method method, List<KeyValuePair<string, string>> queryParams, object? postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            // set timeout

            RestClient.Timeout = Configuration.Timeout;
            // set user agent
            RestClient.UserAgent = Configuration.UserAgent;

            InterceptRequest(request);
            var response = RestClient.Execute(request);
            InterceptResponse(request, response);

            return response;
        }

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async Task<object> CallApiAsync(
            string path, Method method, List<KeyValuePair<string, string>> queryParams, object? postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);
            InterceptRequest(request);
            var response = await RestClient.ExecuteAsync(request);
            InterceptResponse(request, response);
            return response;
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str) => UrlEncode(str);

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream) => stream is FileStream stream1
                ? FileParameter.Create(name, ReadAsBytes(stream), Path.GetFileName(stream1.Name))
                : FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            switch (obj)
            {
                case DateTime time:
                    // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                    // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                    // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                    // For example: 2009-06-15T13:45:30.0000000
                    return time.ToString(Configuration.DateTimeFormat);

                case DateTimeOffset offset:
                    // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                    // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                    // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                    // For example: 2009-06-15T13:45:30.0000000
                    return offset.ToString(Configuration.DateTimeFormat);

                case IList list:
                    {
                        var flattenedString = new StringBuilder();
                        foreach (var param in list)
                        {
                            if (flattenedString.Length > 0)
                            {
                                flattenedString.Append(",");
                            }

                            flattenedString.Append(param);
                        }
                        return flattenedString.ToString();
                    }

                default:
                    return Convert.ToString(obj);
            }
        }

        //[return: MaybeNull]
        ///// <summary>
        ///// Deserialize the JSON string into a proper object.
        ///// </summary>
        ///// <param name="response">The HTTP response.</param>
        ///// <param name="type">Object type.</param>
        ///// <returns>Object representation of the JSON string.</returns>
        //public object Deserialize(IRestResponse response, Type type)
        //{
        //    var headers = response.Headers;
        //    if (type == typeof(byte[])) // return byte array
        //    {
        //        return response.RawBytes;
        //    }

        //    // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
        //    if (type == typeof(Stream))
        //    {
        //        if (headers is not null)
        //        {
        //            var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
        //                ? Path.GetTempPath()
        //                : Configuration.TempFolderPath;
        //            var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
        //            foreach (var header in headers)
        //            {
        //                var match = regex.Match(header.ToString());
        //                if (match.Success)
        //                {
        //                    var fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
        //                    File.WriteAllBytes(fileName, response.RawBytes);
        //                    return new FileStream(fileName, FileMode.Open);
        //                }
        //            }
        //        }
        //        var stream = new MemoryStream(response.RawBytes);
        //        return stream;
        //    }

        //    if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
        //    {
        //        return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
        //    }

        //    if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
        //    {
        //        return ConvertType(response.Content, type);
        //    }

        //    // at this point, it must be a model (json)
        //    try
        //    {
        //        return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new ApiException(500, e.Message);
        //    }
        //}

        //[return: MaybeNull]
        ///// <summary>
        ///// Serialize an input (model) into JSON string
        ///// </summary>
        ///// <param name="obj">Object.</param>
        ///// <returns>JSON string.</returns>
        //public string Serialize(object obj)
        //{
        //    try
        //    {
        //        return obj is not null ? JsonConvert.SerializeObject(obj) : null;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new ApiException(500, e.Message);
        //    }
        //}

        /// <summary>
        ///Check if the given MIME is a JSON MIME.
        ///JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public bool IsJsonMime(string mime)
        {
            var jsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
            return mime is not null && (jsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json"));
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
            {
                return "application/json";
            }

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType.ToLower()))
                {
                    return contentType;
                }
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        [return: MaybeNull]
        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
            {
                return null;
            }

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
            {
                return "application/json";
            }

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
            => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic fromObject, Type toObject)
            => Convert.ChangeType(fromObject, toObject);

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            var buf = new byte[16 * 1024];
            using var ms = new MemoryStream();
            int count;
            while ((count = inputStream.Read(buf, 0, buf.Length)) > 0)
            {
                ms.Write(buf, 0, count);
            }
            return ms.ToArray();
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            var sb = new StringBuilder(input.Length * 2);
            var index = 0;

            while (index < input.Length)
            {
                var length = Math.Min(input.Length - index, maxLength);
                var subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            var match = Regex.Match(filename, @".*[/\\](.*)$");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return filename;
            }
        }

        /// <summary>
        /// Convert params to key/value pairs.
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A list of KeyValuePairs</returns>
        public IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name, object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection select new KeyValuePair<string, string>(name, ParameterToString(item)));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name, ParameterToString(value)));
            }

            return parameters;
        }

        /// <summary>
        /// Check if generic object is a collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if object is a collection type</returns>
        private static bool IsCollection(object value) => value is IList || value is ICollection;
    }
}