using OZTF.EducationManageSys.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Application.Students.UpdateStudent
{
    public class UpdateStudentCommand : ICommand
    {
        public Guid Id { get; set; }

        public string SNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public DateTime AdmissionTime { get; set; }

        public UpdateStudentCommand(Guid id, string sNumber, string name, string email, DateTime birthday, string phone, DateTime admissionTime)
        {
            Id = id;
            SNumber = sNumber;
            Name = name;
            Email = email;
            Birthday = birthday;
            Phone = phone;
            AdmissionTime = admissionTime;
        }
    }
}
