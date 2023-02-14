using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop.BeerTapGame
{
    public class GameManager : MonoBehaviour
    {
        public enum GameState
        {
            Undefined, 
            Stationary, 
            Pouring,
            Moving
        }

        public static GameState state = GameState.Stationary;

        //change the state variable then use that variable for gamelogic e.g. if statement
        
        //where do i need to set the state from
        // where does the game change 
        // where do i need to reference it
    }
}
