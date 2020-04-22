using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = this.transform.eulerAngles;
        rot.y += 0.1f;
        this.transform.eulerAngles = rot;

        Vector3 pos = this.transform.position;
        pos.z += 0.1f;
        this.transform.position = pos;
    }
}
