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
    public class GetPersonbyIdHendler : IRequestHandler<GetPersonById, PersonModel>

    {
        public GetPersonbyIdHendler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator _mediator { get; }

        public async Task<PersonModel> Handle(GetPersonById request, CancellationToken cancellationToken)
        {
           var result= await _mediator.Send(request: new GetListPeopleQuery());

            var output = result.FirstOrDefault(x => x.Id == request.id);

            return output;

        }
    }
}
