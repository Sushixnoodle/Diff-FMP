using UnityEngine;
using UnityEngine.UI;

public class ObjectCounterUI : MonoBehaviour
{
    public ObjectCollector objectCollector;
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        UpdateText();
    }

    private void Update()
    {
        // Update the text continuously (optional)
        UpdateText();
    }

    private void UpdateText()
    {
        // Update the text to display the number of collected objects
      //  textComponent.text = "Objects Collected: " + objectCollector.CollectedObjects.ToString();
    }
}