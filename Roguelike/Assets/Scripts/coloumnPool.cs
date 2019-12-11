using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloumnPool : MonoBehaviour
{
    public int coloumnPoolSize = 5;
    private GameObject[] coloumns;
    public GameObject coloumnPrefab;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    public float spawnRate = 4f;
    public float coloumnMin = -1f;
    public float coloumnMax = 3.5f;
    private int currentColoumn = 0;
    private float spawnXPosition = 10f;
   
    void Start()
    {
        coloumns = new GameObject[coloumnPoolSize];
        for (int i = 0; i < coloumnPoolSize; i++)
        {
            coloumns[i] = (GameObject)Instantiate(coloumnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(coloumnMin, coloumnMax);
            coloumns[currentColoumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColoumn++;
            if(currentColoumn >= coloumnPoolSize)
            {
                currentColoumn = 0;
            }

        }
    }
}
