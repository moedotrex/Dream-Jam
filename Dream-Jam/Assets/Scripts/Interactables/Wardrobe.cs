using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : Interactable
{
    [SerializeField]
    //private GameObject dreamVersion;
    public GameObject particle;
    public GameObject wardrobe;
    private bool wardrobeOpen;

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
        wardrobeOpen = !wardrobeOpen;
        wardrobe.GetComponent<Animator>().SetBool("IsOpen", wardrobeOpen);
        GameManager.instance.IncreaseContador();
        Debug.Log("interacted with " + gameObject.name);
        Instantiate(particle, transform.position, Quaternion.identity);
        //dreamVersion.SetActive(true);

    }
    
}
