using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollector : MonoBehaviour
{
    public int totalObjects; // Total number of objects to collect
    private int collectedObjects = 0; // Number of objects collected

    public string nextSceneName; // Name of the next scene to load

    // This method is called when an object is collected

    public int CollectedObjects
    {
        get { return collectedObjects; }
    }
    public void CollectObject()
    {
        collectedObjects++;
        if (collectedObjects >= totalObjects)
        {
            LoadNextScene();
        }
    }

    // Load the next scene
    private void LoadNextScene()
    {
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogWarning("Next scene name is not set.");
        }
    }
}