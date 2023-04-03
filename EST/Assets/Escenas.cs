using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene(1);
        Debug.Log(SceneManager.GetActiveScene());
        SceneManager.UnloadSceneAsync(0);

        MiSingleton.Ejecutar();
    }
}
