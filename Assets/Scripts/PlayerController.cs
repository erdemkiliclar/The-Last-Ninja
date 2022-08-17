using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _playerSpeed , _forceSpeed;
   // [SerializeField] GameObject _player;
    Rigidbody2D _rb;
    [SerializeField] SpriteRenderer _sr;
    bool _aktifMi;

    public bool IsJumpAction => _rb.velocity != Vector2.zero;
    private void Awake()
    {
        _rb = GetComponentInParent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _aktifMi = true;
        }
        
    }
    




    private void FixedUpdate()
    {
        this.transform.position += new Vector3(Input.GetAxis("Horizontal") * _playerSpeed * Time.deltaTime,0);

        if (_aktifMi && !IsJumpAction)
        {
            _rb.AddForce(Vector2.up * _forceSpeed);
        }
        _aktifMi = false;


        



        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {            
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
       
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {            
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

    }
  
}
