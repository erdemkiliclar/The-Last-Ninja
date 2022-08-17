using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;

    void Update()
    {
        enemyControl();
       
    }

    void enemyControl()
    {
        if (_playerTransform.position.x > this.transform.position.x)
        {
            this.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        else
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
