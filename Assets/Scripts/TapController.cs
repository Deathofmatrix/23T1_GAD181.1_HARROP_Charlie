using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class TapController : MonoBehaviour
    {
        [SerializeField] private Mug mug;
        [SerializeField] private Mug currentMug;
        [SerializeField] SpriteRenderer beerLine;
        private float tapSpeed = 2.5f;
        [SerializeField] private float fullness = 0;
        [SerializeField] GameObject CurrentBeerTrigger;
        [SerializeField] MugSpawnerController mugController;
        

        private void Update()
        {
            
            TapActivation();
            //FinishPour();
        }

        private void TapActivation()
        {
            if (Input.GetButton("Jump"))
            {
                currentMug = mug.GetCurrentMug();
                beerLine.enabled = true;
                Debug.Log("Pour Beer");
                fullness += tapSpeed * Time.deltaTime;
                currentMug.SetFullness(3);
                
            }
            else
            {
                beerLine.enabled = false;
            }
        }
        //private void FinishPour()
        //{
        //    if (Input.GetKeyUp(KeyCode.Space))
        //    {
        //        Debug.Log("moving");
        //    }
        //}
    }
}

