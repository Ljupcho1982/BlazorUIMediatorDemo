using DemoLibary.Commands;
using DemoLibary.DataAccess;
using DemoLibary.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;
        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }

      

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.Insertpeople(request.FirstName, request.LastName));
        }
    }
}
