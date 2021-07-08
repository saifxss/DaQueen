using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject projectile;
    float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer> 2f)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            timer = 0f;
        }
        
    }
}
