using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ClientDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Behaviour { get; set; } 
    }

    public static class ClientDtoMapExtensions
    {
        public static ClientDto ToClientDto(this ClientModel src)
        {
            var dst = new ClientDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Behaviour = src.Behaviour;
            return dst;
        }

        public static ClientModel ToClientModel(this ClientDto src)
        {
            var dst = new ClientModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Behaviour = src.Behaviour;
            return dst;
        }
    }
}
