using System;

namespace OZTF.EducationManageSys.Application.Students.Dto
{
    public class StudentDto
    {
        public Guid Id { get; set; }

        public string SNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime AdmissionTime { get; set; }

        public int Age { get; set; }

        public StudentDto(Guid id, string sNumber, string name, string email, string phone, DateTime admissionTime, DateTime birthday)
        {
            Id = id;
            SNumber = sNumber;
            Name = name;
            Email = email;
            Phone = phone;
            AdmissionTime = admissionTime;
            Age = DateTime.Now.Year - birthday.Year;
        }
    }
}
