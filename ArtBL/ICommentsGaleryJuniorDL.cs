using ArtDL.Modelsa;

namespace ArtDL
{
    public interface ICommentsGaleryJuniorDL
    {
        Task<List<Commentsgaleryjunior>> GetCommentsgaleryjuniors();
        Task<bool> AddCommentsgaleryjuniors(Commentsgaleryjunior commentsgaleryjuniors);
        Task<bool> RemoveCommentsgaleryjuniors(int commentsgaleryjuniorId);
    }
}