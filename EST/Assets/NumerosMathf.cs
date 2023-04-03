using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosMathf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ABSOLUTO-------------------

        // Devuelve el valor absoluto de un n�mero.
        Mathf.Abs(-5); // retorna 5



        //REDONDEO-------------------

        // Redondea el n�mero al entero m�s cercano.
        Mathf.Round(2.345f); // retorna 2

        // Redondea hacia abajo al n�mero entero m�s cercano.
        Mathf.Floor(2.345f); // retorna 2

        // Redondea hacia arriba al n�mero entero m�s cercano.
        Mathf.Ceil(2.345f); // retorna 3



        //MIN-MAX-------------------

        // Devuelve el m�nimo entre dos n�meros.
        Mathf.Min(2, 5); // retorna 2

        // Devuelve el m�ximo entre dos n�meros.
        Mathf.Max(2, 5); // retorna 5

        // Con Arrays
        int[] arrayDeInts = new int[] { 5, 10, 3, 8, 2 };
        int min = Mathf.Min(arrayDeInts); // Retorna 2



        //MATEMATICAS-------------------

        // Devuelve el seno de un �ngulo en radianes.
        Mathf.Sin(Mathf.PI / 2); // retorna 1

        // Devuelve el coseno de un �ngulo en radianes.
        Mathf.Cos(Mathf.PI); // retorna -1

        // Devuelve la tangente de un �ngulo en radianes.
        Mathf.Tan(Mathf.PI / 4); // retorna 1

        // Devuelve el logaritmo de base 2 de un n�mero.
        Mathf.Log(16, 2); // retorna 4

        // Devuelve el resultado de elevar un n�mero a una potencia.
        Mathf.Pow(2, 3); // retorna 8

        // Devuelve la ra�z cuadrada de un n�mero.
        Mathf.Sqrt(25); // retorna 5



        //GRADOS-------------------

        // Convierte un �ngulo de radianes a grados.
        float radianes = Mathf.PI / 4;
        float grados = Mathf.Rad2Deg * radianes; // retorna 45 (grados)

        // Convierte un �ngulo de grados a radianes.
        float grados2 = 90;
        float radianes2 = Mathf.Deg2Rad * grados2; // retorna 1.5707964 (radianes)


    }

}
