using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public float offsetX = 0f;

    void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, transform.position.y, transform.position.z);
    }
}
