using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        transform.position += _speed * Time.deltaTime * _direction;
    }

    public void SetDirection (Vector2 direction)
    {
        _direction = direction;
    }
}
