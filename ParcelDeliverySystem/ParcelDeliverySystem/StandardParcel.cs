namespace ParcelDeliverySystem;

public class StandardParcel:IParcel
{
    public string Name { get; }
    public int ID { get; }
    public string Weight { get; }
    public string City { get; }
    public ParcelStatus Status { get; }

    public StandardParcel(string name, int id, string weight, string city)
    {
        Name = name;
        ID = id;
        Weight = weight;
        City = city;
        Status = ParcelStatus.Taken;
    }

    public string GetInfo() => $"Standard parcel {Name} has id {ID} with weight {Weight} and destination {City}";
}
