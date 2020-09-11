using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Application.Students.Dto;
using System;

namespace OZTF.EducationManageSys.Application.Students.AddStudent
{
    public class AddStudentCommand : ICommand<StudentDto>
    {
        public string SNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public DateTime AdmissionTime { get; set; }

        public AddStudentCommand(string sNumber, string name, string email, DateTime birthday, string phone, DateTime admissionTime)
        {
            SNumber = sNumber;
            Name = name;
            Email = email;
            Birthday = birthday;
            Phone = phone;
            AdmissionTime = admissionTime;
        }
    }
}
