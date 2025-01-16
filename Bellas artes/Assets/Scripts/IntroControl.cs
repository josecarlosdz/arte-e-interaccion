using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public float introDuration = 10f; 

    void Start()
    {
        
        Invoke("nivel_1", introDuration);
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("nivel_1"); 
    }
}
