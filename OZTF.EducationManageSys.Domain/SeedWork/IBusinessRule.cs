using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.SeedWork
{
    public interface IBusinessRule
    {
        bool IsPass();

        string Message { get; }

        int ErrorCode { get; }
    }
}
