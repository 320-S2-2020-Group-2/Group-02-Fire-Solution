using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireFrameImproved : MonoBehaviour
{

    // Update is called once per frame
    public Material material;
    public Mesh mesh;
    public bool toggleVariable = true;

    public void toggleActive()
    {
        if (toggleVariable == true)
        {
            toggleVariable = false;
        }
        else if (toggleVariable == false)
        {
            toggleVariable = true;
        }
    }

    public void Update()
    {
        // will make the mesh appear in the Scene at origin position
        if (toggleVariable)
        {
            Graphics.DrawMesh(mesh, this.transform.position, this.transform.rotation, material, 0);
        }
        
    }

}
