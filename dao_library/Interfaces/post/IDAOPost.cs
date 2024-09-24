using entities_library.post;

namespace dao_library.Interfaces.post;

public interface IDAOPost
{
    Task<IEnumerable<Post>> GetAll();
    Task<Post> GetById(long id);
    Task Save(Post post);
    
    //NO PROGRAMAR
    Task Delete(Post post);
}