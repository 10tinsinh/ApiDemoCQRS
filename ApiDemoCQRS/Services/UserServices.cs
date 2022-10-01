using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagerment.Commands;
using UserManagerment.Model;
using UserManagerment.Queries;

namespace ApiDemoCQRS.Services
{
    public class UserServices : IUserServices
    {
        private readonly IMediator _mediator;
        public UserServices(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task<UserModel> Create(UserModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> GetData()
        {
            return await _mediator.Send(new GetUserListQuery());
        }

        public async Task<UserModel> GetDataById(string Id)
        {
            return await _mediator.Send(new GetUserByIdQuery(Id));
        }
        public async Task<UserModel> CreateUser(UserModel user)
        {
            return await _mediator.Send(new AddUserCommand(user));
        }
    }
}
