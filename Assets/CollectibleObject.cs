using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    private bool isCollected = false; // Flag to track if the object has been collected

    private void Update()
    {
        // Check if the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Check if the object is clickable and not already collected
            if (!isCollected && gameObject.activeInHierarchy && gameObject.CompareTag("Collectible"))
            {
                // Call CollectObject method on the ObjectCollector script attached to the player
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if (player != null)
                {
                    player.GetComponent<ObjectCollector>().CollectObject();
                }

                // Set the object as collected
                isCollected = true;

                // Optionally, destroy the collected object
                Destroy(gameObject);
            }
        }
    }
}