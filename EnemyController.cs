using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 look = player.transform.position;
        look.y = this.transform.position.y;
        this.transform.LookAt(look);
        Vector3 dir = this.transform.TransformDirection(Vector3.forward);
        this.GetComponent<CharacterController>().Move(dir * 0.03f);
    }
}
