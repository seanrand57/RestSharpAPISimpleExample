using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAPIExample.Models;
using System;

namespace RestSharpAPIExample
{
    [TestClass]
    public class CommentAPITests
    {
        [TestMethod]
        public void CommentWhereIDEquals_1()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("comments/1", Method.GET);
            request.AddUrlSegment("id", "1");
          
            IRestResponse<Comment> responseCommentModel = client.Execute<Comment>(request);
            
            Assert.AreEqual(1, responseCommentModel.Data.id,
                string.Format("ID {0} does not match actually {1}", 1, responseCommentModel.Data.id));
        }

        [TestMethod]
        public void CommentWherePostIdEquals_1()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("comments/1", Method.GET);
            request.AddUrlSegment("id", "1");

            IRestResponse<Comment> responseCommentModel = client.Execute<Comment>(request);

            Assert.AreEqual(1, responseCommentModel.Data.postId,
                string.Format("PostID {0} does not match actually {1}", 1, responseCommentModel.Data.postId));
        }

        [TestMethod]
        public void CommentWhereBodyContains_ispam()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("comments/1", Method.GET);
            request.AddUrlSegment("id", "1");

            IRestResponse<Comment> responseCommentModel = client.Execute<Comment>(request);
            var assert = responseCommentModel.Data.body.Contains("ipsam");
            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void CommentEmail_Test()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://jsonplaceholder.typicode.com/");

            var request = new RestRequest("comments/1", Method.GET);
            request.AddUrlSegment("id", "1");

            IRestResponse<Comment> responseCommentModel = client.Execute<Comment>(request);

            Assert.AreEqual("Eliseo@gardner.biz", responseCommentModel.Data.email,
                string.Format("Email {0} does not match {1}", "Eliseo@gardner.biz", responseCommentModel.Data.body));
        }
    }
}
