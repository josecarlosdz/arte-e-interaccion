using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 2f;                
    public Transform leftLimit;            
    public Transform rightLimit;           
    private bool movingRight = true;       

    void Update()
    {
        
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            
            if (transform.position.x >= rightLimit.position.x)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            
            if (transform.position.x <= leftLimit.position.x)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    
    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1; 
        transform.localScale = scale;
    }
}
