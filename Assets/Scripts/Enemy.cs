using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        Move();
    }

    public void SetNormalizedDirection (Vector2 normalizedDirection)
    {
        _direction = normalizedDirection;
    }

    private void Move()
    {
        transform.position += _speed * Time.deltaTime * _direction;
    }
}
