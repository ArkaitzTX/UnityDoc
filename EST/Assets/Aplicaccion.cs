using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aplicaccion : MonoBehaviour
{
    void Start()
    {
        //APPLICATION-------------------

        // Obtener el nombre de la aplicaci�n
        string appName = Application.productName;
        Debug.Log("Nombre de la aplicaci�n: " + appName);

        // Obtener la versi�n de la aplicaci�n
        string appVersion = Application.version;
        Debug.Log("Versi�n de la aplicaci�n: " + appVersion);

        // Obtener la plataforma en la que se est� ejecutando la aplicaci�n
        RuntimePlatform platform = Application.platform;
        Debug.Log("Plataforma: " + platform.ToString());

        // Salir de la aplicaci�n
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //SCREEN----------------------

        // Obtener el ancho y alto de la pantalla en p�xeles
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;

        // Obtener la densidad de p�xeles (en p�xeles por pulgada) de la pantalla
        float screenDPI = Screen.dpi;

        // Obtener la orientaci�n actual de la pantalla (Portrait o Landscape)
        ScreenOrientation screenOrientation = Screen.orientation;

        // Cambiar la resoluci�n de la pantalla
        Screen.SetResolution(1920, 1080, true);

        // Habilitar o deshabilitar la pantalla completa
        Screen.fullScreen = false;

        // Obtener el n�mero de FPS de la pantalla
        int screenFPS = Screen.currentResolution.refreshRate;

        Application.targetFrameRate = 60; // Limitar a 60 fps
    }

    void Update()
    {
        // Obtener el tiempo en segundos desde que se inici� la aplicaci�n
        float timeSinceStartup = Time.timeSinceLevelLoad;
        //Debug.Log("Tiempo desde el inicio de la aplicaci�n: " + timeSinceStartup.ToString("F2") + " segundos");
    }

}
