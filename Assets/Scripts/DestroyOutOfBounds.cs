using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if an object goes pass the players view in the game. remove that object 
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound){
            gameManager.Addlives(-1);
            //Debug.Log("Game Over");
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }else if(transform.position.x > sideBound){
            //Debug.Log("Game Over");
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }else if(transform.position.x < -sideBound){
            //Debug.Log("Game Over");
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
    }
}
