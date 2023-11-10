using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8_dz1
{
    class indexator
    {
        private int[] data;

        public indexator(int size)
        {
            data = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < data.Length)
                {
                    // Возвращаем текущее значение элемента массива
                    return data[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < data.Length)
                {
                    // Возводим передаваемое значение в квадрат и устанавливаем его
                    data[index] = value * value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
