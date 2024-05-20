using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public float horzInput;
    public float vertInput;
    public float speed;
    public float turnSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horzInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

        vertInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);

    }
}
