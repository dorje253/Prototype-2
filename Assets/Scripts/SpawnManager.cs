using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spwanRangeX  = 20;
    private float spwanRangeZ = 20;
    private float startDelay = 2;
    private float spwanInterval = 1.5f;

    public float sideSpawnMinz;
    public float sideSpawnMaxz;
    public float sideSpawnX;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanRandomAnimal", startDelay, spwanInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spwanInterval);
        InvokeRepeating("spawnRightAnimal", startDelay, spwanInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
       
    }

    void SpwanRandomAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
         Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    
    }

    void SpawnLeftAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); 
    }

    void spawnRightAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0,  Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); 
    }




}
