using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class MugController : MonoBehaviour
    {
        [SerializeField] private MugSpawnerController mugSpawnerController;
        [SerializeField] private float mugSpeed;
        [SerializeField] private float currentMugSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            MugMover();
        }

        private void MugMover()
        {
            if (GameManager.state == GameManager.GameState.Moving)
            {
                if (CurrentMugManager.currentMug != null)
                CurrentMugManager.currentMug.transform.position += new Vector3(-1 * currentMugSpeed * Time.deltaTime, 0, 0);

                foreach (Mug mug in mugSpawnerController.allMugs)
                {
                    if (mug != null)
                    {
                        mug.transform.position += new Vector3(-1 * mugSpeed * Time.deltaTime, 0, 0);
                    }
                }
            }
        }
    }
}
