using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.DataAccessLayer.Abstract;
using Travelaa.DataAccessLayer.EntityFramework;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public int TContactCount()
        {
            return _contactDal.ContactCount();
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
