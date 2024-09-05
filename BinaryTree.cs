﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinalFirstWeek
{
    public class BinaryTree
    {
        public  Node Root { get; set; }
        //public string Sun { get; set; }

        public BinaryTree()
        {
            Root = null;
            //Sun = "";
        }

        public void Insert(int min,int max,List<string> defense)
        {
            Root = Insert(min,max,defense, Root);
        }

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

        //מציאת איבר בעץ בינארי
        public void Find(string name,int data)
        {
             FindRecursive(name,data, Root);
        }

        //מציאת איבר בעץ בינארי
        private void FindRecursive(string name ,int data, Node node)
        {
            if (node == null)
            {
                return;
            }
            
            if (data >= node.MinSeverity && data<= node.MaxSeverity)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Attck: {name}  [{node.MinSeverity}-{node.MaxSeverity}] defense: {node.Defenses[0]} ");
                Thread.Sleep(2000);
                Console.WriteLine($"Attck: {name}  [{node.MinSeverity}-{node.MaxSeverity}] defense: {node.Defenses[1]} ");
                Console.WriteLine();
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


        //הדפסת עץ בצורת 
        public void PrintTree()
        {
            Console.WriteLine($"Tree structor with left/right wrbg");
            Console.WriteLine();
            PrintTree(Root, "", true);
        }

        private void PrintTree(Node node, string st, bool isLast)
        {
            if (node == null)
                return;
           
            Console.Write(st);
            
            if (isLast)
            {
                Console.Write("└──right ");
                st += "   ";
            }
            else
            {
                Console.Write("├──left ");
                st += "│   ";
            }

            Console.WriteLine($"[{node.MinSeverity}-{node.MaxSeverity}] defense: ;sjkjvfadifpivpav");

            PrintTree(node.Left, st, false);
            PrintTree(node.Right, st, true);
        }


    }
}
