using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_ClassGeneric
{
    //T là kiểu dữ liệu
    internal class NTQ<T>
    {
        private T temp;

        public NTQ()
        {
        }

        public NTQ(T temp)
        {
            this.temp = temp;
        }

        public T Temp
        {
            get => temp;
            set => temp = value;
        }

        public T GetValueTemp()
        {
            Console.WriteLine(temp);
            return temp;
        }

    }
}
