using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headContr : MonoBehaviour
{
    public float mouseSense=200f;
    public Transform playerBody;
    float xRotation =0f;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X");
        float mouseY=Input.GetAxis("Mouse Y");

        xRotation=xRotation - mouseY;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);

        transform.Rotate(0,mouseX,0);
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        playerBody.Rotate(Vector3.up*mouseX);
    }
}
