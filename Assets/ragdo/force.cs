using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public Rigidbody sphy;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        sphy.AddForce(sphy.transform.right * -speed);
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 2);
    }
}
