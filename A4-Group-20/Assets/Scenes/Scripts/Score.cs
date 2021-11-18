using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour{
    public Text Coins;
    public static int coinsCollected=0;

    void Start(){
        
        Coins.text="Coins Collected: " + coinsCollected;
    }

    void update (){
    }

}

