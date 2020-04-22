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
        Vector3 pos = sphereToLook.transform.position;
        pos.y = this.transform.position.y;
        this.transform.LookAt(pos);

        float vert = Input.GetAxis("Vertical");
        Vector3 myPos = this.transform.position;
        myPos.z += vert;
        this.transform.position = myPos;

    }
}
