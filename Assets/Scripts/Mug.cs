using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace CharlieHarrop.BeerTapGame
{
    public class Mug : MonoBehaviour
    {
        [SerializeField] private int moveSpeed;
        public Slider slider;
        

        public void SetMaxFullness(float fullness)
        {
            slider.maxValue = fullness;
            slider.value = fullness;
        }
        public void SetFullness(float fullness)
        {
            slider.value = fullness;
        }
        public float GetFullness()
        {
            return slider.value;
        }
        
        public void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("CurrentMugTrigger"))
            {
                Debug.Log("entered");
                SetCurrentMug();
            }
            if (collider.gameObject.CompareTag("MugDestroyer"))
            {
                Debug.Log("destroy");
                Destroy(gameObject);
            }
            
        }

        public void SetCurrentMug()
        {
            GameManager.state = GameManager.GameState.Stationary;
            CurrentMugManager.currentMug = this;
            CurrentMugManager.currentMug.name = "CurrentMug";
        }
    }
}
