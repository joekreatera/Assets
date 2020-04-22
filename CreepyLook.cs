using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyLook : MonoBehaviour
{
    public GameObject sphereToLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(sphereToLook.transform.position);

    }
}
