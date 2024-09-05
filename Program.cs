
using System.Text.Json;
using System.Xml.Linq;
using TestFinalFirstWeek;
using TestFinalFirstWeek.Services;


public class Program
{
    
    public static BinaryTree binaryTree = new BinaryTree();

    public static ServicToNode _servicToNode =new ServicToNode();
    public static ServicToTereats _servicToTereatsNode =new ServicToTereats();
    public static  async Task Main(string[] args)
    {
       
        Console.WriteLine();
        Console.WriteLine("loeading json to the list");
        Thread.Sleep(4000);
        List<Node> list= _servicToNode.LoeadJson();
        

        Console.WriteLine();
        Console.WriteLine("creating new tree");
        Thread.Sleep(4000);
        binaryTree =  _servicToNode.InsertToTree(list);

        Console.WriteLine();
        Console.WriteLine("printing all the tree");
        Thread.Sleep(4000);
        binaryTree.PrintTree();

        Console.WriteLine();
        Console.WriteLine("loeading json to the list");
        Thread.Sleep(4000);
        List<ThreatsNode> listtereats = _servicToTereatsNode.LoeadJsonForTereats();

        Console.WriteLine();
        Console.WriteLine("starting to attaking");
        Thread.Sleep(4000);
        _servicToTereatsNode.StartAtaack(listtereats, binaryTree);
        Console.ReadLine();
       


    }


}
