using System;
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

        internal void Insert(object min)
        {
            throw new NotImplementedException();
        }
    }
}
