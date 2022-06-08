using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ExamAdapter : IAdapter<Exam, ExamDTO>
    {
        public ExamDTO ConvertToDTO(Exam model) => new ExamDTO(){Title = model.Title, Grade = model.Mark, Date = model.Date};
        public Exam ConvertToModel(ExamDTO dto) => new Exam(dto.Title, dto.Grade, dto.Date);
    }
}
