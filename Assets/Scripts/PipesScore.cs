using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesScore : MonoBehaviour
{
    public static event Action onPass;

    private Transform player;  // Assign the player transform in the Unity Inspector

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        CheckPosition();
    }

    void CheckPosition()
    {
        if (this == null || player == null)
        {
            Debug.LogWarning("Target Object or Player is not assigned.");
            return;
        }

        // Check if the target object is to the left of the player
        if (this.transform.position.x < player.position.x)
        {
            onPass?.Invoke();
            Destroy(this);
        }
    }
}
