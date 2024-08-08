using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static event Action onDeath;

    public static event Action onFlap;

    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;

    public GameManager gameManager;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * velocity;
            onFlap?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        onDeath?.Invoke();
        isDead = true;
        gameManager.GameOver();
    
    }

}
