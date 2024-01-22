using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
    [SerializeField] private List<Transform> _patrolPoints;

    private PatrolRoute _patrolRoute;
    private Vector3 _nextPoint;

    private void Awake()
    {
        _patrolRoute = new PatrolRoute(_patrolPoints);
        _nextPoint = _patrolRoute.GetNextPoint();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = (_nextPoint - transform.position).normalized;

        transform.Translate(direction * _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _nextPoint) <= 0.1f)
        {
            _nextPoint = _patrolRoute.GetNextPoint();
        }
    }
}
