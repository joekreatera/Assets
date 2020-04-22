using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.layer.Equals("Enemies") )
            Destroy(other.gameObject);
        CancelInvoke("SelfDestroy");
        SelfDestroy();
    }

    void SelfDestroy()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
