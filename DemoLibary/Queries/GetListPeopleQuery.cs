﻿using DemoLibary.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibary.Queries
{
    public record GetListPeopleQuery():IRequest<List <PersonModel>>
    {


    }
}
