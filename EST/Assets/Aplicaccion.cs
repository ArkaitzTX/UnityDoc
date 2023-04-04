using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aplicaccion : MonoBehaviour
{
    void Start()
    {
        //APPLICATION-------------------

        // Obtener el nombre de la aplicación
        string appName = Application.productName;
        Debug.Log("Nombre de la aplicación: " + appName);

        // Obtener la versión de la aplicación
        string appVersion = Application.version;
        Debug.Log("Versión de la aplicación: " + appVersion);

        // Obtener la plataforma en la que se está ejecutando la aplicación
        RuntimePlatform platform = Application.platform;
        Debug.Log("Plataforma: " + platform.ToString());

        // Salir de la aplicación
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //SCREEN----------------------

        // Obtener el ancho y alto de la pantalla en píxeles
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;

        // Obtener la densidad de píxeles (en píxeles por pulgada) de la pantalla
        float screenDPI = Screen.dpi;

        // Obtener la orientación actual de la pantalla (Portrait o Landscape)
        ScreenOrientation screenOrientation = Screen.orientation;

        // Cambiar la resolución de la pantalla
        Screen.SetResolution(1920, 1080, true);

        // Habilitar o deshabilitar la pantalla completa
        Screen.fullScreen = false;

        // Obtener el número de FPS de la pantalla
        int screenFPS = Screen.currentResolution.refreshRate;

        Application.targetFrameRate = 60; // Limitar a 60 fps
    }

    void Update()
    {
        // Obtener el tiempo en segundos desde que se inició la aplicación
        float timeSinceStartup = Time.timeSinceLevelLoad;
        //Debug.Log("Tiempo desde el inicio de la aplicación: " + timeSinceStartup.ToString("F2") + " segundos");
    }

}
