using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.SeedWork
{
    public abstract class Entity
    {
        protected static void CheckRule(IBusinessRule rule)
        {
            if(!rule.IsPass())
            {
                throw new BusinessException(rule);
            }
        }
    }
}
