using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody roObj;
    private WaitForSeconds wfrObj;
    public float force;

    public float holdTime = 2f;

    private IEnumerator Start()
    {
        roObj = GetComponent<Rigidbody>();
        roObj.useGravity = false;
        roObj.velocity = Vector3.right * force;
        wfrObj = new WaitForSeconds(holdTime);
        yield return wfrObj;
        Destroy(gameObject);
    }
}
