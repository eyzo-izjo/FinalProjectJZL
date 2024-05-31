using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class CollisionDetector : MonoBehaviour
{
    
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.UpdateLives(1);
            //Destroy(gameObject);
        }
        else if (other.CompareTag("Target"))
        {
            gameManager.UpdateBatteries(1);
            gameManager.UpdateScore(5);
            Destroy(other.gameObject);
        }
    }

}


