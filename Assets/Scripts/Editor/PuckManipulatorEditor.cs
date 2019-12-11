using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Puck))] // < нужный тип для работы инспектора
public class PuckManipulatorEditor : Editor
{
    //кастомные филды для работы 
    private Vector2 _origin = Vector2.up;
    private float _power = 500f;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        Puck puck = (Puck) target; // < Преобразование в нужный тип 

        if(GUILayout.Button("Add force to Puck"))
        {
            //действия при нажатии на кнопку...
            puck.Rb.AddForce(_origin * _power);
        }
    }
}
