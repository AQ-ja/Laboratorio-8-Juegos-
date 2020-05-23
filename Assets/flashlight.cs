using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public Light lantern;
    public bool on = true;
    void Update()
    {
       if(Input.GetKey("Mouse1"))
        {
            if (on == true)
            {
                lantern.enabled = true;
                on = false;
            }
            else
            {
                lantern.enabled = true;
                on = true;
            }
        }
    }
}
