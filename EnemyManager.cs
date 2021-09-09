using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    public Transform canvas;


    public static EnemyManager instance;


    private void Awake()
    {
        instance = this;
    }

    public void CreateNewEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

        GameObject obj = Instantiate(enemyToSpawn, canvas);

        curEnemy = obj.GetComponent<Enemy>();
    }

    public void DefeatEnemy(GameObject enemy)
    {
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.instance.BackgroundCheck();
    }
}
