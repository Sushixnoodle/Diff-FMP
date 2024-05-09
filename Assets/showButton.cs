using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour
{
    public Button firstButton; // Reference to the first button
    public Button secondButton; // Reference to the second button

    void Start()
    {
        // Disable the second button at the start
        secondButton.gameObject.SetActive(false);

        // Add a listener to the onClick event of the first button
        firstButton.onClick.AddListener(OnFirstButtonClicked);
    }

    void OnFirstButtonClicked()
    {
        // Show the second button
        secondButton.gameObject.SetActive(true);
    }
}