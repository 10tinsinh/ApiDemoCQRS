using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserManagerment.Commands;
using UserManagerment.Model;
using UserManagerment.Repositories;

namespace UserManagerment.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, UserModel>
    {
        private readonly IUserData _user;
        public AddUserHandler(IUserData userData)
        {
            _user = userData;
        }
        public Task<UserModel> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_user.Create(request.user));
        }
    }
}
