using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysTransform : MonoBehaviour
{
    [SerializeField] Transform _bossTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _bossTransform.position;
    }
}
