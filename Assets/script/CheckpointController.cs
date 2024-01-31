using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public GameObject[] checkpoints; // Tableau de tous les checkpoints
    private int currentCheckpointIndex = 0; // Index du checkpoint actuel

    void Start()
    {
        // Désactive tous les checkpoints au démarrage, sauf le premier
        foreach (GameObject checkpoint in checkpoints)
        {
            checkpoint.SetActive(false);
        }
        if (checkpoints.Length > 0)
        {
            // Active le premier checkpoint
            checkpoints[0].SetActive(true);

        }
    }

    public void CheckpointReached(int checkpointIndex)
    {
        // Vérifie si le checkpoint traversé est le checkpoint actuel
        if (checkpointIndex == currentCheckpointIndex)
        {
            // Désactive le checkpoint actuel
            checkpoints[currentCheckpointIndex].SetActive(false);

            // Incrémente l'index et active le prochain checkpoint, s'il existe
            currentCheckpointIndex++;
            if (currentCheckpointIndex < checkpoints.Length)
            {
                checkpoints[currentCheckpointIndex].SetActive(true);
            }
        }
    }
}
