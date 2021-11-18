using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
	[SerializeField] private Transform player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other){
	print("hit");
	player.transform.position = new Vector3(0,1,-18);
	}
}
