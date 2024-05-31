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

    public float xRot;
    public float yRot;
    public float senseX;
    public float senseY;

    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Orientation
        Vector3 viewDir = cat.position - new Vector3(transform.position.x, cat.position.y, transform.position.z);
        
        //Rotate player object
        horzLook = Input.GetAxis("Horizontal");
        vertLook = Input.GetAxis("Vertical");
        Vector3 lookDir = orientation.forward * vertLook + orientation.right * horzLook;

        if(lookDir != Vector3.zero)
        {
            catObj.forward = Vector3.Slerp(catObj.forward, lookDir.normalized, Time.deltaTime * rotationSpeed);
        }

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * senseX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * senseY;

        yRot += mouseX;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        //orientation.rotation = Quaternion.Eueler(0, )*/
    }
}
