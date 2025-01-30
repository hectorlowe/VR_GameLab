using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleRun : MonoBehaviour
{
    public Collider key;
    [SerializeField] GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Marble"))
        {
            door.SetActive(false);
        }
    }
}
