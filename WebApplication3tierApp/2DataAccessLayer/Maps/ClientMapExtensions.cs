using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class ClientMapExtensions
    {
        public static ClientModel ToClientModel(this Client src)
        {
            var dst = new ClientModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Behaviour = src.Behaviour;

            return dst;
        }

        public static Client ToClient(this ClientModel src, Client dst = null)
        {
            if (dst == null)
            {
                dst = new Client();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Behaviour = src.Behaviour;

            return dst;
        }
    }
}
