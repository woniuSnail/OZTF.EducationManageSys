using OZTF.EducationManageSys.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Application.Students.RemoveStudent
{
    public class RemoveStudentCommand : ICommand
    {
        public Guid Id { get; set; }

        public RemoveStudentCommand(Guid id)
        {
            Id = id;
        }
    }
}
