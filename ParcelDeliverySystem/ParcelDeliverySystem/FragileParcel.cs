namespace ParcelDeliverySystem;

public class FragileParcel
{
    private string Name { get; }
    private int ID { get; }
    private string Weight { get; }
    private string City { get; }
    public ParcelStatus Status { get; set; }
    private string ProtectionMaterial { get; set; }

    public FragileParcel(string name, int id, string weight, string city, string protectionMaterial)
    {
        Name = name;
        ID = id;
        Weight = weight;
        City = city;
        ProtectionMaterial = protectionMaterial;
        Status = ParcelStatus.Taken;
    }

    public string GetInfo() => $"Standard parcel {Name} has id {ID} with weight {Weight}, destination {City} and protection material {ProtectionMaterial}";
}