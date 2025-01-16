using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite openDoorSprite;  
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    
    public void OpenDoor()
    {
        
        spriteRenderer.sprite = openDoorSprite;
    }
}
