namespace SimpleBlog.Models
{
    public class ArticlesModel
    {
        public string title;
        public string shortText;
        public string author;

        public ArticlesModel(string title, string shortText, string author)
        {
            this.title = title;
            this.shortText = shortText;
            this.author = author;
        }
    }
}