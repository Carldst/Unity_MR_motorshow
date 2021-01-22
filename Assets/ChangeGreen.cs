using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGreen : MonoBehaviour
{
    public Material changeMaterial;

    public void Change()
    {
        int numOfChildren = transform.childCount;
        for (int i = 0; i < numOfChildren; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            child.GetComponent<Renderer>().material = changeMaterial;
        }
    }
}
