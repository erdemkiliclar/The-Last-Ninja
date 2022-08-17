using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int _maxHealth = 100;
    [SerializeField] int _currentHealth , _Enemydamage;
    [SerializeField] HealthBar healthBar;
    Animator _animator;
    [SerializeField] Image _deadimage;
    PlayerController _playercont;
    AnimatorController _animcol;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _playercont = GetComponent<PlayerController>();
        _animcol = GetComponent<AnimatorController>();
        healthBar = GetComponentInChildren<HealthBar>();
    }
    private void Start()
    {
        _currentHealth = _maxHealth;
        healthBar.PlayerMaxHealth(_maxHealth);
        
    }

   public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        healthBar.PlayerHealth(_currentHealth);
    }
    public void Can(int can)
    {
        _currentHealth += can;
        healthBar.PlayerHealth(_currentHealth);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyShuriken"))
        {
            TakeDamage(_Enemydamage);
        }
        if (_currentHealth <= 0)
        {
            _animator.Play("dead");
            _playercont.enabled = false;
            _animcol.enabled = false;
            StartCoroutine(_playerdead());
        }
    }

    IEnumerator _playerdead()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
        _deadimage.gameObject.SetActive(true);
    }
}
