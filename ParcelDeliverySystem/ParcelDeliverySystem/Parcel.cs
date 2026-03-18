namespace ParcelDeliverySystem;

public class Parcel:IParcel
{
    public string Name { get; }
    public int ID { get; }
    public string Weight { get; }
    public string City { get; }
    public ParcelStatus Status { get; }

    public Parcel(string name, int id, string weight, string city)
    {
        Name = name;
        ID = id;
        Weight = weight;
        City = city;
    }

    public string GetInfo() => $"Parcel {Name} has id {ID} with weight {Weight} and destination {City}";
}