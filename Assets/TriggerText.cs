using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartName : MonoBehaviour
{
    public GameObject partNameText;
    public float displayDistance = 3f; // Adjust this distance as needed

    private void Start()
    {
        partNameText.SetActive(false);
    }

    private void Update()
    {
        // Find the player
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            // Calculate the distance between the player and this object
            float distance = Vector3.Distance(transform.position, player.transform.position);
            // Check if the player is within the display distance
            if (distance <= displayDistance)
            {
                partNameText.SetActive(true);
            }
            else
            {
                partNameText.SetActive(false);
            }
        }
    }
}
