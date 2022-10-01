using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserManagerment.Model;
using UserManagerment.Queries;
using UserManagerment.Repositories;

namespace UserManagerment.Handlers
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<UserModel>>
    {
        private readonly IUserData _user;
        public GetUserListHandler(IUserData userData)
        {
            _user = userData;
        }
        public Task<List<UserModel>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_user.GetData());
        }
    }
}
