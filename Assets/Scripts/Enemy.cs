using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private SpriteRenderer _spriteRenderer;
    private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        UpdateView();
        Move();
    }

    private void Move()
    {
        Vector3 direction = (_target.position - transform.position).normalized;

        transform.Translate (direction * _speed * Time.deltaTime);
    }

    private void UpdateView()
    {
        _spriteRenderer.flipX = transform.position.x > _target.position.x;
    }
}
