using ArtDL.Modelsa;

namespace ArtDL
{
    public interface ICommentsGaleryJuniorDL
    {
        Task<List<CommentsGaleryJunior>> GetCommentsGaleryJuniors();
        Task<bool> AddCommentsGaleryJuniors(CommentsGaleryJunior CommentsGaleryJuniors);
        Task<bool> RemoveCommentsGaleryJuniors(int CommentsGaleryJuniorId);
    }
}