using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---------------------
using PruebaClases.m1;

public class Namespace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal miAnimal1 = new Perro();
        miAnimal1.HacerSonido();

        AnimalAbs miAnimal2 = new GatoAbs();
        miAnimal2.HacerSonido();

        miObjeto obj = new miObjeto(1, 2);
        Debug.Log(obj.MiResultado());

        Debug.Log("Hola".Invertir());
    }

}
