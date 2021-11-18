using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;
    public float camSpeed = 0.125f;
    public Vector3 offset = new Vector3(0f, 4.5f, 9.5f);

    public void Start()
    {
        transform.position += offset;
        transform.rotation = Quaternion.Euler(170f,0f,180f);
    }

    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}