using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema3 : Interactable
{
    public static int[] arreglo = new int[] {-2,1,-3,4,-3,1};
    public static List<int> nums = new List<int>();
     private static int max_so_far = 0, max_ending_here = 0, inicio = 0, fin = 0, s = 0;
    void Start()
    {

    }

    protected override void Interact()
    {
        base.Interact();
        for (int i = 0; i < arreglo.Length; i++)
        {
            max_ending_here += arreglo[i];
            if (max_so_far < max_ending_here)
            {
                max_so_far = max_ending_here;
                inicio = s;
                fin = i;
            }
            if (max_ending_here < 0)
            {
                max_ending_here = 0;
                s = i + 1;
            }
        }
            for(int i = s; i<=fin;i++)
            {
                nums.Add(arreglo[i]);
            }
            Debug.Log("suma es " + max_so_far);
            Debug.Log("Numeros: ");
            foreach(int numero in nums)
            {
                Debug.Log(numero +" ");
            }
    }
}
