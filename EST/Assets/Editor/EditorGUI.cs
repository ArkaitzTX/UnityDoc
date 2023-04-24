using UnityEngine;
using UnityEditor;

public class EditorGUI : EditorWindow
{
    private GameObject selectedObject;

    [MenuItem("Window/Custom Editor")]
    public static void ShowWindow()
    {
        GetWindow(typeof(EditorGUI));
    }

    private void OnGUI()
    {
        GUILayout.Label("Custom Editor", EditorStyles.boldLabel);

        selectedObject = (GameObject)EditorGUILayout.ObjectField("Selected Object", selectedObject, typeof(GameObject), true);

        if (selectedObject != null)
        {
            GUILayout.Label("Name: " + selectedObject.name);
            GUILayout.Label("Position: " + selectedObject.transform.position.ToString());
            GUILayout.Label("Rotation: " + selectedObject.transform.rotation.eulerAngles.ToString());
            GUILayout.Label("Scale: " + selectedObject.transform.localScale.ToString());
        }
    }
}
