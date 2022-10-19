using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    private bool isInsideZone;

    public InputAction interactAction;

    private void OnEnable()
    {
        interactAction.Enable();
    }

    public virtual void Interact()
    {
        Debug.Log("Interact");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Ha entrado al area");
            isInsideZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Ha salido del area");
            isInsideZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInsideZone)
        {
            if(interactAction.WasPerformedThisFrame())
            {
                Interact();
            }
            
        }
    }
}
