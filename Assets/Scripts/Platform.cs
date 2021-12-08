using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Detect")
        {
            other.transform.parent.SetParent(transform);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Detect")
        {
            other.transform.parent.SetParent(null);
        }
    }
    private void Update()
    {
        transform.position = transform.GetChild(7).position;
    }
}
