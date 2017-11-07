using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
   public  class Aray
    {
        /*
        You can store multiple variables of the same type in an array data structure. 
        You declare an array by specifying the type of its elements.
        type[] arrayName;
        */
        int[] integrArr;
        public Aray()
        {
            integrArr = new int[] { 10,15,20,25,30};
        }
        public void ArrayIterator()
        {
            int dimension = integrArr.Rank; //Rank gets the dimension of the array .i.e 1 dimensional,2,3..and son on.
            if(dimension == 1)
            {
                int cnt = 0;
                foreach(int item in integrArr)
                {
                    Console.WriteLine("{0} Element of Array is {1}",cnt,item);
                    cnt += 1;
                }
            }
        }
    }
}
