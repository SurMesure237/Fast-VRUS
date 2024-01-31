using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    // Start est appelé avant la première frame
    void Start()
    {
        
    }

    // Update est appelé à chaque frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // verifie si le drone a atteint un checkpoint
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            // verifie si le checkpoint est le bon
            Debug.Log("Checkpoint reached");
        }
    }
}
