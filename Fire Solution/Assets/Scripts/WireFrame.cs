using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireFrame : MonoBehaviour
{

    // Update is called once per frame
    public Mesh mesh;
    public Material material;
    public Transform objectTransform;

    public void Update()
    {
        // will make the mesh appear in the Scene at origin position
        Graphics.DrawMesh(mesh, objectTransform.position, objectTransform.rotation, material, 0);
    }
}
