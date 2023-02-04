using UnityEngine;

public class Teste : MonoBehaviour
{
    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;

    private void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;
        triangles = mesh.triangles;
    }

    public Vector3 GetRandomPointOnSurface()
    {
        int randomTriangleIndex = Random.Range(0, triangles.Length / 3);
        int vertexIndex = randomTriangleIndex * 3;
        Vector3 point1 = vertices[triangles[vertexIndex]];
        Vector3 point2 = vertices[triangles[vertexIndex + 1]];
        Vector3 point3 = vertices[triangles[vertexIndex + 2]];
        return transform.TransformPoint(RandomBarycentricCoordinates(point1, point2, point3));
    }

    private Vector3 RandomBarycentricCoordinates(Vector3 A, Vector3 B, Vector3 C)
    {
        float r = Random.value;
        float s = Random.value;
        if (r + s >= 1)
        {
            r = 1 - r;
            s = 1 - s;
        }
        float t = 1 - r - s;
        return A * r + B * s + C * t;
    }
}