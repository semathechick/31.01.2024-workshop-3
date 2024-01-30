using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        private readonly RentACarContext _context;

        public EfCustomerDal(RentACarContext context)
        {
            _context = context;
        }

        public Customer Add(Customer entity)
        {
            entity.CreatedAt = DateTime.UtcNow;

            _context.Customers.Add(entity);

            _context.SaveChanges();
            return entity;
        }

        public Customer Delete(Customer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Customer? Get(Func<Customer, bool> predicate)
        {
            Customer? customers = _context.Customers.FirstOrDefault(predicate); 
            return customers;
        }

        public IList<Customer> GetList(Func<Customer, bool>? predicate = null)
        {
            IQueryable<Customer> query = _context.Set<Customer>();
            if (predicate != null)
                query = query.Where(predicate).AsQueryable();

            return query.ToList(); 
        }
        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
