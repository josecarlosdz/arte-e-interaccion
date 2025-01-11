using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 2f;                // Velocidad de movimiento
    public Transform leftLimit;            // Límite izquierdo
    public Transform rightLimit;           // Límite derecho
    private bool movingRight = true;       // Indica si se está moviendo a la derecha

    void Update()
    {
        // Mover el personaje en la dirección actual
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            // Cambiar dirección si alcanza el límite derecho
            if (transform.position.x >= rightLimit.position.x)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            // Cambiar dirección si alcanza el límite izquierdo
            if (transform.position.x <= leftLimit.position.x)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    // Voltear el sprite del personaje
    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1; // Invertir la escala en X para voltear el sprite
        transform.localScale = scale;
    }
}
