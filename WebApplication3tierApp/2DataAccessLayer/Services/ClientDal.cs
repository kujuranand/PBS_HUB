using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class ClientDal : IClientDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ClientDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ClientModel> GetAll()
        {
            var result = _db.Clients.ToList();

            var returnObject = new List<ClientModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToClientModel());
            }

            return returnObject;
        }

        public ClientModel? GetById(int Id)
        {
            var result = _db.Clients.SingleOrDefault(x => x.Id == Id);
            return result?.ToClientModel();
        }


        public int CreateClient(ClientModel Client)
        {
            var newClient = Client.ToClient();
            _db.Clients.Add(newClient);
            _db.SaveChanges();
            return newClient.Id;
        }


        public void UpdateClient(ClientModel Client)
        {
            var existingClient = _db.Clients
                .SingleOrDefault(x => x.Id == Client.Id);

            if (existingClient == null)
            {
                throw new ApplicationException($"Client {Client.Id} does not exist.");
            }
            Client.ToClient(existingClient);

            _db.Update(existingClient);
            _db.SaveChanges();
        }

        public void DeleteClient(int Id)
        {
            var efModel = _db.Clients.Find(Id);
            _db.Clients.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
