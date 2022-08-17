using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    Animator _anims;
    [SerializeField] float _speed;
    [SerializeField] int _scale1, _scale2;
    bool MoveRight;

    private void Update()
    {
        
        if (MoveRight)
        {
          
            transform.Translate(2 * Time.deltaTime * _speed, 0, 0);
            transform.localScale = new Vector2(_scale1, 2);
           
          
        }
        else
        {
            
            transform.Translate(-2 * Time.deltaTime * _speed, 0, 0);
            transform.localScale = new Vector2(_scale2, 2);
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyObstacle"))
        {
            if (MoveRight)
            {
                MoveRight = false;
                

            }
            else
            {
                MoveRight = true;
              
            }
        }
    }
}
 