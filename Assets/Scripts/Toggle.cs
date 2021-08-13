using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Toggle : MonoBehaviour
{
    public List<Button> botoes;
    public List<Sprite> imagens;
    public List<int> lampadas = new List<int>();
    public List<int> correto = new List<int>();
    public List<int> resposta = new List<int>();
    public List<GameObject> paineis;
    
    void Start(){
        for (int i=0; i<resposta.Count;i++){
            botoes[i].image.sprite = imagens[0];
            resposta[i] = -1;
        }
        for(int i = 0; i < paineis.Count; i++)
        {
            paineis[i].SetActive(false);
        }
        //correto.Add(System.Convert.ToInt32(lampadas[0]|lampadas[1]));
    }

    public void ligar(int i){
        if(resposta[i]==-1 | resposta[i]==1){
            resposta[i] = 0;
            botoes[i].image.sprite = imagens[1];
        }else if(resposta[i]==0){
            resposta[i] = 1;
            botoes[i].image.sprite = imagens[2];
        }
    }
    public void executar(){
        bool checar=true;
        if(resposta.Contains(-1)){
            paineis[0].SetActive(true);
        }
        else{
            for(int i=0;i<resposta.Count;i++){
                if(resposta[i] != correto[i]){
                    checar = false;
                    break;
                }
            }
            if(checar){
                paineis[1].SetActive(true);
                PlayerPrefs.SetInt(SceneManager.GetActiveScene().name,1);
            }else{
                paineis[2].SetActive(true);
            }
        }
    }
    public void fechar(int i)
    {
        paineis[i].SetActive(false);
    }

}
