using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{

    public Rigidbody rb;

    void Start()
    {
        string ruta = "misPrefabs/";

        Transform padre = Instantiate(Resources.Load<GameObject>($"{ruta}P1")).transform;
        GameObject hijo = Instantiate(Resources.Load<GameObject>($"{ruta}P2"), padre, true);
        hijo.AddComponent<Rigidbody>();

        Instantiate(Resources.Load<GameObject>($"{ruta}P2"));

    }

}
