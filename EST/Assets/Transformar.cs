using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformar : MonoBehaviour
{
    [SerializeField] Transform objetivo;
    Transform objeto;
    // Start is called before the first frame update
    void Start()
    {
        string ruta = "misPrefabs/";
        //Transform padre = Instantiate(Resources.Load<GameObject>($"{ruta}P1")).transform;
        objeto = Instantiate(Resources.Load<GameObject>($"{ruta}P1")).transform;

        //Propiedades
        objeto.localScale = new Vector3(2, 2, 2);
        objeto.position = new Vector3(5, 5, 0);
        objeto.rotation = Quaternion.Euler(0f, 45f, 0f);
        //objeto.parent = padre;
    }

    // Update is called once per frame
    void Update()
    {
        //objeto.LookAt(objetivo);

        //objeto.Translate(Vector3.up * Time.deltaTime, Space.World);
        //objeto.Translate(Vector3.up * Time.deltaTime, Space.Self);
        //objeto.Translate(Vector3.up * 2f * Time.deltaTime, Space.World);
        //objeto.Translate(Vector3.up, Space.World);

        //objeto.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.World);
        //objeto.Translate(new Vector3(0, 10, 0) * Time.deltaTime, Space.World);

        //objeto.Translate(objetivo.position * Time.deltaTime);


        /* Parametros
            Vector3: Este es el parámetro más común para la función Translate. Este parámetro especifica el vector de traslación en el espacio tridimensional.

            float: Si se proporciona un solo valor, la función Translate traslada el objeto en el eje x por la cantidad especificada.

            float x, float y, float z: Es posible proporcionar tres valores de punto flotante para cada uno de los ejes x, y, z, lo que resulta en una traslación del objeto a lo largo de cada uno de los ejes.

            Vector3 direction: En lugar de proporcionar un vector de traslación, también se puede proporcionar una dirección como vector de dirección. Esto traslada el objeto a lo largo de la dirección especificada. Si la dirección no es normalizada, el objeto se trasladará a lo largo de un vector que tiene la misma dirección, pero cuya longitud es la misma que el vector de dirección proporcionado.

            Transform: Si se proporciona un objeto Transform como parámetro, el objeto actual se trasladará con respecto al objeto Transform especificado. El vector de traslación se calculará como la posición del objeto transformado menos la posición del objeto actual.

            Space: Este parámetro determina si el vector de traslación se debe interpretar en el espacio mundial o en el espacio local del objeto. Si se establece en Space.World, el vector de traslación se interpreta como una traslación en el espacio mundial. Si se establece en Space.Self, el vector de traslación se interpreta como una traslación en el espacio local del objeto. DEFAULT: SELF
        */


        //objeto.Rotate(new Vector3(0,1,0), 45, Space.World);
        //objeto.Rotate(Vector3.up, 45, Space.World);



        /*
            eulerAngles: Este parámetro te permite rotar el objeto a una posición determinada a lo largo de los tres ejes. El valor que se le pasa debe ser un Vector3 que indique los ángulos de rotación para cada eje. Por ejemplo, si quisieras rotar el objeto 45 grados hacia arriba, 0 grados hacia los lados y 0 grados hacia adelante, usarías el siguiente código: objeto.Rotate(new Vector3(45, 0, 0));.

            axis: Este parámetro te permite rotar el objeto alrededor de un eje específico. El valor que se le pasa debe ser un Vector3 que indique la dirección del eje de rotación. Por ejemplo, si quisieras rotar el objeto 45 grados alrededor del eje Y, usarías el siguiente código: objeto.Rotate(Vector3.up, 45);.

            angle: Este parámetro te permite rotar el objeto un ángulo determinado alrededor del eje que se le pase. El valor que se le pasa debe ser un float que indique el ángulo de rotación. Por ejemplo, si quisieras rotar el objeto 45 grados alrededor del eje X, usarías el siguiente código: objeto.Rotate(Vector3.right, 45);.

            relativeTo: Este parámetro te permite especificar el espacio de referencia para la rotación. Si se omite este parámetro, se asume que la rotación se realiza en el espacio del objeto. Los valores que acepta son:

            Space.Self: El objeto rota en su propio espacio local.
            Space.World: El objeto rota en el espacio global del juego.
         
         */
    }
}
