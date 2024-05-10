using UnityEngine;
using UnityEngine.UI;

public class ShowPanelOnButtonPress : MonoBehaviour
{
    public GameObject panelToShow; // Reference to the panel you want to show

    private Button button;

    void Start()
    {
        // Get the button component attached to this GameObject
        button = GetComponent<Button>();

        // Add an event listener to the button
        button.onClick.AddListener(ShowPanel);
    }

    void ShowPanel()
    {
        // Check if the panel to show is assigned
        if (panelToShow != null)
        {
            // Set the panel to be active
            panelToShow.SetActive(true);
        }
        else
        {
            Debug.LogError("Panel to show is not assigned!");
        }
    }
}