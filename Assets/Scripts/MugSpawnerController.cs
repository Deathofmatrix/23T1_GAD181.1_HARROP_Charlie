using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class MugSpawnerController : MonoBehaviour
    {
        [SerializeField] private Mug mugPrefab;
        [SerializeField] private float yPosition;

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(mugPrefab);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

