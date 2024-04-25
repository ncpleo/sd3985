using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerConcroller2 : MonoBehaviour
{
    private Transform _transform;
    private Rigidbody2D _rb;
    //private SpriteRenderer _spr;

    public float speed = 4f;
    public float jumpForce = 7.5f;
    public int jumpAbility;

    GameSceneManager _gm;

    void Start()
    {
        _transform = this.transform;
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        //_spr = this.gameObject.GetComponent<SpriteRenderer>();
        _gm = GameObject.Find("GameSceneManager").GetComponent<GameSceneManager>();     //search all gameobject to find gm

        jumpAbility = 2;

    }

    void Update()
    {
        Control();
        if (_transform.position.y < -10)
        {
            Dead();
        }
    }

    void Control()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position += Vector3.left * speed * Time.deltaTime;
            //_spr.flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _transform.position += Vector3.right * speed * Time.deltaTime;
            //_spr.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpAbility > 0)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
                jumpAbility--;
            }

        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            jumpAbility = 2;
        }
    }

    public void Dead()
    {
        Destroy(this.gameObject);
    }

}
