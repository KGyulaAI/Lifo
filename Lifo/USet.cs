using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifo
{
    internal class USet
    {
        string[] array;
        int length = 0;

        public USet()
        {
            array = new string[50];
        }

        public USet(int capacity)
        {
            array = new string[capacity];
        }

        public void Push(string name)
        {
            if (length == array.Length)
            {
                throw new Exception("Betelt");
            }
            for (int i = 0; i < length; i++)
            {
                if (array[i] == name)
                {
                    return;
                }
            }
            array[length++] = name;
        }

        public void Remove(string name)
        {
            if (length == 0)
            {
                throw new Exception("Üres halmaz!");
            }

            for (int i = 0; i < length; i++)
            {
                if (array[i] == name)
                {
                    array[i] = array[length];
                    return;
                }
            }
            throw new Exception($"A {name} érték nem szerepel a halmazban!");
        }

        public void Clear()
        {
            length = 0;
        }

        public override string? ToString()
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += array[i] + ";";
            }
            return result;
        }

        public int Length => length;
        public int Capacity => array.Length;
    }
}
