using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsController : MonoBehaviour
{
   [SerializeField] float _playerSpeed;
    
   [SerializeField] GameObject _player;
    private void Awake()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.W))
        {
           
            _player.transform.position += new Vector3(Input.GetAxis("Horizontal") * _playerSpeed * Time.deltaTime, Input.GetAxis("Vertical") * _playerSpeed * Time.deltaTime);
            _player.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _player.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
