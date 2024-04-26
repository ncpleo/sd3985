using UnityEngine;
using System;
using UnityEngine.UI;
using Photon.Realtime;

public class Minigame1_PlayerController : MonoBehaviour
{
    public int playerID;

    private Transform _transform;
    private Rigidbody2D _rb;

    public float speed = 4f;
    public float jumpForce = 7.5f;
    public int jumpAbility;

    public float currentY;

    Animator _animator;

    public static bool endGame;

    void Start()
    {
        _transform = this.transform;
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

        endGame = false;
        jumpAbility = 2;
        currentY = 0;
    }

    void Update()
    {
        Control();
        currentY = _transform.position.y;
    }

    void FixedUpdate()
    {
        if (!Minigame1_Timer.timerIsRunning)
        {
            endGame = true;
        }

    }

    void Control()
    {
        if(playerID == 1)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _transform.position += Vector3.left * speed * Time.deltaTime;
                
            }
            if (Input.GetKey(KeyCode.D))
            {
                _transform.position += Vector3.right * speed * Time.deltaTime;
                
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (jumpAbility > 0)
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
                    jumpAbility--;
                }
            }
        }

        if (playerID == 2)
        {
            if (Input.GetKey(KeyCode.J))
            {
                _transform.position += Vector3.left * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.L))
            {
                _transform.position += Vector3.right * speed * Time.deltaTime;

            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (jumpAbility > 0)
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
                    jumpAbility--;
                }
            }
        }

        if (playerID == 3)
        {
            if (Input.GetKey(KeyCode.J))
            {
                _transform.position += Vector3.left * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.L))
            {
                _transform.position += Vector3.right * speed * Time.deltaTime;

            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (jumpAbility > 0)
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
                    jumpAbility--;
                }
            }
        }

        if (playerID == 4)
        {
            if (Input.GetKey(KeyCode.J))
            {
                _transform.position += Vector3.left * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.L))
            {
                _transform.position += Vector3.right * speed * Time.deltaTime;

            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (jumpAbility > 0)
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
                    jumpAbility--;
                }
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


}
