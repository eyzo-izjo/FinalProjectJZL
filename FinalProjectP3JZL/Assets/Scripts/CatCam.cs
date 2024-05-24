using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCam : MonoBehaviour
{
    public Transform orientation;
    public Transform cat;
    public Transform catObj;
    public Rigidbody rb;
    public float rotationSpeed;
    public float horzLook;
    public float vertLook;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //
        Vector3 viewDir = cat.position - new Vector3(transform.position.x, cat.position.y, transform.position.z);

        //
        horzLook = Input.GetAxis("Horizontal");
        vertLook = Input.GetAxis("Vertical");
        Vector3 lookDir = orientation.forward * vertLook + orientation.right * horzLook;

        if(lookDir != Vector3.zero)
        {
            catObj.forward = Vector3.Slerp(catObj.forward, lookDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}
