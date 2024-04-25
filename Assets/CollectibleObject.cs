using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Check if the object is clickable (you can add additional conditions if needed)
        if (gameObject.activeInHierarchy && gameObject.CompareTag("Collectible"))
        {
            // Call CollectObject method on the ObjectCollector script attached to the player
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.GetComponent<ObjectCollector>().CollectObject();
            }

            // Optionally, destroy the collected object
            Destroy(gameObject);
        }
    }
}