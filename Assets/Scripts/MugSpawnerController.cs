using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class MugSpawnerController : MonoBehaviour
    {
        [SerializeField] private Mug mugPrefab;
        [SerializeField] private bool spawnedMug = false;
        [SerializeField] public List<Mug> allMugs = new List<Mug>();
        private Mug newBeerMug;

        // Start is called before the first frame update
        void Start()
        {
            SpawnMugsStart();
        }

        // Update is called once per frame
        void Update()
        {
            if (GameManager.state == GameManager.GameState.Stationary || GameManager.state == GameManager.GameState.Pouring)
            {
                if (spawnedMug == false)
                {
                    //CurrentMugManager.currentMug.SetFullness(0);
                    newBeerMug = Instantiate(mugPrefab, transform.position, transform.rotation);
                    allMugs.Add(newBeerMug);
                    
                    
                    spawnedMug = true;
                }
            }
            else if (GameManager.state == GameManager.GameState.Moving)
            {
                spawnedMug = false;
            }
        }

        private void SpawnMugsStart()
        {
            CurrentMugManager.currentMug = Instantiate(mugPrefab, new Vector2(0.25f, -2.413f), transform.rotation);
            newBeerMug = Instantiate(mugPrefab, new Vector2(3.25f, -2.413f), transform.rotation);
            allMugs.Add(newBeerMug);
            newBeerMug = Instantiate(mugPrefab, new Vector2(6.25f, -2.413f), transform.rotation);
            allMugs.Add(newBeerMug);
            newBeerMug = Instantiate(mugPrefab, new Vector2(9.25f, -2.413f), transform.rotation);
            allMugs.Add(newBeerMug);
        }
    }
}

