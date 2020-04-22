using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyLook : MonoBehaviour
{
    public GameObject sphereToLook;
    public bool controlBothAxis = false;
    Vector3 cameraOffset;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.transform.position;
        Vector3 camPos = Camera.main.transform.position;
        cameraOffset = camPos - pos;
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

         this.GetComponent<CharacterController>().Move((new Vector3(horz, 0, vert)) * 0.1f);
            
        }
        else {
            float vert = Input.GetAxis("Vertical");
            Vector3 dir = this.transform.TransformDirection(Vector3.forward);
            this.GetComponent<CharacterController>().Move(dir * vert * 0.1f);
        }

        Camera.main.transform.position = this.transform.position + cameraOffset;

        if (Input.GetButtonDown("Jump")) {
            GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
            Rigidbody body = bullet.GetComponent<Rigidbody>();
            Vector3 bulletDir = this.transform.TransformDirection(Vector3.forward);
            body.AddForce(bulletDir * 30, ForceMode.Impulse);
        }

    }
}
