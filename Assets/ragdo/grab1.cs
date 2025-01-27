﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab1 : MonoBehaviour
{
    public Animator animator;
    public GameObject grabbedObj;
    public Rigidbody rb;
    public int isLeftorRight;
    public bool alreadyGrabbing = false;
    public GameObject tool;
    public ConfigurableJoint Riser;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(isLeftorRight))
        {
            if (isLeftorRight == 0 )
            {
                animator.SetBool("leftUp", true);
            }
            else if (isLeftorRight == 1 )
            {
                animator.SetBool("rightUp", true);
            }
         
        }
        else if (Input.GetMouseButtonUp(isLeftorRight))
        {
            if (isLeftorRight == 0)
            {
                animator.SetBool("leftUp", false);
            }
            else if (isLeftorRight == 1)
            {
                animator.SetBool("rightUp", false);
            }
            if(grabbedObj != null)
            {
                Destroy(grabbedObj.GetComponent<FixedJoint>());
                alreadyGrabbing = false;
            }
            grabbedObj = null;
            
        }


        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("Item") && !alreadyGrabbing)
        {
            Debug.Log("w7el");
           
            grabbedObj = other.gameObject;
            alreadyGrabbing = true;
            FixedJoint fj = grabbedObj.AddComponent<FixedJoint>();
            fj.connectedBody = rb;
            fj.breakForce = 9000;


        }
        if (other.gameObject.CompareTag("switcher") && !alreadyGrabbing)
        {
            Debug.Log("w7el");

            grabbedObj = other.gameObject;
            alreadyGrabbing = true;
            FixedJoint fj = grabbedObj.AddComponent<FixedJoint>();
            fj.connectedBody = rb;
            fj.breakForce = 9000;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("sayeb");
        
    }
}
