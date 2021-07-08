using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public Animator anim;
    public GameObject grabbedObj;
    public Rigidbody rb;
    public int isLeftorRight;
    public bool alreadyGrabbing = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(isLeftorRight))
        {
            if(isLeftorRight ==0)
            {
                anim.SetBool("leftUp", true);
            }
            else if (isLeftorRight ==1)
            {
                anim.SetBool("rightUp", true);
            }
            FixedJoint fj = grabbedObj.AddComponent<FixedJoint>();
                fj.connectedBody = rb;
                fj.breakForce = 9001;
        }
        else if (Input.GetMouseButtonUp(isLeftorRight))
        {
            if (isLeftorRight == 0)
            {
                anim.SetBool("leftUp", false);
            }
            else if (isLeftorRight == 1)
            {
                anim.SetBool("rightUp", false);
            }
            if(grabbedObj != null)
            {
                Destroy(grabbedObj.GetComponent<FixedJoint>());
            }
            grabbedObj = null;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        
        
            Debug.Log("w7el");
            grabbedObj = other.gameObject;
        
    }
    private void OnCollisionExit(Collision other)
    {
        Debug.Log("sayeb");
        grabbedObj = null;
    }

}
