using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IClientDal
    {
        // Getters
        ClientModel? GetById(int ClientId);
        List<ClientModel> GetAll();

        // Actions
        int CreateClient(ClientModel Client);
        void UpdateClient(ClientModel Client);
        void DeleteClient(int ClientId);
    }
}
