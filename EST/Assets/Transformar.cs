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
            Vector3: Este es el par�metro m�s com�n para la funci�n Translate. Este par�metro especifica el vector de traslaci�n en el espacio tridimensional.

            float: Si se proporciona un solo valor, la funci�n Translate traslada el objeto en el eje x por la cantidad especificada.

            float x, float y, float z: Es posible proporcionar tres valores de punto flotante para cada uno de los ejes x, y, z, lo que resulta en una traslaci�n del objeto a lo largo de cada uno de los ejes.

            Vector3 direction: En lugar de proporcionar un vector de traslaci�n, tambi�n se puede proporcionar una direcci�n como vector de direcci�n. Esto traslada el objeto a lo largo de la direcci�n especificada. Si la direcci�n no es normalizada, el objeto se trasladar� a lo largo de un vector que tiene la misma direcci�n, pero cuya longitud es la misma que el vector de direcci�n proporcionado.

            Transform: Si se proporciona un objeto Transform como par�metro, el objeto actual se trasladar� con respecto al objeto Transform especificado. El vector de traslaci�n se calcular� como la posici�n del objeto transformado menos la posici�n del objeto actual.

            Space: Este par�metro determina si el vector de traslaci�n se debe interpretar en el espacio mundial o en el espacio local del objeto. Si se establece en Space.World, el vector de traslaci�n se interpreta como una traslaci�n en el espacio mundial. Si se establece en Space.Self, el vector de traslaci�n se interpreta como una traslaci�n en el espacio local del objeto. DEFAULT: SELF
        */


        //objeto.Rotate(new Vector3(0,1,0), 45, Space.World);
        //objeto.Rotate(Vector3.up, 45, Space.World);



        /*
            eulerAngles: Este par�metro te permite rotar el objeto a una posici�n determinada a lo largo de los tres ejes. El valor que se le pasa debe ser un Vector3 que indique los �ngulos de rotaci�n para cada eje. Por ejemplo, si quisieras rotar el objeto 45 grados hacia arriba, 0 grados hacia los lados y 0 grados hacia adelante, usar�as el siguiente c�digo: objeto.Rotate(new Vector3(45, 0, 0));.

            axis: Este par�metro te permite rotar el objeto alrededor de un eje espec�fico. El valor que se le pasa debe ser un Vector3 que indique la direcci�n del eje de rotaci�n. Por ejemplo, si quisieras rotar el objeto 45 grados alrededor del eje Y, usar�as el siguiente c�digo: objeto.Rotate(Vector3.up, 45);.

            angle: Este par�metro te permite rotar el objeto un �ngulo determinado alrededor del eje que se le pase. El valor que se le pasa debe ser un float que indique el �ngulo de rotaci�n. Por ejemplo, si quisieras rotar el objeto 45 grados alrededor del eje X, usar�as el siguiente c�digo: objeto.Rotate(Vector3.right, 45);.

            relativeTo: Este par�metro te permite especificar el espacio de referencia para la rotaci�n. Si se omite este par�metro, se asume que la rotaci�n se realiza en el espacio del objeto. Los valores que acepta son:

            Space.Self: El objeto rota en su propio espacio local.
            Space.World: El objeto rota en el espacio global del juego.
         
         */
    }
}
