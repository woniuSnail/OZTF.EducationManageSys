using OZTF.EducationManageSys.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OZTF.EducationManageSys.Application.Teachers.AddTeacher
{
    public class AddTeacherCommand : ICommand
    {
        public string Name { get; set; }

        public string TNumber { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime? EntryTime { get; set; }

        public AddTeacherCommand(string name, string tNumber, DateTime birthday, string phone, string email, DateTime? entryTime)
        {
            Name = name;
            TNumber = tNumber;
            Birthday = birthday;
            Phone = phone;
            Email = email;
            EntryTime = entryTime;
        }
    }
}
