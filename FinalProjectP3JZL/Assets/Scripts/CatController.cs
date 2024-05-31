using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public float horzInput;
    public float vertInput;
    public float speed;

    public Transform orientation;
    Vector3 moveDirection;



    public float jumpForce;
    public bool isOnGround;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        horzInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
        //Find direction
        moveDirection = orientation.forward * vertInput + orientation.right * horzInput;
       
        transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

        //Forwrd movement
        transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);

        //If SPACE, jump and can't double 
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }


      



    }
    private void OnCollisionEnter(Collision collision)
    {
       isOnGround = true;
    }





}
