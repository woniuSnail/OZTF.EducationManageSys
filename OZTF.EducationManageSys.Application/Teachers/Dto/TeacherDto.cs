using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Application.Teachers.Dto
{
    public class TeacherDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime? EntryTime { get; set; }

        public int Age { get; set; }

        public TeacherDto(Guid id, string tNumber, string name, string phone, string email, DateTime? entryTime, int age)
        {
            Id = id;
            TNumber = tNumber;
            Name = name;
            Phone = phone;
            Email = email;
            EntryTime = entryTime;
            Age = age;
        }
    }
}
