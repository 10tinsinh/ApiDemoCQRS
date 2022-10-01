using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserManagerment.Model;
using UserManagerment.Queries;

namespace UserManagerment.Handlers
{
    public class GetUserModelByIdHandler : IRequestHandler<GetUserByIdQuery, UserModel>
    {
        private readonly IMediator _mediator;
        public GetUserModelByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<UserModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var users = await _mediator.Send(new GetUserListQuery());
            var user = users.FirstOrDefault(e => e.Id == request.id);
            return user;
        }
    }
}
