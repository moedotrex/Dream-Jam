using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformObject : MonoBehaviour
{
    public GameObject dreamVersion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown () 
    {
    if (Input.GetMouseButtonDown (0)) 
    {
        transform.gameObject.SetActive (false);
        dreamVersion.SetActive(true);
    }
    }

}
