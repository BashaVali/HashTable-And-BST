using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndTrees
{

    public class BST<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public BST<T> leftTree { get; set; }
        public BST<T> rightTree { get; set; }

        public BST(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T Value)
        {
            T CurrNodeVal = this.nodeData;    // Current Node Value Compares
            if ((CurrNodeVal.CompareTo(Value)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BST<T>(Value);
                }
                else
                {
                    this.leftTree.Insert(Value);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BST<T>(Value);
                }
                else
                {
                    this.rightTree.Insert(Value);
                }
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}
