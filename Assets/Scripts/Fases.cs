using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fases : MonoBehaviour
{
    public List<Sprite> botaodasfases;
    public List<Button> botaozin;
    
    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }
    

    void Start()
    {
        for(int j = 0; j < botaozin.Count; j++){
            botaozin[j].image.sprite = botaodasfases[0];
            if (j!=1){
                botaozin[j].interactable = false;
            }
            else{
                botaozin[j].interactable = true;
            }
        }
        
        for (int i = 1; i < botaozin.Count; i++){
            if (PlayerPrefs.GetInt("Fase0" + i.ToString()) == 1){
                botaozin[i].image.sprite = botaodasfases[1];
                if (i < botaozin.Count-1){
                    botaozin[i + 1].interactable = true;
                }
                
            }
        }
    }
}
