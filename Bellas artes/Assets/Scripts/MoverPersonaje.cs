using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;         // Velocidad de movimiento horizontal
    public float jumpForce = 10f;   // Fuerza del salto
    private Rigidbody2D rb;         // Componente Rigidbody2D del personaje

    void Start()
    {
        // Obtener el Rigidbody2D del personaje
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal con A y D
        float move = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            move = -1f; // Mover a la izquierda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1f; // Mover a la derecha
        }

        // Aplicar movimiento horizontal manteniendo la velocidad vertical
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        // Salto con W
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
