namespace InventoryManegement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryManegement obj = new FetchInventoryManegement();
            string filePath = "C:\\Users\\sir\\Desktop\\dotNet\\InventoryManegement\\InventoryManegement\\Data.json";
            Rice data = obj.Read(filePath);
            // Console.WriteLine(data);
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                Console.WriteLine("------------------------");
            }

            for (int i = 0; i < data.typeOfWheats.Count; i++)
            {
                Console.WriteLine(data.typeOfWheats[i].name);
                Console.WriteLine(data.typeOfWheats[i].weight);
                Console.WriteLine(data.typeOfWheats[i].price);
                Console.WriteLine("------------------------");
            }

            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(data.typeOfPulses[i].name);
                Console.WriteLine(data.typeOfPulses[i].weight);
                Console.WriteLine(data.typeOfPulses[i].price);
                Console.WriteLine("------------------------");
            }
        }
    }
}
