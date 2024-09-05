
using System.Text.Json;
using System.Xml.Linq;
using TestFinalFirstWeek;
using TestFinalFirstWeek.Services;


public class Program
{
    public static object JsonConvert { get; private set; }
    public static object JsonFileReader { get; private set; }
    public static BinaryTree binaryTree = new BinaryTree();

    public static ServicToNode _servicToNode =new ServicToNode();
    public static ServicToTereats _servicToTereatsNode =new ServicToTereats();
    public static  async Task Main(string[] args)
    {

        List<Node> list= _servicToNode.LoeadJson();
        
        Console.WriteLine();
        binaryTree =  _servicToNode.InsertToTree(list);

        //binaryTree.PrintTree();


        List<ThreatsNode> listtereats = _servicToTereatsNode.LoeadJsonForTereats();

        _servicToTereatsNode.StartAtaack(listtereats, binaryTree);
        Console.ReadLine();
       


    }


}
