using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int checkpointIndex; // Index du checkpoint
    private CheckpointController controller;
    private Timer timerScript;
    public int scorePerCheckpoint = 100; // Points attribués pour chaque checkpoint atteint
    private int score;

    void Start()
    {
        controller = FindObjectOfType<CheckpointController>(); // Trouve le contrôleur
        timerScript = FindObjectOfType<Timer>(); // Trouve le script Timer dans la scène
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Informe le contrôleur que ce checkpoint a été atteint
            controller.CheckpointReached(checkpointIndex);

            // Arrête le chronomètre
            timerScript.StopTimer();

            // Calcule le score (peut être plus complexe en fonction de votre jeu)
            score += scorePerCheckpoint;

            // Affiche le temps et le score (ou faites autre chose avec ces informations)
            Debug.Log("Checkpoint atteint! Temps: " + timerScript.GetCurrentTime() + " Score: " + score);

            // Redémarre le chronomètre pour le prochain segment
            timerScript.StartTimer();
        }
    }
}
