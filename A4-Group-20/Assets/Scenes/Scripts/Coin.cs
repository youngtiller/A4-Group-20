using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 15 * Time.deltaTime, 45 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Score.coinsCollected+=1;
        Destroy(gameObject);
        print("hit");

    }

}
