namespace ParcelDeliverySystem;

public class DeliverySystem
{
    private List<IParcel> allParcels = new List<IParcel>();
    private Dictionary<int, Courier> couriersById = new Dictionary<int, Courier>();
    private Queue<IParcel> parcelsQueue = new Queue<IParcel>();
    private Stack<IParcel> parcelHistory = new Stack<IParcel>();

    public void AddToCourierList(IParcel p)
    {
        
    }
}