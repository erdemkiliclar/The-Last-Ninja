using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [SerializeField] Image _img;
    [SerializeField]  GameObject _keys;
    [SerializeField] Text _keytext;
    [SerializeField] GameObject _doors , _door;
    public int _keyCount = 0;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            _keyCount = 1;
            Destroy(_keys);
          //  _keys.gameObject.SetActive(false);
            _img.gameObject.SetActive(true);
        }
   
    }
    private void OnTriggerStay2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "door")
        {
            if (_keyCount == 0)
            {
                _keytext.text = "Key Bulmal�s�n.";
            }
            else if (_keyCount == 1)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Destroy(_door.gameObject);
                    _doors.gameObject.SetActive(true);
                    StartCoroutine(_�enmator());
                }
            }
            
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _keytext.text = "";
    }

    IEnumerator _�enmator()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
    
}
