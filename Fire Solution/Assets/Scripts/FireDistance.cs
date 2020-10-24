using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireDistance : MonoBehaviour
{
    public GameObject alert;
    public GameObject fireSource;
    public GameObject mainCamera;
    public float alertDistance = (float) 3;

    void Update()
    {
        float dist = Vector3.Distance(mainCamera.transform.position, fireSource.transform.position);
        if (dist > alertDistance)
        {
            alert.SetActive(false);
        }
        else
        {
            alert.SetActive(true);
        }
    }
}
