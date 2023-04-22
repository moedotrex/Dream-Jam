using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformObject : MonoBehaviour
{
    public GameObject dreamVersion;

    private void OnMouseDown () 
    {
    if (Input.GetMouseButtonDown (0)) 
    {
        transform.gameObject.SetActive (false);
        dreamVersion.SetActive(true);
    }
    }

}
