using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class TapController : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer beerLine;
        [SerializeField] private MugSpawnerController mugSpawnerController;
        [SerializeField] private float tapSpeed;
        [SerializeField] private float fullness = 0;
        

        private void Update()
        {
            if (GameManager.state == GameManager.GameState.Stationary)
            {
                fullness = 0;
                TapActivation();
                Debug.Log(GameManager.state);
                GameManager.state = GameManager.GameState.Pouring;
            }

            else if (GameManager.state == GameManager.GameState.Pouring)
            {
                TapActivation();
                Debug.Log(GameManager.state);
            }

            FinishPour();
        }

        private void TapActivation()
        {
            if (Input.GetButton("Jump"))
            {
                beerLine.enabled = true;
                Debug.Log("Pour Beer");
                fullness += tapSpeed * Time.deltaTime;
                CurrentMugManager.currentMug.SetFullness(fullness);
                
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
                GameManager.state = GameManager.GameState.Moving;
                Debug.Log(GameManager.state);
            }
        }
    }
}

