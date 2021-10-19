using System;

namespace Find_Min_Value_in_BST
{
    //Find the min value ina bst
    // recursively find the 
    class Program
    {
      

        static void Main(string[] args)
        {
            BST bst = new BST();
                               
            bst.Insert(24);
            bst.Insert(21);
            bst.Insert(26);
            bst.Insert(22); 
            bst.Insert(20);
            bst.Insert(23);
            bst.Insert(27);
            bst.Insert(25);

            bst.MinValue(bst.Root);
        }
        public class BST
        {

            

            public void Insert(int key)
            {
                Root =  InsertRec(Root, key);

            }

            private Node InsertRec(Node root, int key)
            {
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }
                else
                {
                    if (key < root.Value)
                    {
                        root.Left = InsertRec(root.Left, key);
                    }
                    else
                    {
                        root.Right = InsertRec(root.Right, key);
                    }
                }

                
                return root;


            }


            public int MinValue(Node root)
            {
                Node Current = root;
                while (Current.Left != null)
                {
                    Current = Current.Left;
                }

                return Current.Value;
            }

            public class Node
            {
                public int Value;
                public Node Right;
                public Node Left;
                public Node(int item)
                {
                    Value = item;
                    Right = Left = null;
                }

            }
            public Node Root;
            public BST()
            {
                Root = null;
            }
        }
    }
}
