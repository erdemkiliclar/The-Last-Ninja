using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator _anim;
    [SerializeField] GameObject _key;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            _anim.Play("SandikOpenAnim");

            _key.gameObject.SetActive(true);

            

        }
      
    }
    
}
