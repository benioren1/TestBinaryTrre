using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinalFirstWeek
{
    public class Node
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }

        public List<string> Defenses { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int minSeverity, int maxSeverity)
        {

            this.MinSeverity = minSeverity; 
            this.MaxSeverity = maxSeverity;
            Left = null;
            Right = null;

        }
    }
}
///public void PrintTree()
//{
//    PrintTree(Root, "", true);
//}

//private void PrintTree(TreeNode node, string indent, bool isLast)
//{
//    if (node == null)
//        return;

//    Console.Write(indent);

//    if (isLast)
//    {
//        Console.Write("└── ");
//        indent += "    ";
//    }
//    else
//    {
//        Console.Write("├── ");
//        indent += "│   ";
//    }

//    Console.WriteLine(node.Data);

//    PrintTree(node.Left, indent, false);
//    PrintTree(node.Right, indent, true);
//}
