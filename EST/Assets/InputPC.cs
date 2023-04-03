using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPC : MonoBehaviour
{

    [SerializeField] Transform objeto, camara;
    [SerializeField] float velocidad = 10;
    // Update is called once per frame
    void Update()
    {
        //Axis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        objeto.Translate(new Vector3(h, 0, v) * velocidad * Time.deltaTime);

        //Key y Boton

        if (Input.GetButton("Jump"))
        {
            objeto.Translate(new Vector3(0, 1, 0) * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            objeto.Translate(new Vector3(0, -1, 0) * velocidad * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Pausa");
        }


        //Raton
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            float scroll = Input.GetAxis("Mouse ScrollWheel");


            camara.Translate(new Vector3(mouseX, mouseY, scroll) * velocidad * Time.deltaTime);

        }
    }
}
