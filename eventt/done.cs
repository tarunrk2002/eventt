using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventt
{
    internal class done
    {
        public delegate void  abcEventHandler(object sender, EventArgs e);
        public event abcEventHandler abc;


       public void asd()
        {
            Console.WriteLine("donee");
            Onabc();

        }



        protected virtual void Onabc()
        {
            if (abc != null)
            {
                abc(this, EventArgs.Empty);

            }
        }
    }
}
