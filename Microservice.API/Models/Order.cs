namespace Microservice.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        public OrderStatus Status { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }

    public enum PaymentStatus : byte
    {
        NotPaid,
        Paid,
        Error
    }

    public enum ShipmentStatus : byte
    {
        NotShipped, // Sevk edilmemiş
        Shipped, // Sevk edilmiş
        Delivered // Müşteriye sipariş teslimi gerçekleştirilmiş
    }

    public enum PaymentType : byte
    {
        CreditCard, // Kredi kartı
        CashOnDelivery, // Kapıda Ödeme
    }

    public enum OrderStatus : byte
    {
        Cancelled, // İptal edilmiş
        Processing, // Henüz sevk edilmemiş
        Completed, // sipariş sevk edildiğinde 
        Refunded // İade Edilmiş 
    }
}