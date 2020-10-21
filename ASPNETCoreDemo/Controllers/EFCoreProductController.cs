using ASPNETCoreDemo.Data;
using ASPNETCoreDemo.Models;

namespace ASPNETCoreDemo.Controllers
{
    public class EFCoreProductController : EfCoreRepository<Product, Context>
    {
        public EFCoreProductController(Context context) : base(context)
        {

        }
    }
}