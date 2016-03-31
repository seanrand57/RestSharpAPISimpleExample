using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;
using RestSharpAPIExample.Models;

namespace RestSharpAPIExample
{
    [TestClass]
    public class StatusAPITests
    {
        [TestMethod]
        public void ResponseReturned_Comments_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("comments");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }

        [TestMethod]
        public void ResponseReturned_Posts_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("posts");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }

        [TestMethod]
        public void ResponseReturned_Albums_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("albums");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }

        [TestMethod]
        public void ResponseReturned_Photos_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("photos");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }

        [TestMethod]
        public void ResponseReturned_Todos_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("todos");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }

        [TestMethod]
        public void ResponseReturned_Users_200()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("users");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,
                string.Format("Status code {0} does not match actually {1}", HttpStatusCode.OK, response.StatusCode));
        }       
    }    
}
