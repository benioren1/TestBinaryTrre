using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace TestFinalFirstWeek.Services
{
    public class ServicToNode
    {
        public static BinaryTree binaryTree = new BinaryTree();
        public List<Node> LoeadJson()
        {
            string filePath = @"C:\testTrre\TestFinalFirstWeek\defenceStrategiesBalanced.json";

            //להפוך את הקובץ גייסון לקריא על ידי הפיכתו לסטרינג
            string jsonString = File.ReadAllText(filePath);

            //הפיכתו של הסטרינג לרשימה של אובייקטים
            List<Node> trees = JsonSerializer.Deserialize<List<Node>>(jsonString);
            if (trees != null)
            {
                return trees;
            }
            else
            {
                return  new List<Node>();
            }
        }

        public BinaryTree InsertToTree(List<Node> list)
        {
            if (list != null)
                //הכנסה של כל האיברים מהרשימה לתוך עץ
                foreach (Node node in list)
                {
                    
                    binaryTree.Insert(node.MinSeverity, node.MaxSeverity, node.Defenses);
                }

            return binaryTree;


        }
    }
}
