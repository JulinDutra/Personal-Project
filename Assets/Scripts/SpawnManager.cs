using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1f;

    private PlayerController playerControllerScript;
    public GameObject player;
    public GameObject ground, roof;
    private int i = 0;
    private List<GameObject> obstacleList = new List<GameObject>();
    public GameObject background;

    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // ABSTRACTION
    // Spawn obstacles
    void SpawnObjects()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(roof.transform.position.x + 5, Random.Range(5, 15), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (playerControllerScript.gameOver == false)
        {
            GameObject childObject = Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation) as GameObject;
            childObject.transform.parent = background.transform;
            obstacleList.Add(childObject);
        }

    }
}
