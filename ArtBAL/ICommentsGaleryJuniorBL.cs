using ArtDTO.DTO;

namespace ArtBL
{
    public interface ICommentsGaleryJuniorBL
    {
        Task<List<CommentsGaleryJuniorDTO>> GetCommentsgaleryjuniors();
        Task<bool> AddCommentsgaleryjuniors(CommentsGaleryJuniorDTO commentsGaleryJuniorDTO);
        Task<bool> RemoveCommentsgaleryjuniors(int commentsgaleryjuniorId);
    }
}