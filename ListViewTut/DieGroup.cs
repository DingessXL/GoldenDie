using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewTut
{
    class DieGroup
    {
        //fields
        int diceSize;
        int[] results;
        //constructor
        public DieGroup(int size, int NumDice)
        {
            this.diceSize = size;
            this.results = new int[NumDice];

            Random r = new Random();

            for(int i = 0; i<NumDice; i++)
            {
                results[i] = r.Next(1, size + 1);
            }
        }
        //--------------------properties-------------------//
        public int DiceSize
        {
            //get & set
            get { return diceSize; }
            set
            {
                if (value > 1)
                    diceSize = value;
            }
        }
        public int DieCount => results.Length;
        //--------------------------------------------------//



        //-------------------methods------------------------//
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            if(results != null)
            {
                sb.Append("{");
                
                for (int pos = 0; pos<this.results.Length; pos++)
                {
                    if (pos == results.Length - 1)
                        sb.Append(results[pos]);
                    else
                        sb.Append(results[pos]+",");
                }
            sb.Append("}");
            }
            sb.Append("]");

            return sb.ToString();
        }

        public int AddRolls()
        {
            int sum = 0;
            foreach(var c in results)
                sum += c;
            return sum;
        }
        //-------------------------------------------------//
    }
}