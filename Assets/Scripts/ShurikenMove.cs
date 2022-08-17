using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenMove : MonoBehaviour
{
    [SerializeField] float _speed, _turnSpeed;   
    Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = transform.right * _speed * Time.deltaTime;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * _turnSpeed);
    }

        
}
