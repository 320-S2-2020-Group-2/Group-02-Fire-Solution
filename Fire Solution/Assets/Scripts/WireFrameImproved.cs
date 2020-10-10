using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireFrameImproved : MonoBehaviour
{

    // Update is called once per frame
    public Material material;
    public Mesh mesh;

    public void Update()
    {
        // will make the mesh appear in the Scene at origin position
        Graphics.DrawMesh(mesh, this.transform.position, this.transform.rotation, material, 0);
    }
}
