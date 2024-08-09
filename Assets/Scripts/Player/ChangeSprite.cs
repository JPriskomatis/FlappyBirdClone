using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scorespace;

namespace Playerspace
{
    public class ChangeSprite : MonoBehaviour
    {
        public static event Action OnChangeSprite;
        [SerializeField] private Sprite[] sprite;

        private void OnEnable()
        {
            Score.OnChangeMode += EnablePlane;
        }

        private void OnDisable()
        {
            Score.OnChangeMode -= EnablePlane;
        }

        public void EnablePlane()
        {
            OnChangeSprite?.Invoke();
            this.GetComponentInChildren<SpriteRenderer>().sprite = sprite[1];
            this.GetComponentInChildren<Animator>().enabled = false;


        }
    }

}
