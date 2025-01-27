﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerCont : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform root;
    float mouseX, mouseY;
    public float stomachOffset;
    public ConfigurableJoint hipJoint, stomachJoint;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CamControl();
    }
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -15, 50);
        Quaternion rootRotation = Quaternion.Euler(mouseY, mouseX, 0);

        root.rotation = rootRotation;
        hipJoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        stomachJoint.targetRotation = Quaternion.Euler(-mouseY + stomachOffset, 0, 0);
    }
}
