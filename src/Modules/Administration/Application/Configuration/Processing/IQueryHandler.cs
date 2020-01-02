﻿using CompanyName.MyMeetings.Modules.Administration.Application.Contracts;
using MediatR;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Processing
{
    public interface IQueryHandler<in TQuery, TResult> : 
        IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {

    }
}