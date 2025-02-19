using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleRun : MonoBehaviour
{
    [SerializeField] GameObject marble; // Reference to the marble GameObject
    [SerializeField] GameObject door; // Reference to the door GameObject
    [SerializeField] float distanceThreshold = 5.0f; // Set the distance threshold here

    private bool mazeSolved = false;

    // Update is called once per frame
    void Update()
    {
        // Only check distance if the maze has not been solved yet
        if (!mazeSolved)
        {
            // Calculate the distance between the maze (this object) and the marble
            float distance = Vector3.Distance(transform.position, marble.transform.position);

            // Check if the distance is greater than the threshold
            if (distance > distanceThreshold)
            {
                OpenDoor(); // Call the function to open the door
            }
        }
    }

    private void OpenDoor()
    {
        // Move the door to the desired position
        door.transform.position = new Vector3(0.319999993f, 1.53999996f, -2.94000006f);
        Debug.Log("Maze solved, door opened!");

        // Set the flag to indicate the maze is solved
        mazeSolved = true;
    }
}
