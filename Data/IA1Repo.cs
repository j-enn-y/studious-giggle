using A1.Models;

namespace A1.Data
{
    public interface IA1Repo
    {
        IEnumerable<Comment> GetComments();
        Comment GetCommentByID(int id);
        Comment AddComment(Comment comment);
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int id);
        Product AddProduct(Product product);
    }
}
