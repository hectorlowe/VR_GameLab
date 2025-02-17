using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleRun2 : MonoBehaviour
{
    [SerializeField] GameObject marble; // Reference to the marble GameObject
    [SerializeField] GameObject path; // Reference to the door GameObject
    [SerializeField] float distanceThreshold = 5.0f; // Set the distance threshold here

    private bool maze2Solved = false;

    // Update is called once per frame
    void Update()
    {
        // Only check distance if the maze has not been solved yet
        if (!maze2Solved)
        {
            // Calculate the distance between the maze (this object) and the marble
            float distance = Vector3.Distance(transform.position, marble.transform.position);

            // Check if the distance is greater than the threshold
            if (distance > distanceThreshold)
            {
                CreatePath(); // Call the function to open the door
            }
        }
    }

    private void CreatePath()
    {
        // Move the door to the desired position
        
        path.SetActive(true);
        //path.transform.position = new Vector3(0.319999993f, 1.53999996f, -2.94000006f);
        Debug.Log("Maze solved, Path Created!");

        // Set the flag to indicate the maze is solved
        maze2Solved = true;
    }
}
