using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleItem : MonoBehaviour
{
    public bool toggleVariable = true;
    public void toggleActive()
    {
        if (this.toggleVariable == true) {
            toggleVariable = false;
            gameObject.SetActive(false);
        }
        else if (this.toggleVariable == false) {
            toggleVariable = true;
            gameObject.SetActive(true);
        }
    }
}
