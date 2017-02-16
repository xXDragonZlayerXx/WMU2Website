using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CodeBustersWMU2WebSite.Models;
using Newtonsoft.Json;


namespace CodeBustersWMU2WebSite.Models
{
    public class Task
    {
   
        public int TaskId { get; set; }

        public string BeginDateTime { get; set; }
        public string DeadlineDateTime { get; set; }

        public string Title { get; set; }

        public string Requirements { get; set; }

    }

    public class TaskService
    {

        readonly string baseUri = "http://localhost:53805/api/tasks";

        public List<Models.Task> GetTasks()
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Models.Task>>(response.Result).Result;
            }

        }
    }

    /*public class AssignmentService
    {

        readonly string baseUri = "http://localhost:53805/api/values/getallTasks";

        public List<Models.Task> GetTasks()
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Models.Task>>(response.Result).Result;
            }

        }
    }*/


}
