using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BulletEnemy")
        {
            StartCoroutine(gameManager.Die());
            Destroy(gameObject);
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
