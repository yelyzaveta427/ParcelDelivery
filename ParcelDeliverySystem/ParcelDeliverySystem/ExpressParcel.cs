namespace ParcelDeliverySystem;

public class ExpressParcel
{
    private string Name { get; }
    private int ID { get; }
    private string Weight { get; }
    private string City { get; }
    public ParcelStatus Status { get; set; }
    private string ProtectionMaterial { get; set; }
    public int DaysToDeliver { get; set; }

    public ExpressParcel(string name, int id, string weight, string city, int daysToDeliver)
    {
        Name = name;
        ID = id;
        Weight = weight;
        City = city;
        DaysToDeliver = daysToDeliver;
        Status = ParcelStatus.Taken;
    }

    public string GetInfo() => $"Standard parcel {Name} has id {ID} with weight {Weight}, destination {City} and day to deliver {DaysToDeliver}";
}