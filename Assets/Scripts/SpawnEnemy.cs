using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1f;

    private PlayerController playerControllerScript;
    public GameObject player;
    public GameObject ground, roof;
    private int i = 0;
    private List<GameObject> enemiesList = new List<GameObject>();
    public GameObject background;
    private GameObject enemySelected;

    void Start()
    {
        enemySelected = enemyPrefabs[0].gameObject;
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // ABSTRACTION
    // Spawn obstacles
    void SpawnObjects()
    {
        //int numberSelected = Random.Range(0, enemyPrefabs.Length);
        int numberSelected = 0;
        if(numberSelected == 0)
        {
            Instantiate(enemySelected);
            enemySelected.GetComponent<Bullet>().SpawnEnemy(player.transform);
            //enemyPrefabs[numberSelected].GetComponent<Bullet>().SpawnEnemy(player.transform);
        }

        //// If game is still active, spawn new object
        //if (playerControllerScript.gameOver == false)
        //{
        //    GameObject childObject = Instantiate(enemyPrefabs[index], spawnLocation, enemyPrefabs[index].transform.rotation) as GameObject;
        //    childObject.transform.parent = background.transform;
        //    enemiesList.Add(childObject);
        //}
    }
}
