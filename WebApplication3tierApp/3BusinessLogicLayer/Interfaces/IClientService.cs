using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IClientService
    {
        Task<ClientModel?> GetById(int Id);
        Task<List<ClientModel>> GetAll();

        Task<int> CreateClient(ClientModel Client);
        Task UpdateClient(ClientModel Client);
        Task DeleteClient(int Id);
    }
}
