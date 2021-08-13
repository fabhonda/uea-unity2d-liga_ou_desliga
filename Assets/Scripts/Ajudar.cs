using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajudar : MonoBehaviour
{
    public GameObject painel;

    void Start()
    {
        painel.SetActive(false);
    }

    public void abrir()
    {
        painel.SetActive(true);
    }
}
