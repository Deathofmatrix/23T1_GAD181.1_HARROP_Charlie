using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CharlieHarrop.BeerTapGame
{
    public class Mug : MonoBehaviour
    {
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
    }
}
