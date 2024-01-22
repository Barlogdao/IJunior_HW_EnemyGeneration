using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy()
    {
        var enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);

        enemy.Initialize(_target);
    }
}