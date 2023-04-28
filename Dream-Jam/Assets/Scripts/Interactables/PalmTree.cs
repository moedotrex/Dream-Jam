using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmTree : Interactable
{
    [SerializeField]
    private GameObject dreamVersion;
    public GameObject particle;
    public GameObject ceiling;
    private bool ceilingOpen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //this function is where we will design our interaction using code
    protected override void Interact()
    {
        ceilingOpen = !ceilingOpen;
        ceiling.GetComponent<Animator>().SetBool("IsOpen", ceilingOpen);
        GameManager.instance.IncreaseContador();
        Debug.Log("interacted with " + gameObject.name);
        transform.gameObject.SetActive (false);
        Instantiate(particle, transform.position, Quaternion.identity);
        dreamVersion.SetActive(true);

    }
    
}
