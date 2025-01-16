using UnityEngine;

public class Key : MonoBehaviour
{
    public Door doorScript;  

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.CompareTag("Player"))
        {
            
            doorScript.OpenDoor(); 

            
            Destroy(gameObject);
        }
    }
}
