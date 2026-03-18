namespace ParcelDeliverySystem;

public class Courier
{
    public int CourierId { get; set; }
    public string CourierName { get; set; }
    public string Transport { get; set; }

    public Courier(int courierId, string courierName, string transport)
    {
        CourierId = courierId;
        CourierName = courierName;
        Transport = transport;
    }
    public List<IParcel> CourierParcels = new List<IParcel>();
}