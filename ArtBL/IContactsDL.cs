using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IContactsDL
    {
        Task<List<Contact>> GetContacts();
        Task<bool> AddContacts(Contact contact);
        Task<bool> RemoveContacts(int contactId);
    }
}