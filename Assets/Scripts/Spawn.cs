using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform Spot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Detect")
        {
            other.transform.parent.position = Spot.position;
            other.transform.position = Spot.position;
        }

    }
}
