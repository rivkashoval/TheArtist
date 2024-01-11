using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class ContactsDL : IContactsDL
    {
        private ArtProjectContext _ArtProjectContext;

        public ContactsDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<Contact>> GetContacts()
        {
            try
            {
                List<Contact> contacts = await _ArtProjectContext.Contacts.ToListAsync();
                return contacts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //הוספה
        public async Task<bool> AddContacts(Contact contact)
        {
            try
            {
                await _ArtProjectContext.Contacts.AddAsync(contact);
                _ArtProjectContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        //מחיקה
        public async Task<bool> RemoveContacts(int contactId)
        {
            try
            {

                Contact contact = await _ArtProjectContext.Contacts.FirstOrDefaultAsync(item => item.Id == contactId);
                _ArtProjectContext.Contacts.Remove(contact);
                await _ArtProjectContext.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

    }
}
