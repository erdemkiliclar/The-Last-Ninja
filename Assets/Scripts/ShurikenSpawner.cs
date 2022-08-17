using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenSpawner : MonoBehaviour
{
    [SerializeField] GameObject _shuriken;
    [SerializeField] Transform _spawnTransform;
    Animator _anim;
    [SerializeField] float _second;
    float _currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShurikenSpawn();
    }

    void ShurikenSpawn()
    {
      
        _currentTime += Time.deltaTime;

        if (Input.GetMouseButtonDown(1))
        {
            
            if (_currentTime > _second)
            {
              
                Instantiate(_shuriken, _spawnTransform.position, transform.rotation);
                _currentTime = 0;
            }
        }
    }
}
