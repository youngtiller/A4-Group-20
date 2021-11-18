using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{   public void QuiteGame()
    {
            Application.Quit();
            Debug.Log("Quit!");
    }

}
