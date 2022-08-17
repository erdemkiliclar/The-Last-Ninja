using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutu : MonoBehaviour
{
    [SerializeField] GameObject _kirikKutu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shuriken"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            _kirikKutu.gameObject.SetActive(true);

        }
        
    }
}
