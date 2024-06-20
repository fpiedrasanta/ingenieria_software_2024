using entities_library.comment;
using entities_library.login;
using entities_library.reactions;

namespace entities_library.post;

public class Post
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();

    public List<Reaction> Reactions { get; set; } = new List<Reaction>();

    public DateTime DateTime { get; set; }

    public required User User { get; set; }

    public PostStatus PostStatus { get; set; }

    public string LinkVideo { get; set; } = "";

    public entities_library.file_system.File? File { get; set; }
}