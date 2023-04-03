using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosMathf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ABSOLUTO-------------------

        // Devuelve el valor absoluto de un número.
        Mathf.Abs(-5); // retorna 5



        //REDONDEO-------------------

        // Redondea el número al entero más cercano.
        Mathf.Round(2.345f); // retorna 2

        // Redondea hacia abajo al número entero más cercano.
        Mathf.Floor(2.345f); // retorna 2

        // Redondea hacia arriba al número entero más cercano.
        Mathf.Ceil(2.345f); // retorna 3



        //MIN-MAX-------------------

        // Devuelve el mínimo entre dos números.
        Mathf.Min(2, 5); // retorna 2

        // Devuelve el máximo entre dos números.
        Mathf.Max(2, 5); // retorna 5

        // Con Arrays
        int[] arrayDeInts = new int[] { 5, 10, 3, 8, 2 };
        int min = Mathf.Min(arrayDeInts); // Retorna 2



        //MATEMATICAS-------------------

        // Devuelve el seno de un ángulo en radianes.
        Mathf.Sin(Mathf.PI / 2); // retorna 1

        // Devuelve el coseno de un ángulo en radianes.
        Mathf.Cos(Mathf.PI); // retorna -1

        // Devuelve la tangente de un ángulo en radianes.
        Mathf.Tan(Mathf.PI / 4); // retorna 1

        // Devuelve el logaritmo de base 2 de un número.
        Mathf.Log(16, 2); // retorna 4

        // Devuelve el resultado de elevar un número a una potencia.
        Mathf.Pow(2, 3); // retorna 8

        // Devuelve la raíz cuadrada de un número.
        Mathf.Sqrt(25); // retorna 5



        //GRADOS-------------------

        // Convierte un ángulo de radianes a grados.
        float radianes = Mathf.PI / 4;
        float grados = Mathf.Rad2Deg * radianes; // retorna 45 (grados)

        // Convierte un ángulo de grados a radianes.
        float grados2 = 90;
        float radianes2 = Mathf.Deg2Rad * grados2; // retorna 1.5707964 (radianes)


    }

}
