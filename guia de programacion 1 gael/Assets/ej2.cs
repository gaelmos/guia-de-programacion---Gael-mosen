using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
   int num1 = 4;
   int num2 = 5;
    int suma;
    int produ;

    // Start is called before the first frame update
    void Start()
    {
        suma = num1 + num2;
        Debug.Log("la suma es " + suma);
        produ = num1 * num2;
        Debug.Log("el preducto es " + produ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
