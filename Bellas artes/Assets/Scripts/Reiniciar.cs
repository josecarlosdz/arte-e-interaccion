using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelResetWithSpawnPoint : MonoBehaviour
{
    public Transform spawnPoint; // Define un punto de reaparición

    private void Start()
    {
        // Mueve el personaje al punto de reaparición al inicio
        MoveToSpawnPoint();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        MoveToSpawnPoint();
    }

    private void MoveToSpawnPoint()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null && spawnPoint != null)
        {
            player.transform.position = spawnPoint.position;
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero; // Resetea la velocidad para evitar efectos no deseados
            }
        }
    }
}
