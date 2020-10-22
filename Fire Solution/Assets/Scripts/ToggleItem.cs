using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleItem : MonoBehaviour
{
    public bool toggleVariable = true;
    void toggleActive()
    {
        if (this.toggleVariable == true) {
            this.toggleVariable = false;
        }
        else if (this.toggleVariable == false) {
            this.toggleVariable = true;
        }
    }
}
