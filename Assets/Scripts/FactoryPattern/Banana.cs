using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factoryspace
{
    public class Banana : ObstacleBase
    {

        public static event Action OnBananaPickUp;
        public override void Initialize()
        {
            Debug.Log("Banana!");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Increase score");
            OnBananaPickUp?.Invoke();
            Destroy(this.gameObject);

        }
    }

}
