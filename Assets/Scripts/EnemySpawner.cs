using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    [SerializeField] private float _spawnDelay;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnDelay);

            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        GetRandomSpawnPoint().SpawnEnemy();
    }

    private SpawnPoint GetRandomSpawnPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)];
    }
}
