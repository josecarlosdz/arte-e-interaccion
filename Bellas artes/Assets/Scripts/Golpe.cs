using System.Collections;
using UnityEngine;

public class PlayerHitEffect : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; 
    private Color originalColor;           
    public Color hitColor = Color.red;     
    public float colorDuration = 0.5f;     

    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();

        
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            StartCoroutine(ChangeColorTemporarily());
        }
    }

    private IEnumerator ChangeColorTemporarily()
    {
        
        if (spriteRenderer != null)
        {
            spriteRenderer.color = hitColor;

            
            yield return new WaitForSeconds(colorDuration);


            spriteRenderer.color = originalColor;
        }
    }
}
