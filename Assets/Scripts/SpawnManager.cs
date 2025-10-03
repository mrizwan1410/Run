using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(40, 0, 0);

    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;

    private PlayerController playerConrollerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerConrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);       
    }

    public void SpawnObstacle()
    {
        if (playerConrollerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
            
    }
}
