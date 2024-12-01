using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
