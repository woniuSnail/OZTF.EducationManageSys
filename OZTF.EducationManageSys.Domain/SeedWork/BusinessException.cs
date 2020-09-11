using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.SeedWork
{
    public class BusinessException : Exception
    {
        private readonly IBusinessRule _rule;

        public BusinessException(IBusinessRule rule)
            : base(rule.Message)
        {
            _rule = rule;
        }
    }
}
