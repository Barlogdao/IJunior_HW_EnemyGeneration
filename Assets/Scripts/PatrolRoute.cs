using System.Collections.Generic;
using UnityEngine;

public class PatrolRoute: MonoBehaviour
{
    [SerializeField] private List<Transform> _patrolPoints;

    private Queue<Vector3> _routePoints;


    private void Awake()
    {
        _routePoints = new Queue<Vector3>();

        foreach (Transform point in _patrolPoints)
        {
            _routePoints.Enqueue(point.position);
        }
    }

    public Vector3 GetNextPatrolPoint()
    {
        Vector3 nextPoint = _routePoints.Dequeue();

        _routePoints.Enqueue(nextPoint);
        return nextPoint;
    }
}
