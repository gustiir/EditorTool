using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Circle : MonoBehaviour
{
    private LineRenderer lineRenderer;
   
        public int vertexCount = 4;
        public float lineWidth = 1f;
        public float radius = 1f;

    private void Awake()
    {

        lineRenderer = GetComponent<LineRenderer>();
        SetupCircle();
    }

    private void SetupCircle()
    {
        lineRenderer.widthMultiplier = lineWidth;
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 0f;

        lineRenderer.positionCount = vertexCount;
        for (int i = 0; i < lineRenderer.positionCount; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
            lineRenderer.SetPosition(i, pos);
            theta += deltaTheta;
        }
    }
}
