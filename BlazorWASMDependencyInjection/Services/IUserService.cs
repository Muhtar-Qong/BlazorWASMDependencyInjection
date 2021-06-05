using BlazorWASMDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMDependencyInjection.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetUsers();
    }
}
