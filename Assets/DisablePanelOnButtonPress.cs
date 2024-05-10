using UnityEngine;
using UnityEngine.UI;

public class DisablePanelOnButtonPress : MonoBehaviour
{
    public GameObject panelToDisable; // Reference to the panel you want to disable

    // Assign this method to your button's onClick event in the Unity Editor
    public void DisablePanel()
    {
        if (panelToDisable != null)
        {
            // Disable the panel
            panelToDisable.SetActive(false);
        }
        else
        {
            Debug.LogError("Panel to disable is not assigned!");
        }
    }
}