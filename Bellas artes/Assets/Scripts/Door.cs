using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite openDoorSprite;  // Sprite de la puerta abierta
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Obtener el SpriteRenderer de la puerta
    }

    // Método que cambia el sprite de la puerta
    public void OpenDoor()
    {
        // Cambiar el sprite a la puerta abierta
        spriteRenderer.sprite = openDoorSprite;
    }
}
