using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Shoot))]
public class BulletEnnemy : MonoBehaviour
{
    private ShootEnemy _shoot;
    public float shootingRange;
    public Transform joueur;

    private void Awake()
    {
        _shoot = GetComponent<ShootEnemy>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        if(joueur != null)
        {
            if(Vector3.Distance(transform.position, joueur.position) <= shootingRange)
            {
                _shoot.ShootCall();
            }
        }
    }
}
