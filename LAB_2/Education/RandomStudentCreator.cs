using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RandomStudentCreator
    {
        public string[] names = { "Roman", "Ruslan", "Illya", "OLeg", "Ivan", "Vladislav", "Maksim", "Lena" };

        public string[] surnames = { "Tsarenko", "Kasyanovich", "Porublov", "Nevmytyy", "Zadorozhniy", "Polygalov", "Petryuk", "Lopez" };

        public string[] exams = { "Algebra", "Biology", "Drawing", "Chemistry", "Geography", "Geometry", "Physics" };

        public EducationalLVL[] educationalLevels = Enum.GetValues(typeof(EducationalLVL)).Cast<EducationalLVL>().ToArray();

        public Person GetRandomPerson()
        {
            Random random = new Random();

            Person person = new Person(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], new DateTime(2002, random.Next(1, 12), random.Next(1, 28)));

            return person;
        }

        public List<Exam> GetRandomExams()
        {
            Random random = new Random();

            List<Exam> listExam = new List<Exam>();

            for (int i = 0; i < random.Next(1, exams.Length); i++)
            {
                listExam.Add(new Exam(
                exams[i],
                random.Next(0, 100),
                new DateTime(2021, random.Next(1, 12), random.Next(1, 28))
                ));
            }

            return listExam;
        }

        public EducationalLVL GetRandomEducationalLevel()
        {
            Random random = new Random();

            return educationalLevels[random.Next(0, educationalLevels.Length)];
        }

        public Student[] GetRandomStudents()
        {
            Random random = new Random();

            Student[] students = new Student[random.Next(1, 10)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(GetRandomPerson(), GetRandomEducationalLevel(), GetRandomExams());
            }

            return students;
        }
    }
}
