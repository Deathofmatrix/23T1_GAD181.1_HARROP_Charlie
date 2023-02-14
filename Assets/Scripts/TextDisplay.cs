using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class TextDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textFieldUI;


        public void ChangeText(string textToChange)
        {
            textFieldUI.text = textToChange;
        }

        public void ClearText()
        {
            textFieldUI.text = "";
        }
    }
}

