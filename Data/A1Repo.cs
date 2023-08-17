using A1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace A1.Data
{
    public class A1Repo : IA1Repo
    {
        private readonly A1DbContext _dbContext;
        public A1Repo(A1DbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Comment> GetComments() 
        {
            IEnumerable<Comment> comments = _dbContext.Comments.ToList<Comment>();
            return comments;
        }
        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = _dbContext.Products.ToList<Product>();
            return products;
        }
        public Comment GetCommentByID(int id)
        {
            Comment comment = _dbContext.Comments.FirstOrDefault(e => e.Id == id);
            return comment;
        }
        public Product GetProductByID(int id)
        {
            Product product = _dbContext.Products.FirstOrDefault(e => e.Id == id);
            return product;
        }
        public Comment AddComment(Comment comment)
        {
            EntityEntry<Comment> e = _dbContext.Comments.Add(comment);
            Comment c = e.Entity;
            _dbContext.SaveChanges();
            return c;
        }
        public Product AddProduct(Product product)
        {
            EntityEntry<Product> e = _dbContext.Products.Add(product);
            Product p = e.Entity;
            _dbContext.SaveChanges();
            return p;
        }
    }
}
