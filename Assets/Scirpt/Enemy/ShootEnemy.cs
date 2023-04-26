using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public float ShootSpeed = 5;
    private float _shootCool = 0;
    public Transform ShootPoint;
    public float ProjectileSpeed;

    public GameObject Projectil;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_shootCool > 0)
        {
            _shootCool -= Time.deltaTime;
        }
    }

    internal void ShootCall()
    {
        if (_shootCool > 0) return;

        _shootCool = 1f / ShootSpeed;

        //Création de l'objet
        GameObject projectileObj = Instantiate(Projectil, ShootPoint.position, ShootPoint.rotation);

        //Récup le Rigidbody
        Rigidbody projectileRb = projectileObj.GetComponent<Rigidbody>();

        //1. méthode pour montrer la direction du tir
        projectileRb.velocity = ProjectileSpeed * ShootPoint.forward;

        Destroy(projectileObj, 2);
    }
}
