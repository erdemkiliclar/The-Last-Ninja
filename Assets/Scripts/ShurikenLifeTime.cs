using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenLifeTime : MonoBehaviour
{
    [SerializeField] float _shuriTime;
    float _currentTime;

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
        TimeLife();
    }

    void TimeLife()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _shuriTime)
        {
            Destroy(gameObject);
        }
       
    }
}
