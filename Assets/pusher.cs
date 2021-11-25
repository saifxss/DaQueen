using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Detect")
        {
            col.transform.parent.GetChild(5).gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 5000f);
            Debug.Log(col.transform.parent.GetChild(5).gameObject.name);
        }
    }
}
