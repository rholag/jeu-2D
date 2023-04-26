using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private Transform target;
    private int desPoint;

    public GameObject joueur;
    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0]; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Ennemiepos = gameObject.transform.position;

        if (joueur != null)
        {
            Vector3 Joueurpos = joueur.transform.position;
            Joueurpos.y = 0;

            Joueurpos.z = Joueurpos.z - Ennemiepos.z;
            Joueurpos.x = Joueurpos.x - Ennemiepos.x;
            float angle = Mathf.Atan2(Joueurpos.z, Joueurpos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, -angle + 90, 0));

            // returns a random number between 0 and 10
            Vector3 dir = new Vector3(0, 0, 0);


            dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
            //Si l'ennemi est quasiment arrivé à sa destination
            if (Random.Range(0, 10) == 1)
            {

                if (Vector3.Distance(transform.position, target.position) < 0.3f)
                {
                    desPoint = (desPoint + 1) % waypoints.Length;
                    target = waypoints[desPoint];
                }
            }
        }


    }
}
