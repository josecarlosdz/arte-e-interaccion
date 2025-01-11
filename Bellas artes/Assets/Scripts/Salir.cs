using UnityEngine;

public class GameExit : MonoBehaviour
{
    public void ExitGame()
    {
        // Esto cerrará el juego cuando esté compilado
        Application.Quit();
        
        // Esto es solo para probar en el Editor de Unity
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
