using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Shoot))]
public class Bullet : MonoBehaviour
{
    private Shoot _shoot;

    private void Awake()
    {
        _shoot = GetComponent<Shoot>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _shoot.ShootCall();
        }
    }
}