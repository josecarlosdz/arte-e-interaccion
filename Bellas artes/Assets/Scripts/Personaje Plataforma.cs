using UnityEngine;

public class PlayerPlatformMovement : MonoBehaviour
{
    private Rigidbody2D rb; // Referencia al Rigidbody2D del personaje
    private Transform platform; // Referencia a la plataforma
    private Vector2 platformVelocity; // Velocidad de la plataforma

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el Rigidbody2D del personaje
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el personaje toca una plataforma (asegurándose de que la plataforma tiene el tag "Platform")
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = collision.transform; // Guardar la referencia de la plataforma
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Si está tocando la plataforma
        if (collision.gameObject.CompareTag("Platform"))
        {
            // Obtener la velocidad de la plataforma
            platformVelocity = platform.GetComponent<Rigidbody2D>().velocity;

            // Asegurarse de que el personaje se mueva con la plataforma
            rb.velocity = new Vector2(platformVelocity.x, rb.velocity.y); // Mantener la velocidad horizontal de la plataforma
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Cuando el personaje deja de tocar la plataforma, se desvincula de su movimiento
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = null; // Eliminar la referencia a la plataforma
        }
    }
}
