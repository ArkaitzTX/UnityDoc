using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    //Collider---------------------------
    [SerializeField] GameObject objetoB;

    void Update()
    {
        //Collider en una gameObject EXTERNO
        Collider[] hitColliders = Physics.OverlapSphere(objetoB.transform.position, 2f);
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.tag != "Player") { 
                Debug.Log($"Impacta con: {hitCollider.gameObject.name}");
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
        Collider other: Este par�metro representa el collider del objeto con el que el objeto actual ha colisionado.

        gameObject.tag: Puedes utilizar gameObject.tag para comprobar la etiqueta del objeto con el que ha colisionado.

        Physics.IgnoreCollision: Puedes utilizar Physics.IgnoreCollision para evitar que dos objetos colisionen entre s�. Por ejemplo, si tienes un jugador y un objeto que no debe ser atravesado, puedes utilizar IgnoreCollision para evitar que el jugador atraviese el objeto.

        ContactPoint: Puedes utilizar ContactPoint para obtener informaci�n sobre el punto de contacto de la colisi�n. Por ejemplo, puedes obtener la posici�n y la normal del punto de contacto.
         */
    }

    //Ienumerator-----------------------

    void Start() {
        //StartCoroutine(Tiempo());
    }

    IEnumerator Tiempo() {
        yield return new WaitForSeconds(5f);
    }


    //Application-------------------------


    void OnApplicationQuit()
    {
        // Esta funci�n se ejecuta cuando la aplicaci�n se cierra
        Debug.Log("La aplicaci�n se ha cerrado.");
    }

    void OnApplicationPause(bool isPaused)
    {
        // Esta funci�n se ejecuta cuando la aplicaci�n entra o sale del estado pausado
        if (isPaused)
        {
            Debug.Log("La aplicaci�n se ha pausado.");
        }
        else
        {
            Debug.Log("La aplicaci�n ha vuelto a estar activa.");
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        // Esta funci�n se ejecuta cuando la aplicaci�n obtiene o pierde el foco
        if (hasFocus)
        {
            Debug.Log("La aplicaci�n ha obtenido el foco.");
        }
        else
        {
            Debug.Log("La aplicaci�n ha perdido el foco.");
        }
    }




}
