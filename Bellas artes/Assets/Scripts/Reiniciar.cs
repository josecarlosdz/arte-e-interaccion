using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelResetWithSpawnPoint : MonoBehaviour
{
    public Transform spawnPoint; 

    private void Start()
    {
        
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
                rb.velocity = Vector2.zero; 
            }
        }
    }
}
