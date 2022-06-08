using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library
{
    public class ExamDTO
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("grade")]
        public int Grade { get; set; }
    }
}
