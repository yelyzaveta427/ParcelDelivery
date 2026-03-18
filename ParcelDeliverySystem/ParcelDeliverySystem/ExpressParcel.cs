namespace ParcelDeliverySystem;

public class ExpressParcel:IParcel
{
    public string Name { get; }
    public int ID { get; }
    public string Weight { get; }
    public string City { get; }
    public ParcelStatus Status { get; set; }
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