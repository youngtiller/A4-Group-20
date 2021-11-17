using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;
    public float camSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 10, -10);

    public void Start()
    {
        transform.rotation = Quaternion.Euler(40f,0f,0f);
    }

    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}