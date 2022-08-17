using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYon : MonoBehaviour
{

    [SerializeField] GameObject _bodyy;
    [SerializeField] Transform _playerTransform, _enemyBody;
   

    private void Awake()
    {
      

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            _bodyy.GetComponent<EnemyMove>().enabled = false;
            _bodyy.GetComponent<Animator>().enabled = false;

            if (_playerTransform.position.x > _enemyBody.position.x)
            {
               
                _enemyBody.localScale = new Vector2(-2, 2);
            }
            else
                _enemyBody.localScale = new Vector2(2, 2);
        }        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _bodyy.GetComponent<EnemyMove>().enabled = true;
            _bodyy.GetComponent<Animator>().enabled = true;
        }
    }
}
