using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeccionNivel : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
        int random = Random.Range(0, 2);
        if(random == 0 )
        {
            enemy.SetActive(false);
        }
        else
        {
            enemy.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
