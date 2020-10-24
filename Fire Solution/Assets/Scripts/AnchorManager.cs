using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorManager : MonoBehaviour
{
    public GameObject AnchorItem;
    public Camera mainCamera;

    public void NewAnchor()
    {
        Vector3 newPosition = new Vector3 (mainCamera.transform.position.x, mainCamera.transform.position.y - (float) 0.5, mainCamera.transform.position.z);
        GameObject newRotation = new GameObject();
        newRotation.transform.rotation = new Quaternion (0, mainCamera.transform.rotation.y, 0, 1);


        GameObject newAnchorItem = Instantiate(AnchorItem, newPosition, newRotation.transform.rotation);
    }
    public void ClearAnchors()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Anchor");

        for (int i=0; i < objects.Length; i++)
        {
            Destroy(objects[i]);
        }

    }

}
