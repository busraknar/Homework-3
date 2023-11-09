using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //ctor tab yap = constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            T[] tempArray = items; //geçici diziye referans veriyoruz, elemanları tutuyoruz
            items = new T[items.Length+1]; //new'lediğimz için referans numarası sıfırlanıyor.
        
            for(int i=0; i< tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //sonuncu eleman eklenen eleman
        } 

        public int Length
        {
            get { return items.Length;  }
        }
    }
}
