using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FieldGenerator))]
public class FieldGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        FieldGenerator generator = (FieldGenerator) target;

        if(GUILayout.Button("Create field!"))
        {
            generator.GenerateField();
        }

        if (GUILayout.Button("Clear field!"))
        {
            generator.ClearField();
        }
    }
}
