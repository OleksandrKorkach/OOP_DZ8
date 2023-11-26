namespace OOP_HW8;

public class FirstTask
{
    
}

class Order
{
    private List<FirstTask> itemList;

    internal List<FirstTask> ItemList
    {
        get { return itemList; }
        set { itemList = value; }
    }

    public void CalculateTotalSum() {/*...*/}
}

class OrderProcessor
{
    public void GetItems(Order order) {/*...*/}
    public void GetItemCount(Order order) {/*...*/}
    public void AddItem(Order order, FirstTask firstTask) {/*...*/}
    public void DeleteItem(Order order, FirstTask firstTask) {/*...*/}
    public void PrintOrder(Order order) {/*...*/}
    public void ShowOrder(Order order) {/*...*/}
}

class OrderPersistence
{
    public void Load(Order order) {/*...*/}
    public void Save(Order order) {/*...*/}
    public void Update(Order order) {/*...*/}
    public void Delete(Order order) {/*...*/}
}