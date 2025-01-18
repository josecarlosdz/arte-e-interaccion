using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public string nombreEscena;
    public float tiempoEspera = 5f;

    void Start()
    {
        
        Invoke("CambiarEscena", tiempoEspera);
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
