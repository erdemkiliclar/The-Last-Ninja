using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
   

    [SerializeField] GameObject _enemyShuriken;
    [SerializeField] Transform _parenTransform;

    [Range(0, 4)] [SerializeField] float _minTime;
    [Range(2, 6)] [SerializeField] float _maxTime;

    [SerializeField] float _randomShurikenTime, _currentTime;


    void EnemyShooter()
    {
        Instantiate(_enemyShuriken, _parenTransform.position, _parenTransform.rotation);
        ResetTime();

    }

    void ResetTime()
    {
        _currentTime = 0;
        _randomShurikenTime = Random.Range(_minTime, _maxTime);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _randomShurikenTime)
            {
                EnemyShooter();
            }
        }
    }
}
