using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killer : MonoBehaviour
{
    public ConfigurableJoint CJ;
    public ConfigurableJoint Killer;
    public ConfigurableJoint Riser;
    float timer = 0f;
    public static bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grounded)
        {
            timer += Time.deltaTime;
        }
        if (timer > 0.5f)
        {
            CJ.angularXDrive = Riser.angularXDrive;
            CJ.angularYZDrive = Riser.angularYZDrive;
            grounded = false;
            timer = 0f;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "projectile")
        {
            CJ.angularXDrive = Killer.angularXDrive;
            CJ.angularYZDrive = Killer.angularYZDrive;
            
        }
        if (collision.gameObject.tag != "projectile")
        {
            grounded = true;
            

        }

    }
}
