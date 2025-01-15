using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float topY = 5f;          // Altura máxima (posición Y)
    public float bottomY = 0f;       // Altura mínima (posición Y)
    public float speed = 2f;         // Velocidad de movimiento
    private bool movingUp = true;    // Dirección de movimiento (subir o bajar)

    void Update()
    {
        // Mover la plataforma hacia arriba o hacia abajo dependiendo de la dirección
        if (movingUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime; // Mover hacia arriba
            if (transform.position.y >= topY)
            {
                movingUp = false; // Cambiar la dirección a bajar cuando se alcanza la altura máxima
            }
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime; // Mover hacia abajo
            if (transform.position.y <= bottomY)
            {
                movingUp = true; // Cambiar la dirección a subir cuando se alcanza la altura mínima
            }
        }
    }
}
