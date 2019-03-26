using System;

namespace Ordenamiento
{
    public class Burbuja    {
        public void Ordenar(int[] arr)
        {
            int t;
            for(int a = 1; a < arr.Length;a++) {
                for (int b = arr.Length-1;b>=a;b--) {
                if(arr[b-1] > arr[b]) {
                    t = arr[b-1];
                    arr[b-1] = arr[b];
                    arr[b] = t; 
                    }
                }
            }
            //throw new NotImplementedException("Crear los casos de prueba");
        }
    }
}