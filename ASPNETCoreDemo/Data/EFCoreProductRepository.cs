using ASPNETCoreDemo.Models;

namespace ASPNETCoreDemo.Data
{
    public class EFCoreProductRepository : EfCoreRepository<Product, Context>
    {
        public EFCoreProductRepository(Context context) : base(context)
        {

        }
        // add other product specific stuff here
    }
}