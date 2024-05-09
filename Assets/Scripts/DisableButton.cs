using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    private Button button;

    void Start()
    {
        // Get the button component attached to this GameObject
        button = GetComponent<Button>();

        // Add a listener to the button's onClick event
        button.onClick.AddListener(OnButtonClicked);
    }

    void OnButtonClicked()
    {
        // Disable the button
        button.interactable = false;
    }
}