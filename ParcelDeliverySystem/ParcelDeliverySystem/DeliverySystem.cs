namespace ParcelDeliverySystem;

public class DeliverySystem
{
    private List<IParcel> allParcels = new List<IParcel>();
    private Dictionary<int, Courier> couriersById = new Dictionary<int, Courier>();
    private Queue<IParcel> parcelsQueue = new Queue<IParcel>();
    private Stack<IParcel> parcelHistory = new Stack<IParcel>();

    public void AddToMainListOfParcels(IParcel p)
    {
        allParcels.Add(p);
        p.Status = ParcelStatus.Preparation;
        parcelsQueue.Enqueue(p);
        Console.WriteLine($"Parcel {p.ID} is on storage");
    }

    public void ShowInfoParcel()
    {
        foreach (var p in allParcels)
        {
            Console.WriteLine(p.GetInfo());
        }
    }
    
    public void RegisterCourier(Courier c)
    {
        if (!couriersById.ContainsKey(c.CourierId))
        {
            couriersById.Add(c.CourierId, c);
            Console.WriteLine($"Courier {c.CourierName} is registered");
        }
    }

    public void SendNestParcel(int courierId)
    {
        if (couriersById.TryGetValue(courierId, out Courier c))
        {
            if (parcelsQueue.Count > 0)
            {
                IParcel p = parcelsQueue.Dequeue();
                p.Status = ParcelStatus.InDelivery;
                c.CourierParcels.Add(p);
                Console.WriteLine($"Courier {c.CourierName} took parcel {p.ID} to city {p.City} and went by {c.Transport}");
            }
        }
    }

    public void DeliverParcel(int courierId, int parcelId)
    {
        if (couriersById.TryGetValue(courierId,out Courier c))
        {
            foreach (var p in c.CourierParcels)
            {
                if (p.ID == parcelId)
                {
                    p.Status = ParcelStatus.Delivered;
                    parcelHistory.Push(p);
                    Console.WriteLine($"Parcel {p.ID} is delivered");
                }
            }
        }
        else
        {
            Console.WriteLine("We do not have such courier");
        }
    }

    public void FindCourierById(int courierId)
    {
        if (couriersById.ContainsKey(courierId))
        {
            Console.WriteLine(($"Courier {couriersById[courierId].CourierName} is found"));
        }
        else
        {
            Console.WriteLine($"Courier with this id {courierId} is not found");
        }
    }

    public void ShowParcelByCity(string city)
    {
        foreach (var p in allParcels)
        {
            if (p.City == city)
            {
                Console.WriteLine($"Parcel {p.ID} has this city {city}");
            }
            else
            {
                Console.WriteLine($"Parcel to such city {city} is not found");
            }
        }
    }

    public void ShowStorage()
    {
        foreach (var p in parcelsQueue)
        {
            if (p.Status == ParcelStatus.Preparation)
            {
                Console.WriteLine($"Parcel {p.ID} is in queue");
            }
        }
    }
    
    
}