using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarTela : MonoBehaviour
{
    public void mudaFase(string fase){
        SceneManager.LoadScene(fase);
    }
}
