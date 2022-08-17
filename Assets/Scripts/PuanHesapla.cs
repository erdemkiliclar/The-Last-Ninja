using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuanHesapla : MonoBehaviour
{
    [SerializeField] Text _puanText , _coinText;
    [SerializeField] Image _img;
    PlayerHealth _playerHealth;
    int _coin = 0;


    private void Awake()
    {
        _playerHealth = new PlayerHealth();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            _coin += 5;
            _puanText.text = _coin.ToString();
            Destroy(collision.gameObject);
        }
    }   



   public void OpenMarket()
    {
        _img.gameObject.SetActive(true);
    }

    public void CloseMarket()
    {
        _img.gameObject.SetActive(false);
    }
    public void CanIksiri()
    {
        if (_coin >= 10)
        {
            _coin -= 10;
            _playerHealth.Can(20);
            _puanText.text = _coin.ToString();
        }
        else if (_coin < 10)
        {
            _coinText.text = "Yetersiz Coin !";
        }


    }
}
