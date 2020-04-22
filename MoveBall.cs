using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speedZ = 0.05f;
    public float speedX = 0.05f;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;

        if (pos.z >= 9.75f) {
            speedZ *= -1;
        }
        if (pos.z <=-1f)
        {
            speedZ *= -1;
        }

        if (pos.x >= 2)
        {
            speedX *= -1;
        }
        if (pos.x <= -2f)
        {
            speedX *= -1;
        }
        pos.z += speedZ;
        pos.x += speedX;
        this.transform.position = pos;
    }
}
