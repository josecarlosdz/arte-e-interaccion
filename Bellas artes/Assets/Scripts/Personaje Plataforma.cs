using UnityEngine;

public class PlayerPlatformMovement : MonoBehaviour
{
    private Rigidbody2D rb; 
    private Transform platform; 
    private Vector2 platformVelocity; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = collision.transform; 
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Platform"))
        {
        
            platformVelocity = platform.GetComponent<Rigidbody2D>().velocity;

            
            rb.velocity = new Vector2(platformVelocity.x, rb.velocity.y); 
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = null; 
        }
    }
}
