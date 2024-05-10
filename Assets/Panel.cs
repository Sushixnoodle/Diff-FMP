using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject panelToShow; // Reference to the panel you want to show

    public void OnButtonPress()
    {
        if (panelToShow != null)
        {
            panelToShow.SetActive(true);
        }
        else
        {
            Debug.LogError("Panel to show is not assigned!");
        }
    }
}