using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyLook : MonoBehaviour
{
    public GameObject sphereToLook;
    public bool controlBothAxis = false;
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

        if (controlBothAxis)
        {
            float vert = Input.GetAxis("Vertical");
            float horz = Input.GetAxis("Horizontal");
            Vector3 myPos = this.transform.position;
            myPos = myPos + (new Vector3(horz, 0 , vert));
            this.transform.position = myPos;
        }
        else {
            float vert = Input.GetAxis("Vertical");
            Vector3 myPos = this.transform.position;
            Vector3 dir = this.transform.TransformDirection(Vector3.forward);
            myPos = myPos + dir * vert * 0.5f;
            this.transform.position = myPos;
        }
    }
}
