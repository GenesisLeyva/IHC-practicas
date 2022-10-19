using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : Interactable
{
    private Rigidbody rb;

    //public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        base.Interact();
        rb.AddForce(Vector3.forward * speed ,ForceMode.Force);
    }
}
