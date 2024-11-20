namespace GraphQLApp.Models
{
    /// <summary>
    /// 書籍 DB Model
    /// </summary>
    public class Book
    {
        public Book()
        {
            Name = string.Empty;
            Category = string.Empty;
        }

        /// <summary>
        /// 編號
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 書名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 分類
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public int AuthorId { get; set; }
    }
}
