namespace refactor8
{
    public class Order
    {
        public Order(string customName)
        {
            Customer = customName;
        }

        public string Customer { get; set; }
    }
}
