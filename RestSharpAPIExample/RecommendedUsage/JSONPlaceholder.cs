using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendedUsage
{
    public class JSONPlaceholder
    {
        const string BaseURL = "http://jsonplaceholder.typicode.com/";

        readonly string _endPoint;

        public JSONPlaceholder(string endPoint)
        {
            _endPoint = endPoint;
        }

        public static T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BaseURL);

            var response = client.Execute<T>(request);

            if(response.ErrorException != null)
            {
                throw new ApplicationException(response.ErrorMessage);
            }

            return response.Data;        
        }

        public Photo GetPhoto(int id)
        {
            var request = new RestRequest();
            request.Resource = "photos/{ID}";//+ id.ToString();

            request.RootElement = "photos";

            request.AddParameter("ID", id.ToString(), ParameterType.UrlSegment);

            // JSONPlaceholder jph = new JSONPlaceholder("photos");
            return JSONPlaceholder.Execute<Photo>(request);
        }

    }
}
