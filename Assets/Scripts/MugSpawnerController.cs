using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class MugSpawnerController : MonoBehaviour
    {
        [SerializeField] private Mug mugPrefab;
        [SerializeField] private Mug currentMug;
        [SerializeField] private float yPosition;
        [SerializeField] private Vector2 mugPos;
        [SerializeField] private Transform spawnerTransform;
        [SerializeField] private EventManager eventManager;

        // Start is called before the first frame update
        void Start()
        {
            SpawnMugsStart();
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void SpawnMugsStart()
        {
            mugPrefab.SetFullness(0);
            currentMug = Instantiate(mugPrefab, new Vector2(0.25f, -2.413f), transform.rotation);
            Instantiate(mugPrefab, new Vector2(3.25f, -2.413f), transform.rotation);
            Instantiate(mugPrefab, new Vector2(6.25f, -2.413f), transform.rotation);
            Instantiate(mugPrefab, new Vector2(9.25f, -2.413f), transform.rotation);
        }
    }
}

