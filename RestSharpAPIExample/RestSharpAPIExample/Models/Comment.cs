using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPIExample.Models
{
    public class Comment
    {
        [DeserializeAs(Name = "postId")]
        public int postId { get; set; }
        [DeserializeAs(Name = "id")]
        public int id { get; set; }
        [DeserializeAs(Name = "name")]
        public string name { get; set; }
        [DeserializeAs(Name = "email")]
        public string email { get; set; }
        [DeserializeAs(Name = "body")]
        public string body { get; set; }
    }
}
