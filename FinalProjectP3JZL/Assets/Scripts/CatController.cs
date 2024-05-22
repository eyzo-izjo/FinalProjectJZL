using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public float horzInput;
    public float vertInput;
    public float speed;
    
    public float jumpForce;
    public bool isOnGround;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Side movement
        horzInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

        //Forwrd movement
        vertInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);

        //If SPACE, jump and can't double 
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        //Have cat turn in cursor direction


    }
    private void OnCollisionEnter(Collision collision)
    {
       isOnGround = true;
    }





}
