using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinalFirstWeek
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public string Name { get; set; }

        public BinaryTree()
        {
            Root = null;
            Name = "";
        }

        public void Insert(int data)
        {
            Root = Insert(data, Root);
        }

        private TreeNode1 Insert(int data, TreeNode1 node)
        {
            if (node == null)
            {
                return new TreeNode1(data);
            }
            else
            {
                if (data <= node.Data)
                {
                    node.Left = Insert(data, node.Left);
                }
                else
                {
                    node.Right = Insert(data, node.Right);
                }
            }
            return node;
        }

        public bool Find(int data)
        {
            return FindRecursive(data, Root);
        }

        private bool FindRecursive(int data, TreeNode1 node)
        {
            if (node == null)
            {
                return false;
            }

            if (data == node.Data)
            {
                return true;
            }

            if (data < node.Data)
            {
                return FindRecursive(data, node.Left);
            }
            else
            {
                return FindRecursive(data, node.Right);
            }
        }

        public int? FindMin()
        {
            TreeNode1 current = Root;
            if (current == null)
            {
                return null; // העץ ריק
            }

            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }

        public int? FindMax()
        {
            TreeNode1 current = Root;
            if (current == null)
            {
                return null; // העץ ריק
            }

            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Data;
        }

        public void Delete(int data)
        {
            Root = Delete(Root, data);
        }

        private TreeNode1 Delete(TreeNode1 root, int data)
        {
            if (root == null)
            {
                return null;
            }

            if (data < root.Data)
            {
                root.Left = Delete(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = Delete(root.Right, data);
            }
            else
            {
                // Node with only one child or no child
                if (root.Left == null)
                {
                    return root.Right;
                }
                if (root.Right == null)
                {
                    return root.Left;
                }

                // Node with two children
                int minValue = FindMinValue(root.Right);
                root.Data = minValue;
                root.Right = Delete(root.Right, minValue);
            }

            return root;
        }

        private int FindMinValue(TreeNode1 node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }

        public void PrintAll()
        {
            PrintAll(Root);
            Console.WriteLine();
        }

        private void PrintAll(TreeNode1 node)
        {
            if (node == null)
            {
                return;
            }

            PrintAll(node.Left);
            Console.Write(node.Data + " ");
            PrintAll(node.Right);
        }

        public void PrintTree()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            int height = GetHeight(Root);
            int width = (int)Math.Pow(2, height) - 1;
            char[,] treeMatrix = new char[height * 2 - 1, width * 2 - 1];

            // Initialize the matrix with spaces
            for (int i = 0; i < treeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < treeMatrix.GetLength(1); j++)
                {
                    treeMatrix[i, j] = ' ';
                }
            }

            FillTreeMatrix(Root, treeMatrix, 0, 0, width - 1, height);
            PrintMatrix(treeMatrix);
        }

        private void FillTreeMatrix(TreeNode1 root, char[,] treeMatrix, int v1, int v2, int v3, int height)
        {
            throw new NotImplementedException();
        }

        private int GetHeight(TreeNode1 root)
        {
            throw new NotImplementedException();
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        private void FillTreeMatrix(TreeNode node, char[,] matrix, int row, int left, int right, int height)
        {
            if (node == null) return;

            int mid = (left + right) / 2;
            matrix[row, mid * 2] = (char)(node.Data + '0');

            if (node.Left != null)
            {
                int newRow = row + 2;
                int newCol = mid * 2 - 1;
                DrawConnection(matrix, row + 1, mid * 2, newRow, newCol);
                FillTreeMatrix(node.Left, matrix, newRow, left, mid - 1, height);
            }

            if (node.Right != null)
            {
                int newRow = row + 2;
                int newCol = mid * 2 + 1;
                DrawConnection(matrix, row + 1, mid * 2, newRow, newCol);
                FillTreeMatrix(node.Right, matrix, newRow, mid + 1, right, height);
            }
        }

        private void DrawConnection(char[,] matrix, int startRow, int startCol, int endRow, int endCol)
        {
            int row = startRow;
            int col = startCol;
            while (row < endRow && col > endCol)
            {
                matrix[row++, col--] = '/';
            }
            while (row < endRow && col < endCol)
            {
                matrix[row++, col++] = '\\';
            }
        }

        private void PrintMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
