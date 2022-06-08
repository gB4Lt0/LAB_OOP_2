using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library
{
    public class StudentDTO
    {
        [JsonProperty("person")]
        public PersonDTO PersonInfo { get; set; }

        [JsonProperty("level_to_obtain")]
        public EducationalLVL LevelToObtain { get; set; }

        [JsonProperty("list_passed_exams")]
        public List<ExamDTO> PassedExams { get; set; } = new List<ExamDTO>();
    }
}
