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
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
