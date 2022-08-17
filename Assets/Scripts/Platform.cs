using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerTransform.position = new Vector2(transform.position.x, _playerTransform.position.y);
        }
    }
}
