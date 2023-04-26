using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody Rigidbody;
    public float SpeedRotation;

    [SerializeField]
    private float _moveSpeed = 1;

    public ForceMode ForceMode = ForceMode.Force;
    //public int nbsaut = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Input.mousePosition;

        mousepos.z = 0;

        Vector3 camerainit = Camera.main.WorldToScreenPoint(transform.position);
        mousepos.x = mousepos.x - camerainit.x;
        mousepos.y = mousepos.y - camerainit.y;
        float angle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, -angle + 90, 0));
        // mouvement X et Z
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(_moveSpeed * horizontal, Rigidbody.velocity.y, _moveSpeed * vertical);

        Rigidbody.velocity = movement;

        //float rotationInput = Input.GetAxis("Rotation");

        //transform.Rotate(0, SpeedRotation * rotationInput * Time.deltaTime, 0);
    }
}
