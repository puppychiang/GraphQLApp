using GraphQLApp.Models;

namespace GraphQLApp.Repositories
{
    public class QueryRepository
    {
        private readonly List<Book> books = new List<Book>();
        private readonly List<Author> authors = new List<Author>();

        /// <summary>
        /// 建構子
        /// </summary>
        public QueryRepository()
        {
            // 假Book資料
            var _books = new List<Book>()
            {
                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:神秘的魔法石", Category = "小說", AuthorId = 1 },
                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:消失的密室", Category = "小說", AuthorId = 1 },
                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:阿茲卡班的逃犯", Category = "小說", AuthorId = 1 },
                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:火盃的考驗", Category = "小說", AuthorId = 1 },
            };
            this.books = _books;

            // 假Author資料
            var _authors = new List<Author>()
            {
                new Author(){ Id = 1, Name = "JK Rowling", Birthday = "1965/7/31" }
            };
            this.authors = _authors;
        }


        /// <summary>
        /// 取得全部Book資料
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            return this.books;
        }

        /// <summary>
        /// 取得
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks(string category)
        {
            return this.books.Where(x => x.Category.Contains(category)).ToList();
        }

        /// <summary>
        /// 取得全部Author資料
        /// </summary>
        /// <returns></returns>
        public List<Author> GetAuthors()
        {
            return this.authors;
        }


    }
}
