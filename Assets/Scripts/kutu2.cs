using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutu2 : MonoBehaviour
{

    [SerializeField] GameObject _kirik;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shuriken"))
        {
            Destroy(_kirik);
            Destroy(collision.gameObject);

        }
    }

 
}
