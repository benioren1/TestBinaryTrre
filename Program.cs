
using System.Text.Json;
using System.Xml.Linq;
using TestFinalFirstWeek;

public class Program
{
    public static object JsonConvert { get; private set; }
    public static object JsonFileReader { get; private set; }
    public static BinaryTree binaryTree = new BinaryTree();

    public static void Main(string[] args)
    {
        string filePath = @"C:\testTrre\TestFinalFirstWeek\defenceStrategiesBalanced.json";


        string jsonString = File.ReadAllText(filePath);


        List<Node> trees = JsonSerializer.Deserialize<List<Node>>(jsonString);

        Console.WriteLine();

        if (trees != null)
           
        foreach (Node node in trees)
            {
                

                binaryTree.Insert(node.MinSeverity,node.MaxSeverity,node.Defenses);

            }
        
    }


}
