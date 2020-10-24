using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickTest : MonoBehaviour
{
    public GameObject anchor;
    public Material material;
    public TextMeshPro textDescription;
    private bool hazard = true;

    public void toggleType()
    {
        anchor.GetComponent<MeshRenderer>().material = material;
        switchMaterial();
    }
    void switchMaterial()
    {
        if (hazard == true)
        {
            hazard = false;
            material.SetColor("_Color", Color.green);
            textDescription.SetText("Objective");
        }
        else if (hazard == false)
        {
            hazard = true;
            material.SetColor("_Color", Color.magenta);
            textDescription.text = "Hazard";
        }
    }

}
