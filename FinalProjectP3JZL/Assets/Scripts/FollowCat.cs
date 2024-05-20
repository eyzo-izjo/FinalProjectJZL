using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCat : MonoBehaviour
{
    public GameObject catPlayer;
    private Vector3 offset = new Vector3(0, 3, -7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = catPlayer.transform.position + offset;
    }
}
