using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Guardar : MonoBehaviour
{
    [SerializeField] Transform objeto;
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        objeto.position = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("pos"));
    }

    private void OnApplicationQuit()
    {
        string JsonVec = JsonUtility.ToJson(objeto.position);

        //Prefs
        PlayerPrefs.SetString("pos", JsonVec);

        //File
        string nombre = Application.persistentDataPath + "/posicion.json";
        File.WriteAllText(nombre, JsonVec);

        // Verificar si el archivo existe
        if (File.Exists(nombre))
        {
            string contenido = File.ReadAllText(nombre);
            Debug.Log($"Archivo creado correctamente:\n {contenido} \n El nombre:\n {nombre}");
        }
        else
        {
            Debug.Log("Error al crear el archivo.");
        }
    }

}
