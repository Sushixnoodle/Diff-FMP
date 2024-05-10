using UnityEngine;
using UnityEngine.UI;

public class CutScenes : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public string nextSceneName; // Name of the next scene

    private int buttonPressCount = 0;

    public void OnButtonPress()
    {
        buttonPressCount++;

        if (buttonPressCount == 1)
        {
            image1.enabled = false;
        }
        else if (buttonPressCount == 2)
        {
            image2.enabled = false;
        }
        else if (buttonPressCount == 3)
        {
            // Load next scene
            if (!string.IsNullOrEmpty(nextSceneName))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}