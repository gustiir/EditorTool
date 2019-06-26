using UnityEngine;
using UnityEditor;

public class CircleWindow : EditorWindow
{
    public Circle circle;

    Component lineRenderer;

    [MenuItem("Window/CircleWindow")]
    public static void ShowWindow()
    {
        GetWindow<CircleWindow>("CircleWindow");
    }

    void OnGUI()
    {
        lineRenderer = (Component)EditorGUILayout.ObjectField(lineRenderer, typeof(LineRenderer), true);
        circle = lineRenderer.GetComponent<Circle>();

        GUILayout.Label("Sides");
        circle.vertexCount = (int)EditorGUILayout.Slider(circle.vertexCount, 0, 360);

        GUILayout.Label("Radius");
        circle.radius = (float)EditorGUILayout.Slider(circle.radius, 0, 50);
    }
}