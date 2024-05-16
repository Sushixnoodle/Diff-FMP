using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtoInteract : MonoBehaviour
{
    public GameObject e_To_Interact;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            e_To_Interact.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            e_To_Interact.gameObject.SetActive(false);
        }
    }
}
