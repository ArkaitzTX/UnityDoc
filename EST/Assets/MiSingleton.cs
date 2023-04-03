using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiSingleton : MonoBehaviour
{
    public static MiSingleton objeto;

    private void Awake()
    {
        if (objeto == null)
        {
            objeto = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Ejecutar() {
        Debug.Log("SI");
    }

}
