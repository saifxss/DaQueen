using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Detect")
        {
            col.transform.parent.GetChild(5).gameObject.GetComponent<Rigidbody>().AddForce(col.transform.forward * -9000f);
            
        }
    }
}
