using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;         
    public float jumpForce = 10f;   
    private Rigidbody2D rb;         

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float move = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            move = -1f; 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1f; 
        }

        
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

