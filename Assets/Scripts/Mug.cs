using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CharlieHarrop.BeerTapGame
{
    public class Mug : MonoBehaviour
    {
        [SerializeField] public Mug currentMug;

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
        public void MoveOffscreen()
        {
            transform.position += new Vector3(-1 * moveSpeed, 0, 0) * Time.deltaTime;
        }
        public void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("entered");
            currentMug = collider.GetComponent<Mug>();
        }
    }
}
