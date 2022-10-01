using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagerment.Model;

namespace UserManagerment.Queries
{
    public record GetUserByIdQuery(string id) : IRequest<UserModel>;
    
}
