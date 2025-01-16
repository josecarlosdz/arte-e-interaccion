using UnityEngine;

public class transform : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        
        animator.SetFloat("Speed", Mathf.Abs(move));

        
        if (move > 0)
            transform.localScale = new Vector3(1, 1, 1); 
        else if (move < 0)
            transform.localScale = new Vector3(-1, 1, 1); 

        
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
