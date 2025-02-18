using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class VRCharacterController : MonoBehaviour
{
    void Awake()
    {
        ActorsManager actorsManager = FindObjectOfType<ActorsManager>();
        if (actorsManager != null)
            actorsManager.SetPlayer(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

