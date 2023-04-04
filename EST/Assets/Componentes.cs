using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes : MonoBehaviour
{

    Rigidbody rb;
    Material mat;
    Collider[] col;

    void Start()
    {
        //-----------------Component

        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject player = GameObject.Find("Objeto2 Comp");
        Debug.Log(player.name);

        rb = player.GetComponent<Rigidbody>();
        mat = player.GetComponent<Renderer>().material;
        col = player.GetComponents<Collider>();

        //GetComponentInChildren<T>() -> El primer componente del hijo

        //FindObjectOfType<T>() -> El primer objeto de la escena con el componente T
        //FindObjectsOfType<T>() -> Todos los objetos que tengan ese tipo de componente

        rb.useGravity = false;
        foreach (Collider c in col) {
            c.enabled = false;
        }

        //-------------gameObject

        gameObject.SetActive(true);

        //Debug.Log(gameObject.tag);

        gameObject.name = "prueba";

        gameObject.AddComponent<BoxCollider>();

        gameObject.SendMessage("Futuro");

            /*
                Funciones:

            GetComponent<T>(): obtiene un componente del tipo especificado en el objeto GameObject actual.
            AddComponent<T>(): agrega un componente del tipo especificado al objeto GameObject actual.
            SetActive(bool active): activa o desactiva el objeto GameObject actual.
            SendMessage(string methodName, object value = null): llama a un método con el nombre especificado en todos los componentes del objeto GameObject actual.
            BroadcastMessage(string methodName, object value = null): llama a un método con el nombre especificado en todos los componentes del objeto GameObject actual y en todos sus hijos.

                Propiedades:

            transform: la transformación del objeto GameObject, que incluye su posición, rotación y escala.
            name: el nombre del objeto GameObject.
            tag: el tag del objeto GameObject.
            layer: la capa del objeto GameObject.
            activeSelf: devuelve un valor booleano que indica si el objeto GameObject actual está activo en la escena.
            activeInHierarchy: devuelve un valor booleano que indica si el objeto GameObject actual está activo en la escena y es un descendiente de un objeto activo.
            */

        //--------------Otros

        //Destroy(player);
        //Invoke("Futuro", 2f);
        //InvokeRepeating("Futuro", 0f, 5f);

    }

    public void Futuro() {
        Debug.Log("Funciona!");
    }
}
