using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{

    public List<List<int>> lista = new List<List<int>>();
    public int[,] array = {
        { 1, 2, 3, 4, 5},
        { 5, 4, 3, 2, 1}
    };
    public Dictionary<string, int> diccionarioL = new Dictionary<string, int>();
    public (string, int, bool)[] diccionarioA = { ("Arkaitz", 0, false) };


    void Start()
    {
        //Datos
        bool cambio = false;
        for (int i = 0; 2 > i; i++){
            lista.Add(new List<int>());
            for (int a = 1; 5 >= a; a++) {
                lista[i].Add((cambio) 
                    ? 6 - a
                    : a
                );
            }
            cambio = !cambio;
        }

        diccionarioL.Add("Arkaitz", 0);

        //Imprimir
        foreach (List<int> coleccion in lista)
        {
            string valor = "";
            foreach (int elemento in coleccion)
            {
                valor += elemento + " |";
            }
            Debug.Log(valor);
        }
        Debug.Log("*---*");
        for (int i = 0; array.GetLength(0) > i; i++)
        {
            string valor = "";
            for (int a = 0; array.GetLength(1) > a; a++)
            {
                valor += array[i, a] + " |";
            }
            Debug.Log(valor);
        }
        Debug.Log("*---*");
        Debug.Log(diccionarioL["Arkaitz"]);
        Debug.Log("*---*");
        Debug.Log(diccionarioA[0].Item1 + "->" + diccionarioA[0].Item2.ToString() + "->" + diccionarioA[0].Item3);
    }

}
