using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;
 
    [SerializeField] Vector2 _enemyDirection;
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
        var enemy = Instantiate(_enemyPrefab, GetRandomSpawnPosition(), Quaternion.identity);

        enemy.SetNormalizedDirection(_enemyDirection.normalized);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)].position;
    }




}
