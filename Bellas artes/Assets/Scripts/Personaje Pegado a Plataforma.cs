using UnityEngine;

public class PersonajeEnPlataforma : MonoBehaviour
{
    private Transform plataformaActual; 
    private Vector3 ultimaPosicionPlataforma; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            plataformaActual = collision.transform; 
            ultimaPosicionPlataforma = plataformaActual.position; 
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            plataformaActual = null; 
        }
    }

    void Update()
    {
        
        if (plataformaActual != null)
        {
            
            Vector3 desplazamiento = plataformaActual.position - ultimaPosicionPlataforma;

            
            transform.position += desplazamiento;

            
            ultimaPosicionPlataforma = plataformaActual.position;
        }
    }
}
