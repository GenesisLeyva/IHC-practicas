using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    public Material[] activeMaterials = new Material[4];

    public Material inactiveMaterial;

    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = inactiveMaterial;
        
    }

    public override void Interact()
    {
        base.Interact();
        meshRenderer.material = activeMaterials[Random.Range(0, activeMaterials.Length)];
    }

}
