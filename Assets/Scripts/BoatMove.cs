using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{

    [SerializeField] float _boatSpeed;
    [SerializeField] Transform _playerBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.tag!="Ground")
        {
            this.transform.position += new Vector3(1*_boatSpeed*Time.deltaTime, 0);
            _playerBody.position = new Vector3(transform.position.x, _playerBody.position.y);
        }
        else
        {
            _boatSpeed = 0;
        }
        
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        _boatSpeed = 0;
    //    }
    //}


}
