using System.Collections;
using UnityEngine;

public class PlayerHitEffect : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; // Referencia al SpriteRenderer (para juegos 2D)
    private Color originalColor;           // Color original del personaje
    public Color hitColor = Color.red;     // Color al ser golpeado
    public float colorDuration = 0.5f;     // Duración del efecto de cambio de color

    void Start()
    {
        // Obtener el componente SpriteRenderer (para juegos 2D)
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Guardar el color original del personaje
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el personaje colisionó con un objeto con el tag "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Iniciar el cambio de color temporal
            StartCoroutine(ChangeColorTemporarily());
        }
    }

    private IEnumerator ChangeColorTemporarily()
    {
        // Cambiar al color rojo al ser golpeado
        if (spriteRenderer != null)
        {
            spriteRenderer.color = hitColor;

            // Esperar el tiempo especificado
            yield return new WaitForSeconds(colorDuration);

            // Restaurar el color original
            spriteRenderer.color = originalColor;
        }
    }
}
