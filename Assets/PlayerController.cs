using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TMPro namespace

public class PlayerController : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        UpdateCount();
    }

    void OnEnable()
    {
        Collectible.OnCollected += OnCollectibleCollected;
    }

    void OnDisable()
    {
        Collectible.OnCollected -= OnCollectibleCollected;
    }

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        // Check if 'text' is not null before updating its text property
        if (text != null)
        {
            text.text = $"{count} / " + "4";
            Debug.Log($"Updated count: {count}, Total: " + "4");
        }
        else
        {
            Debug.LogWarning("Text component is not assigned in the CollectibleCounter script.");
        }
    }
}