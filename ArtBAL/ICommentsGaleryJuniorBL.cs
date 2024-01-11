using ArtDTO.DTO;

namespace ArtBL
{
    public interface ICommentsGaleryJuniorBL
    {
        Task<List<CommentsGaleryJuniorDTO>> GetCommentsgaleryjuniors();
    }
}