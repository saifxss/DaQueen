using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabweapon : MonoBehaviour
{
    public Transform equipPosition;
    //public GameObject currentWeapon;
    public GameObject WP;
    bool canGrab;
     public Vector3 offset;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (canGrab)
        {
            Debug.Log("canGrab");
            if(Input.GetKeyDown(KeyCode.F))
            {
                  pickUp();
                canGrab = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("ydropi");
            Drop();
            canGrab = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("weapon"))
        {
            canGrab = true;
            WP = other.gameObject;
            
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        canGrab = false;
        
    }
    private void pickUp()
    {
        
        Debug.Log("pickUp");
        Destroy(WP.GetComponent<Rigidbody>());
        WP.transform.parent = equipPosition;
        WP.transform.position = equipPosition.position + offset;
        WP.transform.localEulerAngles = new Vector3(0f,180f,0f);
        

        //WP.GetComponent<Rigidbody>().isKinematic = true;

    }

    private void Drop()
    {
        
        WP.AddComponent<Rigidbody>();
        Debug.Log("Drop");
        WP.transform.parent = null;
        WP = null;
        //WP.GetComponent<Rigidbody>().isKinematic = false;

    }
}
