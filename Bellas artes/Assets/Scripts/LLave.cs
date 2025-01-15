using UnityEngine;

public class Key : MonoBehaviour
{
    public Door doorScript;  // Referencia al script de la puerta

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Verificar si el jugador tocó la llave (asumiendo que el tag del jugador es "Player")
        if (collider.CompareTag("Player"))
        {
            // Llamar a la función de la puerta para cambiar el sprite
            doorScript.OpenDoor(); 

            // Destruir la llave después de que el jugador la recoja
            Destroy(gameObject);
        }
    }
}
