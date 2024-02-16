using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace WebApplication.API.BadPracticeWithEnum
{
    public enum ProductSize
    {
        Small = 1,
        Medium = 2,
        Large = 3,

        // It must be a compile-time constant(localization problem may arise),
        // DisplayName attribute isn’t a built-in enum feature
        // You can  use reflection to get its value
        [Display(Name = "Extra Large")] XLarge = 4,
        XXLarge = 5
    }

    // Poor Domain Model(Business logic separate from domain model - Anti Pattern)
    public static class ProductSizeExtensions
    {
        public static bool IsLargeType(this ProductSize size)
        {
            return size == ProductSize.Large || size == ProductSize.XLarge || size == ProductSize.XXLarge;
        }
    }


    public class EnumExample
    {
        public void Run()
        {
            //Explicit Casting
            int size = (int)ProductSize.Large;
            //Explicit Casting
            ProductSize size2 = (ProductSize)1;
        }
    }
}