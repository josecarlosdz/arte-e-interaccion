using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float topY = 5f;          
    public float bottomY = 0f;       
    public float speed = 2f;         
    private bool movingUp = true;    

    void Update()
    {
        
        if (movingUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime; 
            if (transform.position.y >= topY)
            {
                movingUp = false; 
            }
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime; 
            if (transform.position.y <= bottomY)
            {
                movingUp = true; 
            }
        }
    }
}
