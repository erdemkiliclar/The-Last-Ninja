using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int _maxHealth = 100;
    [SerializeField] int _currentHealth , _playerDamage;
    [SerializeField] HealthBar healthBar;
    AnimatorController _animcont;
    [SerializeField] GameObject _enemy;
    Animator _animator;

    private void Start()
    {
        _currentHealth = _maxHealth;
        healthBar.EnemyMaxHealth(_maxHealth);
        

    }

    private void Awake()
    {
        
        _animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        healthBar.EnemyHealth(_currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shuriken"))
        {
            TakeDamage(_playerDamage);
        }
        if (_currentHealth <= 0)
        {

            _animator.Play("EnemyDeadAnim");
            StartCoroutine(_destroycontrol());
        }
    }

    IEnumerator _destroycontrol()
    {
        yield return new WaitForSeconds(1);
        Destroy(_enemy);
        
    }
}
