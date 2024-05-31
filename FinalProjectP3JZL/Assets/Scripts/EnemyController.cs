using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{

    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;
    new Rigidbody enemyCat;
    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemyCat = GetComponent<Rigidbody>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 position = enemyCat.position;
        
        position.x = position.x + Time.deltaTime * speed * direction;
        


    }
}
