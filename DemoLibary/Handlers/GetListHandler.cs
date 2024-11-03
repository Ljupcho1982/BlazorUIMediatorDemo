using DemoLibary.DataAccess;
using DemoLibary.Model;
using DemoLibary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibary.Handlers
{
    public class GetListHandler : IRequestHandler<GetListPeopleQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetListHandler(IDataAccess data)
        {
            _data=data;

        }
        public Task<List<PersonModel>> Handle(GetListPeopleQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());

        }
    }
}
