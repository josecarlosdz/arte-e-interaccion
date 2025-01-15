using UnityEngine;

public class ConstantMovingPlatform : MonoBehaviour
{
    public Transform pointA; // Punto A (GameObject vacío)
    public Transform pointB; // Punto B (GameObject vacío)
    public float speed = 3f; // Velocidad constante

    private Transform target; // Punto objetivo actual

    void Start()
    {
        // Inicializa el objetivo en el punto A
        target = pointB;
    }

    void Update()
    {
        // Mueve la plataforma hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Cambia el objetivo cuando alcanza el punto actual
        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }

    // Dibuja las líneas en la escena para visualización
    private void OnDrawGizmos()
    {
        if (pointA != null && pointB != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(pointA.position, pointB.position);
            Gizmos.DrawSphere(pointA.position, 0.2f);
            Gizmos.DrawSphere(pointB.position, 0.2f);
        }
    }
}
