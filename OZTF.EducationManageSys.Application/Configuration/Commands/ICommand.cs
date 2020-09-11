﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Application.Configuration.Commands
{
    public interface ICommand : IRequest
    {

    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {

    }
}
