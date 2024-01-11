using ArtDL.Modelsa;
using ArtDL;
using ArtDTO.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBL
{
    public class ContactsBL : IContactsBL
    {
        private IContactsDL contactsDl;

        IMapper _mapper;

        public ContactsBL(IContactsDL contactsDl, IMapper mapper)
        {
            this.contactsDl = contactsDl;
            this._mapper = mapper;
        }

        public async Task<List<ContactDTO>> GetContacts()
        {
            try
            {
                List<Contact> res = await contactsDl.GetContacts();
                List<ContactDTO> contacts = _mapper.Map<List<ContactDTO>>(res);
                return contacts;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddContacts(ContactDTO contactdto)
        {
            try
            {

                Contact contact = _mapper.Map<Contact>(contactdto);
                bool isAddContacts = await contactsDl.AddContacts(contact);
                return isAddContacts;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> RemoveContacts(int contactId)
        {
            try
            {
                //User user = _mapper.Map<User>(userId);
                bool isRemoveContacts = await contactsDl.RemoveContacts(contactId);
                return isRemoveContacts;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
