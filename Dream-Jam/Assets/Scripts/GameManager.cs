using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int contador = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Call this function to increase the contador value
    public void IncreaseContador()
    {
        contador++;
        Debug.Log("Contador = " + contador);
    }

    void Update()
    {
        Debug.Log("contador = " + contador);
        
        if (contador >= 16)
        {
            Debug.Log("Game finished");
        }
    }
}