namespace GraphQLApp.Models
{
    /// <summary>
    /// 作者 DB Model
    /// </summary>
    public class Author
    {
        public Author()
        {
            Name = string.Empty;
            Birthday = string.Empty;
        }

        public int Id { get; set; }
        /// <summary>
        /// 作者名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { get; set; }
    }
}
