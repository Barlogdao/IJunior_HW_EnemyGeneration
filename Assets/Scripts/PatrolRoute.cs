using System.Collections.Generic;
using UnityEngine;

public class PatrolRoute
{
    [SerializeField] private List<Transform> _patrolPoints;

    private readonly Queue<Vector3> _routePoints;

    public PatrolRoute(List<Transform> patrolPoints)
    {
        _routePoints = new Queue<Vector3>();

        foreach (Transform point in patrolPoints)
        {
            _routePoints.Enqueue(point.position);
        }
    }

    public Vector3 GetNextPoint()
    {
        Vector3 nextPoint = _routePoints.Dequeue();

        _routePoints.Enqueue(nextPoint);
        return nextPoint;
    }
}
