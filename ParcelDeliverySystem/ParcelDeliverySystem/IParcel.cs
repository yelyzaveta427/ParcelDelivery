namespace ParcelDeliverySystem;

public interface IParcel
{
    int ID { get; }
    string Name { get; } 
    string Weight { get; }
    string City { get; }
    ParcelStatus Status { get; }

    string GetInfo();
}