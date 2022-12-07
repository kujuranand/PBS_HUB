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
    public class PractitionerDal : IPractitionerDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public PractitionerDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<PractitionerModel> GetAll()
        {
            var result = _db.Practitioners.ToList();

            var returnObject = new List<PractitionerModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToPractitionerModel());
            }

            return returnObject;
        }

        public PractitionerModel? GetById(int Id)
        {
            var result = _db.Practitioners.SingleOrDefault(x => x.Id == Id);
            return result?.ToPractitionerModel();
        }


        public int CreatePractitioner(PractitionerModel Practitioner)
        {
            var newPractitioner = Practitioner.ToPractitioner();
            _db.Practitioners.Add(newPractitioner);
            _db.SaveChanges();
            return newPractitioner.Id;
        }


        public void UpdatePractitioner(PractitionerModel Practitioner)
        {
            var existingPractitioner = _db.Practitioners
                .SingleOrDefault(x => x.Id == Practitioner.Id);

            if (existingPractitioner == null)
            {
                throw new ApplicationException($"Practitioner {Practitioner.Id} does not exist.");
            }
            Practitioner.ToPractitioner(existingPractitioner);

            _db.Update(existingPractitioner);
            _db.SaveChanges();
        }

        public void DeletePractitioner(int Id)
        {
            var efModel = _db.Practitioners.Find(Id);
            _db.Practitioners.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
