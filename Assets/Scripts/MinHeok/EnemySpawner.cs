using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance = null;
    [SerializeField] GameObject enemy;
    [SerializeField] Transform enemyMinPos;
    [SerializeField] Transform enemyMaxPos;
    [SerializeField] float spawnDelay;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine(DelayEnemy());
    }
    private void Update()
    {
        
    }
    private IEnumerator DelayEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector3 spawnPos = new Vector3(8,-1,0);
            GameObject temp = Pooling.Instance.Spawn(enemy, Pooling.Instance.enemyPooler);
            temp.transform.position = spawnPos;
        }
    }
}
