﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CordaApp.Services
{
    public class RestService
    {
        public string httpRequestService()
        {
            string result;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://52.170.25.149:8080/payStates/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponseQR = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponseQR.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                result = resultQR;
            }

            return result;

        }

        public async Task<string> httpReqService(List<KeyValuePair<string, string>> parameters, string api)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://52.170.25.149:8080");
            var request = new HttpRequestMessage(HttpMethod.Post, api);

            request.Content = new FormUrlEncodedContent(parameters);
            var response = await client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();
        }

    }
}
