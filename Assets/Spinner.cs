using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    public float speed;

    private void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }



}
