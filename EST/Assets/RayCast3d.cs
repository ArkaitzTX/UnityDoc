using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast3d : MonoBehaviour
{

    //!* OUT es para que los cambios en el parametro afecten a la variable *!//
    RaycastHit hitInfo;

    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;
        RaycastHit hit;
        float distanciaMaxima = 100.0f;
        LayerMask capas = LayerMask.GetMask("Default", "Enemigos");

        if (Physics.Raycast(origen, direccion, out hit, distanciaMaxima, capas))
        {

        }

        RaycastHit[] hits = Physics.RaycastAll(origen, direccion, distanciaMaxima, capas);

        foreach (RaycastHit h in hits)
        {
            // Hacer algo con cada intersección detectada
        }
    }
}

public class RaycastAllFromCamera : MonoBehaviour
{
    public Camera cam;
    public float maxDistance;
    public LayerMask layerMask;

    void Update()
    {
        for (int x = 0; x < Screen.width; x++)
        {
            for (int y = 0; y < Screen.height; y++)
            {
                Ray ray = cam.ScreenPointToRay(new Vector3(x, y, 0));
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, maxDistance, layerMask))
                {
                    // hacer algo con cada intersección detectada
                }
            }
        }
    }
}
