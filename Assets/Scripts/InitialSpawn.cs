using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpawn : MonoBehaviour
{
    Vector3 initialPoint;
    void Start()
    {
        initialPoint = transform.position;
    }

    public void Respawn(Vector3 spot = default(Vector3))
    {
        transform.position = new Vector3(initialPoint.x,initialPoint.y+2,initialPoint.z)/*spot == Vector3.zero ? initialPoint : spot*/;
    }
}
