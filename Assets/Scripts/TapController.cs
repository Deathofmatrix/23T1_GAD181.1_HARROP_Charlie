using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class TapController : MonoBehaviour
    {
        [SerializeField] Mug mug;
        [SerializeField] SpriteRenderer beerLine;
        private float tapSpeed = 2.5f;
        [SerializeField] private float fullness = 0;

        // Update is called once per frame
        void Update()
        {
            TapActivation();
        }

        void TapActivation()
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
    }
}

