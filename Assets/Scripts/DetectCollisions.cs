using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
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

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            // Debug.Log("Game Over");
            gameManager.Addlives(-1);
            Destroy(gameObject);
            
        }else if(other.CompareTag("Animal")){
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            // gameManager.AddScore(5);
             Destroy(gameObject);
            //  Destroy(other.gameObject);
        }
       
    }
}
