using UnityEngine;

public class ConstantMovingPlatform : MonoBehaviour
{
    public Transform pointA; 
    public Transform pointB; 
    public float speed = 3f; 

    private Transform target; 

    void Start()
    {
        
        target = pointB;
    }

    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }

    
    private void OnDrawGizmos()
    {
        if (pointA != null && pointB != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(pointA.position, pointB.position);
            Gizmos.DrawSphere(pointA.position, 0.2f);
            Gizmos.DrawSphere(pointB.position, 0.2f);
        }
    }
}
