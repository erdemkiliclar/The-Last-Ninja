using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimatorController : MonoBehaviour
{
    Animator _anim;
    [SerializeField] Image _deadScene;
    PlayerController _playercont;
    AnimatorController _animcol;
    PlayerHealth _playerhealth;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _playercont = GetComponent<PlayerController>();
        _animcol = GetComponent<AnimatorController>();
        _playerhealth = GetComponent<PlayerHealth>();
    }

    private void FixedUpdate()
    {

        //PlayerWalk();
   
    }

    private void Update()
    {
        PlayerWalk();
    }

    void PlayerWalk()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _anim.Play("walk");
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _anim.Play("jump");
            
        }
        else
        {
            _anim.Play("idle");
        }

    }


   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ates")
        {
            _anim.Play("dead");
            _playerhealth.TakeDamage(100);
            _playercont.enabled = false;
            _animcol.enabled = false;
            StartCoroutine(Ienum());


        }
    }
    
    

    IEnumerator Ienum()
    {
        yield return new WaitForSeconds(1);
        
        Time.timeScale = 0;
        _deadScene.gameObject.SetActive(true);

    }

    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }





}
