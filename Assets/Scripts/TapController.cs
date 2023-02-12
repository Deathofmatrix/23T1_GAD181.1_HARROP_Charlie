using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class TapController : MonoBehaviour
    {
        [SerializeField] private Mug mug;
        [SerializeField] SpriteRenderer beerLine;
        private float tapSpeed = 2.5f;
        [SerializeField] private float fullness = 0;
        [SerializeField] GameObject CurrentBeerTrigger;

        [SerializeField] private List<Mug> mugList;

        // Update is called once per frame
        private void Update()
        {
            TapActivation();
            FinishPour();
        }

        private void TapActivation()
        {
            if (Input.GetButton("Jump"))
            {
                beerLine.enabled = true;
                Debug.Log("Pour Beer");
                fullness += tapSpeed * Time.deltaTime;
                mug.SetFullness(fullness);
                
            }
            else
            {
                beerLine.enabled = false;
            }
        }
        private void FinishPour()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log("moving");
                mug.MoveOffscreen();
            }
        }
    }
}

