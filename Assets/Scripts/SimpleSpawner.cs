using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;
    public float speed = 800f;

    private void Start()
    {
        InvokeRepeating("Fire", .1f, 1);
    }

    public void Fire()
    {
        GameObject b = Instantiate(ball, spawnPoint.position, Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(speed * Time.deltaTime * -Vector3.forward);
    }
}
