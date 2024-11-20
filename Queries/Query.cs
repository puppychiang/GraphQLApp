using GraphQLApp.Models;
using GraphQLApp.Repositories;

namespace GraphQLApp.Queries
{
    /// <summary>
    /// GraphQL Query (此層級相當於原始 API 的 Controller)
    /// </summary>
    public class Query
    {
        /// <summary>
        /// 取得全部Books
        /// </summary>
        /// <param name="queryRepository"></param>
        /// <returns></returns>
        public List<Book>? GetBooks([Service] QueryRepository queryRepository) => queryRepository.GetBooks();

        /// <summary>
        /// 取得全部Books by category
        /// </summary>
        /// <param name="queryRepository"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Book>? GetBooksByCategory([Service] QueryRepository queryRepository, string category) => queryRepository.GetBooks(category);

        /// <summary>
        /// 取得全部Authors
        /// </summary>
        /// <param name="queryRepository"></param>
        /// <returns></returns>
        public List<Author>? GetAuthors([Service] QueryRepository queryRepository) => queryRepository.GetAuthors();

        //原始GraphQL寫法
        //public Query()
        //{
        //    Field<ListGraphType<Book>>(
        //        "books",
        //        arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "query", Description = "查詢" }),
        //        resolve: context =>
        //        {
        //            // 取得查詢參數
        //            var queryString = context.GetArgument<string>("queryCategory");

        //            // 建立假的書籍列表
        //            var bookList = new List<Book>()
        //            {
        //                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:神秘的魔法石", Category = "小說" },
        //                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:消失的密室", Category = "小說" },
        //                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:阿茲卡班的逃犯", Category = "小說" },
        //                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:火盃的考驗", Category = "小說" },
        //                new Book(){ Id = Guid.NewGuid(), Name = "哈利波特:鳳凰會的密令", Category = "小說" },
        //            };

        //            // 篩選查詢資料
        //            var result = bookList.Where(x => x.Name.Contains(queryString) || x.Category.Contains(queryString)).ToList();

        //            return result;
        //        }
        //    );
        //}
    }
}
