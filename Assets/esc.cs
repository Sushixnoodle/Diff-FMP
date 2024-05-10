using UnityEngine;

public class esc : MonoBehaviour
{
    public string sceneName; // Name of the scene to load when Escape is pressed

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Load the specified scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}