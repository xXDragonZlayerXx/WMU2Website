using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeBustersWMU2WebSite.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BeginDateTime { get; set; }
        [MaxLength(50)]
        public string DeadlineDateTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Requirements { get; set; }

    }

    public class TaskService
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
    }

    public class AssignmentService
    {
        readonly string baseUri = "http://localhost:53805/api/values/getallassignments";
        A
        public List<AssignmentService> GetAssignment()
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Models.>>(response.Result).Result;
            }

        }
    }
}
