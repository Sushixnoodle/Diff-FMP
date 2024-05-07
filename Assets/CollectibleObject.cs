using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleObject : MonoBehaviour
{
    [SerializeField] private float interactionDistance = 2f; // Adjust this distance as needed

    void Update()
    {
        // Check if the "e" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Find the player
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                // Calculate the distance between the player and the collectible object
                float distance = Vector3.Distance(transform.position, player.transform.position);
                if (distance <= interactionDistance)
                {
                    // Check if the object is clickable (you can add additional conditions if needed)
                    if (gameObject.activeInHierarchy && gameObject.CompareTag("Collectible"))
                    {
                        // Call CollectObject method on the ObjectCollector script attached to the player
                        player.GetComponent<ObjectCollector>().CollectObject();

                        // Optionally, destroy the collected object
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}