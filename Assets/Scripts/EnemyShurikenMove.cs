using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShurikenMove : MonoBehaviour
{
    [SerializeField] float _speed, _turnSpeed;
    Transform _body;
    Rigidbody2D _rigidbody2D;
    Vector2 _target;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _body = GameObject.FindGameObjectWithTag("Player").transform;
        _target = new Vector2(_body.position.x, _body.position.y);

    }


    private void FixedUpdate()
    {
        ShurikenMover();
        transform.Rotate(Vector3.forward * Time.deltaTime * _turnSpeed);
    }


    void ShurikenMover()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        if (transform.position.x == _target.x && transform.position.y == _target.y)
        {
            Destroy(gameObject);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
