using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewoBinarne
{
    class BinaryTree<TItem> where TItem : IComparable<TItem>
    {
        // int countLeftItem;
        private int count;
        //   string len;

        public BinaryTree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
            count = 1;
            // countLeftItem = 1;
            // len = "   ";
        }

        public TItem NodeData { get; set; }

        public BinaryTree<TItem> LeftTree { get; set; }

        public BinaryTree<TItem> RightTree { get; set; }

        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            this.count++;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                //  countLeftItem++;
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinaryTree<TItem>(newItem);

                }
                else
                {

                    this.LeftTree.Insert(newItem);

                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinaryTree<TItem>(newItem);

                }
                else
                {

                    this.RightTree.Insert(newItem);
                }
            }
        }

        #region przechodznie drzewa
        /*
         
           1. Odwiedzamy węzeł c ("odwiedzenie" może polegać na wydrukowaniu wartości węzła, dopisaniu węzła do tablicy ArrayList lub na wykonaniu innych czynności, zależnych od tego, w jakim celu wykonywane jest przejście drzewa).
           2. Wykonujemy algorytm dla lewego dziecka węzła c.
           3. Wykonujemy algorytm dla prawego dziecka węzła c.
         */

        public void WalkTreePreOrder()
        {
            Console.Write(this.NodeData.ToString() + ",");

            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTreePreOrder();

            }

            if (this.RightTree != null)
            {
                this.RightTree.WalkTreePreOrder();

            }
        }

        /*        
          1. Wykonujemy algorytm dla lewego dziecka węzła c.
          2. Odwiedzamy węzeł c ("odwiedzenie" może polegać na wydrukowaniu wartości węzła, dopisaniu węzła do tablicy ArrayList, lub na wykonaniu innych czynności, zależnych od tego, w jakim celu wykonywane jest przejście drzewa).
          3. Wykonujemy algorytm dla prawego dziecka węzła c.
         */

        public void WalkTreeInOrder()
        {


            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTreeInOrder();

            }
            Console.Write(this.NodeData.ToString() + ",");

            if (this.RightTree != null)
            {
                this.RightTree.WalkTreeInOrder();

            }
        }

        /*        
            1. Wykonujemy algorytm dla lewego dziecka węzła c.
            2. Wykonujemy algorytm dla prawego dziecka węzła c.
            3. Odwiedzamy węzeł c ("odwiedzenie" może polegać na wydrukowaniu wartości węzła, dopisaniu węzła do tablicy ArrayList, lub na wykonaniu innych czynności, zależnych od tego, w jakim celu wykonywane jest przejście drzewa).
         */

        public void WalkTreePostOrder()
        {


            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTreePostOrder();

            }


            if (this.RightTree != null)
            {
                this.RightTree.WalkTreePostOrder();

            }

            Console.Write(this.NodeData.ToString() + ",");
        }

        public string WalkTree(StringBuilder sb, bool NewLineMode)
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTree(sb, NewLineMode);
            }

            if (NewLineMode == false)
                sb.Append(string.Format("{0} , ", this.NodeData.ToString()));
            else sb.AppendLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.RightTree.WalkTree(sb, NewLineMode);
            }
            return sb.ToString();
        }

        #endregion


        public void Search(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            
            if (currentNodeValue == null)
            {
                Console.WriteLine(" element nie znaleziony" + currentNodeValue.ToString());
                return;
            }
            else
            {
                int result = currentNodeValue.CompareTo(newItem);
                if (result == 0)
                {
                    // wartości równe — węzeł został znaleziony
                    // return currentNodeValue;
                    Console.WriteLine("znaleziony element" + currentNodeValue.ToString());
                }

                else if (result > 0)
                {
                    // current.Value > n.Value
                    // a więc poszukiwana wartość może znajdować się
                    // w lewym poddrzewie bieżącego węzła (zmienna current)
                    // return Search(this.currentNodeValue.Left, newItem);
                    this.LeftTree.Search(newItem);

                }
                else if (result < 0)
                {
                    // current.Value < n.Value
                    // a więc poszukiwana wartość może znajdować się
                    // w prawym poddrzewie bieżącego węzła (zmienna current)
                    this.RightTree.Search(newItem);
                }
            }
       

              //  return default(TItem);
            
        }

    }
}
