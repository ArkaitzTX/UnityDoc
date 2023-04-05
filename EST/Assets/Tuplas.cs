using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuplas : MonoBehaviour
{
    void Start()
    {
        var lista1 = new List<(string nombre, int edad)>() {
            ("manolo", 10),
            ("pepe", 20),
            ("maría", 30)
        };
        Debug.Log(lista1[0].Item1);

        var (cadena, numero) = lista1[0];
        Debug.Log(numero);

        var tupla = (nombre: "manolo", edad: 12);
        Debug.Log(tupla);
    }
}
