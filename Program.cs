
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
        //קריאה לגייסון של אסטרטגיית הגנות
        //שמירת הנתיב של הגייסון
        string filePath = @"C:\testTrre\TestFinalFirstWeek\defenceStrategiesBalanced.json";

        //להפוך את הקובץ גייסון לקריא על ידי הפיכתו לסטרינג
        string jsonString = File.ReadAllText(filePath);

        //הפיכתו של הסטרינג לרשימה של אובייקטים
        List<Node> trees = JsonSerializer.Deserialize<List<Node>>(jsonString);

        Console.WriteLine();

        if (trees != null)
           //הכנסה של כל האיברים מהרשימה לתוך עץ
        foreach (Node node in trees)
            {
                

                binaryTree.Insert(node.MinSeverity,node.MaxSeverity,node.Defenses);

            }
        //עד כאן הגנה

        //עכשיו אני יקרא את הגייסון של החומרה
        string filePath2 = @"C:\testTrre\TestFinalFirstWeek\tereats.json";

        //להפוך את הקובץ גייסון לקריא על ידי הפיכתו לסטרינג
        string jsonString2 = File.ReadAllText(filePath2);

        //הפיכתו של הסטרינג לרשימה של אובייקטים
        List<Node> trees = JsonSerializer.Deserialize<List<Node>>(jsonString);


    }


}
