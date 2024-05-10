using UnityEngine;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    // Assign this method to your quit button's onClick event in the Unity Editor
    public void Quit()
    {
        Debug.Log("Quitting application...");
        Application.Quit();
    }
}