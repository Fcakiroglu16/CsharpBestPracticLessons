namespace WebApplication.API;

public record ProductSize(int Value, string Name)
{
    public static ProductSize Small { get; } = new ProductSize(1, "Small");
    public static ProductSize Medium { get; } = new ProductSize(2, "Medium");
    public static ProductSize Large { get; } = new ProductSize(3, "Large");
    public static ProductSize XLarge { get; } = new ProductSize(4, "Extra Large");
    public static ProductSize XXLarge { get; } = new ProductSize(5, "Extra Extra Large");

    public static implicit operator int(ProductSize size) => size.Value;

    public static implicit operator ProductSize(int value) => value switch
    {
        1 => Small,
        2 => Medium,
        3 => Large,
        4 => XLarge,
        5 => XXLarge,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };
    public bool IsSizeInLargeType() => this == Large || this == XLarge || this == XXLarge;
    public override string ToString() => Name;
}

public class RecordAsEnumExample
{
    public void Run()
    {
        ProductSize productSize = ProductSize.Large;

        int productSizeAsNumber = ProductSize.XXLarge;

        ProductSize sizeAsProductSizeType = 1;

        var ProductSizeAsName = ProductSize.XXLarge.ToString();
    }
}
