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
        [SerializeField] public Mug mug;
        [SerializeField] public static Mug currentMug;

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
        
        public void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("entered");
            //EventManager.current.OnEnterTrigger += SetCurrentMug;
            GetCurrentMug();
            
        }
        public Mug GetCurrentMug()
        {
            currentMug = this;
            currentMug.name = "currentMug";
            return currentMug;
        }
    }
}
