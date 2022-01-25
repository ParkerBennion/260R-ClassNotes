using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletFab;
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Instantiate(bulletFab);
            Debug.Log("firedBullet");
        }
    }
}
