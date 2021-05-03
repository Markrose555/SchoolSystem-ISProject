using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.Services
{
    public class StudentService
    {
        static HttpClient httpClient;
        private const string Url = "https://localhost:5001/api/Student";

        public StudentService()
        {
            httpClient = new HttpClient { BaseAddress = new Uri(Url) };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public StudentService(string baseUrl)
        {
            httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<HttpResponseMessage> GetStudent(string path = "Get")
        {
            return await httpClient.GetAsync(path);
        }
    }
}
