namespace ParcelDeliverySystem;

public class Courier
{
    public int ParcelId { get; set; }
    public string CourierName { get; set; }
    public string Transport { get; set; }
    public List<IParcel> parcels = new List<IParcel>();
}