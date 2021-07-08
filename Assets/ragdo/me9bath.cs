using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me9bath : MonoBehaviour
{
    public GameObject mes3ad;
     public Vector3 locationUp,locationDown;
    float es;
    void Start()
    {
        locationUp += mes3ad.transform.position;
        locationDown= mes3ad.transform.position;
        es += transform.position.z;
    }
    void Update()
    {
        if(this.transform.position.z >= es+0.5f)
        {
            Debug.Log("atla3");
            mes3ad.transform.position = Vector3.Lerp(mes3ad.transform.position, locationUp, Time.deltaTime);
        }
        if (this.transform.position.z <= es -0.5f)
        {
            Debug.Log("ahbet");
            mes3ad.transform.position = Vector3.Lerp(mes3ad.transform.position, locationDown, Time.deltaTime);
        }

    }
}
