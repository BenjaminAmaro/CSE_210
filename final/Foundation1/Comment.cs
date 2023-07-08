public class Comment
{
    public Comment(string user, string commentText)
    {
        _user = user;
        _commentText = commentText;
    }
    private string _user;
    private string _commentText;

    public string User()
    {
        return _user;
    }

    public string CommentText()
    {
        return _commentText;
    }


}
