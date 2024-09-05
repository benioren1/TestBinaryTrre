using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFinalFirstWeek.Services;

namespace TestFinalFirstWeek
{
    public class BinaryTree
    {
        public static ServicToTereats _servicToTereatsNode = new ServicToTereats();
        public  Node Root { get; set; }
       
        public BinaryTree()
        {
            Root = null;
        }

        //O(log)n)
        //הכנסה של איבר לעץ
        public void Insert(int min,int max,List<string> defense)
        {
            Root = Insert(min,max,defense, Root);
        }

        //O(log)n)
        //הכנסה של איבר לעץ
        private Node Insert(int min,int max,List<string> defense, Node node)
        {
            if (node == null)
            {
                return new Node(min, max,defense);
            }
            else
            {
                if (min <= node.MinSeverity)
                {
                    node.Left = Insert(min,max,defense, node.Left);
                }
                else
                {
                    node.Right = Insert(min, max,defense, node.Right);
                }
            }
            return node;
        }

        //O(log)n)
        //מציאת איבר בעץ בינארי
        public void Find(string name,int data)
        {
             FindRecursive(name,data, Root);
        }

        //O(log)n)
        //מציאת איבר בעץ בינארי
        private void FindRecursive(string name ,int data, Node node)
        {
            if (node == null)
            {
                _servicToTereatsNode.printstatus(null,null);
                Console.WriteLine();
                Thread.Sleep(2000);
                return;
            }
            
            if (data >= node.MinSeverity && data<= node.MaxSeverity)
            {
                _servicToTereatsNode.printstatus(node, name);
                return;
            }

            if (data < node.MinSeverity )
            {
                 FindRecursive(name,data, node.Left);
            }
            else
            {
                 FindRecursive(name,data, node.Right);
            }
        }

        //O(n)
        //הדפסת עץ בצורת 
        public void PrintTree()
        {
            Console.WriteLine($"Tree structor with left/right wrbg");
            Console.WriteLine();
            PrintTree(Root, "", true);
        }

          //O(n)
        //הדפסת עץ בצורת
        private void PrintTree(Node node, string st, bool isLast)
        {
            if (node == null)
                return;
           
            Console.Write(st);
            
            if (isLast)
            {
                Console.Write("└──right ");
                st += "    ";
            }
            else
            {
                Console.Write("├──left ");
                st += "│   ";
            }

            Console.WriteLine($"[{node.MinSeverity}-{node.MaxSeverity}] defense: {node.Defenses[0]},{node.Defenses[1]}");

            PrintTree(node.Left, st, false);
            PrintTree(node.Right, st, true);
        }


    }
}
