using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;

    [SerializeField] Vector2 _direction;
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
        var enemy = Instantiate(_enemyPrefab, GetRandomSpawnPoint().position, Quaternion.identity);
        enemy.SetDirection(_direction);
    }

    private Transform GetRandomSpawnPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)];
    }




}
