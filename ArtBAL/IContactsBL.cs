using ArtDTO.DTO;

namespace ArtBL
{
    public interface IContactsBL
    {
        Task<List<ContactDTO>> GetContacts();
        Task<bool> AddContacts(ContactDTO contactdto);
        Task<bool> RemoveContacts(int contactId);
    }
}