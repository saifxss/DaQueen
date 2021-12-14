using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce;
    public Animator anim;
    
    public Joystick Joystick;
    public Rigidbody hips;
    public bool isGrounded;

    void Start()
    {
        //hips = GetComponent<Rigidbody>();    
        if (isLocalPlayer)
        {
            transform.GetChild(2).GetChild(0).GetChild(0).gameObject.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            if ((Input.GetKey(KeyCode.Z))||(Joystick.Vertical>0))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    anim.SetBool("isWalk", true);
                    anim.SetBool("isRun", true);
                    hips.AddForce(hips.transform.forward * speed * 2f);
                }
                else
                {
                    anim.SetBool("isWalk", true);
                    anim.SetBool("isRun", false);
                    hips.AddForce(hips.transform.forward * speed);
                }

            }
            else
            {
                anim.SetBool("isWalk", false);
                anim.SetBool("isRun", false);
            }
            if ((Input.GetKey(KeyCode.Q))||( Joystick.Horizontal < 0))
            {
                anim.SetBool("right", true);
                hips.AddForce(-hips.transform.right * strafeSpeed);
            }
            else
            {
                anim.SetBool("right", false);
            }
            if ((Input.GetKey(KeyCode.D))||(Joystick.Horizontal > 0))
            {
                anim.SetBool("left", true);
                hips.AddForce(hips.transform.right * strafeSpeed);
            }
            else
            {
                anim.SetBool("left", false);
            }
            if ((Input.GetKey(KeyCode.S))||(Joystick.Vertical <0))
            {
                anim.SetBool("isWalk", true);
                hips.AddForce(-hips.transform.forward * speed);
            }

            if (Input.GetAxis("Jump") > 0)
            {
                if (isGrounded)
                {
                    anim.SetBool("isGround", false);
                    hips.AddForce(new Vector3(0, jumpForce, 0));
                    isGrounded = false;
                }

            }
            if (isGrounded && !(Input.GetAxis("Jump") > 0))
            {
                anim.SetBool("isGround", true);
            }
        }

    }
    /*private void Update()
    {
        if (transform.GetChild(4).position.y < 3f)
        {
            //respawn
        }
    }*/

}
