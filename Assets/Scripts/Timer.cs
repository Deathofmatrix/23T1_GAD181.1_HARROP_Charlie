using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CharlieHarrop.BeerTapGame
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextDisplay text;
        public float timeRemaining = 10;

        private void Update()
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(1);
            }

            text.ChangeText(timeRemaining.ToString());
        }
    }
}

