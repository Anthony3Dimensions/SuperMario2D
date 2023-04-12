using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemiePrefab;

    public int enemieToSpawn;

    //public Transform[] spawnPositions = new Transform[3];

    public Transform[] spawnPositions;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemie", 2f, 1.5);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemiesToSpawn == 0)
        {
            CancelInvoke();
        }
    }

    void SpawnEnemie()
    {
        //Transform selectedSpawn = spawnPostions[Random.Range(0, spawnPositions.lenght)];

        //Instantiate(enemiePrefab, selectedSpawn.position, selectedSpawn.rotation);*/

        /*foreach (Transform spawn in spawnPositions)
        {
            Instantiate(enemiePrefab, spawn.position, spawn.rotation);
        }*/
       

        /*for (int i=0; i < spawnPositions.Length; i++)
        {
            Instantiate(enemiePrefab, spawnPositions[i].postion, spawnPositions[i].rotation);
        }*/
        
        /*int i = 0;
        while (i < spawnPositions.Length)
        {
            Instantiate(enemiePrefab, spawnPositions[i].postion, spawnPositions[i].rotation);

            i++;
        }*/

        int i = 0;
        do 
        {
            Instantiate(enemiePrefab, spawnPositions[i].postion, spawnPositions[i].rotation);

            i++;
        }while (i < spawnPositions.Length);

         enemiesToSpawn--;

    }
}
