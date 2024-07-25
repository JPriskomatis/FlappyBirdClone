using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesScore : MonoBehaviour
{
    public static event Action onPass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("asdfasdf");
            onPass?.Invoke();
        }
    }
}
