using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WhileLoop
            /*WHILE - The while statement executes a statement or 
                a block of statements until a specified expression evaluates to false. */
            int variable = 0;
            while (variable != 10) // at variable = 10 this will fail and loop exits
            {
                Console.WriteLine("Testing while {0} time(s)", variable);
                variable += 1;
            }

            /*while with goto
            The goto statement transfers the program control directly to a labeled statement.
            A common use of goto is to transfer control to a specific
            switch-case label or the default label in a switch statement.
            The goto statement is also useful to get out of deeply nested loops.
            */
            int variable2 = 0;
            while (variable2 < 10)
            {
                Console.WriteLine("Testing while with goto {0} time(s)", variable2);
                if (variable2 == 5)
                    goto finish;
                variable2 += 1;
            }

        finish:
            Console.WriteLine("The code ended");
            #endregion

            #region Arrays
            Statements.Aray ob = new Aray();
            ob.ArrayIterator();
            #endregion

            Console.ReadKey();
        }
    }
}
