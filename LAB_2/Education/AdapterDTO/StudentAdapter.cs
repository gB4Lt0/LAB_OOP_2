﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StudentAdapter : IAdapter<Student, StudentDTO>
    {
        public StudentDTO ConvertToDTO(Student model)
        {
            PersonAdapter personAdapter = new PersonAdapter();
            ExamAdapter examAdpter = new ExamAdapter();

            StudentDTO studentDTO = new StudentDTO()
            {
                PersonInfo = personAdapter.ConvertToDTO(model.PersonInfo),
                LevelToObtain = model.LevelToObtain
            };

            foreach (var exam in model.PassedExams)
            {
                studentDTO.PassedExams.Add(examAdpter.ConvertToDTO(exam));
            }

            return studentDTO;
        }


        public Student ConvertToModel(StudentDTO dto)
        {
            PersonAdapter personAdapter = new PersonAdapter();
            ExamAdapter examAdpter = new ExamAdapter();

            Student student = new Student(personAdapter.ConvertToModel(dto.PersonInfo), dto.LevelToObtain);

            foreach (var exam in dto.PassedExams)
            {
                student.AddPassedExam(examAdpter.ConvertToModel(exam));
            }

            return student;
        }
    }
}
