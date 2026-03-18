namespace ParcelDeliverySystem;
using ParcelDeliverySystem;
public class Program
{
    static void Main()
    {
        
        DeliverySystem postOffice = new DeliverySystem();
        
        StandardParcel p1 = new StandardParcel("Books", 101, "2kg", "Kyiv");
        FragileParcel p2 = new FragileParcel("Vase", 102, "1kg", "Lviv", "Bubble wrap");
        ExpressParcel p3 = new ExpressParcel("Laptop", 103, "3kg", "Kyiv", 1);
        
        postOffice.AddToMainListOfParcels(p1);
        postOffice.AddToMainListOfParcels(p2);
        postOffice.AddToMainListOfParcels(p3);
        
        Courier courier1 = new Courier(1, "Oleg", "Bicycle");
        postOffice.RegisterCourier(courier1);
        
        postOffice.ShowStorage();
        
        postOffice.SendNestParcel(1); 
        postOffice.SendNestParcel(1); 

        
        postOffice.ShowParcelByCity("Kyiv");

        postOffice.DeliverParcel(1, 101);
        
        postOffice.ShowInfoParcel();
    }
}
