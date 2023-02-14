using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class FillObserver : MonoBehaviour
    {
        [SerializeField] private TextDisplay fillText;
        [SerializeField] private Timer timer;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                PourType();
            }
        }
        public void PourType()
        {
            if (CurrentMugManager.currentMug.GetFullness() < 2)
            {
                Debug.Log("Bad Pour");
                fillText.ChangeText("BAD");
            }
            else if (CurrentMugManager.currentMug.GetFullness() < 2.5)
            {
                Debug.Log("Good");
                fillText.ChangeText("GOOD");
            }
            else if (CurrentMugManager.currentMug.GetFullness() < 2.7)
            {
                Debug.Log("Great");
                fillText.ChangeText("GREAT");
            }
            else if (CurrentMugManager.currentMug.GetFullness() < 2.85)
            {
                Debug.Log("Perfect!!!!!!!!!!!");
                fillText.ChangeText("PERFECT");
                timer.timeRemaining += 2;
            }
            else if (CurrentMugManager.currentMug.GetFullness() <= 3)
            {
                Debug.Log("Overflow");
                fillText.ChangeText("OVERFLOW");
            }
        }
    }
}
