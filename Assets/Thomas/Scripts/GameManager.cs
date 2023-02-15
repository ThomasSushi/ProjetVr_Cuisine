using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int CompteurPomme;
    public int CompteurPommeMelange;
    public int CompteurOeufs;
    public int CompteurYaourt;
    public int CompteurFarine;
    public int CompteurSucre;
    public int CompteurLevure;
    public int CompteurSucreVanille;
    public bool preparationValide=false;
    
    // Start is called before the first frame update
   
    public static GameManager instance;

    void Start()
    {
        CompteurPomme =CompteurFarine=CompteurLevure=CompteurOeufs=CompteurSucre=CompteurSucreVanille=CompteurYaourt=0;
        
    }

    public void IncreasePommeMelange(){CompteurPommeMelange++;}
    public void IncreasePomme(){CompteurPomme++;}
    public void IncreaseOeufs(){CompteurOeufs++;}
    public void IncreaseYaourt(){CompteurYaourt++;}
    public void IncreaseFarine(){CompteurFarine++;}
    public void IncreaseSucre(){CompteurSucre++;}
    public void IncreaseLevure(){CompteurLevure++;}
    public void IncreaseSucreV(){CompteurSucreVanille++;}

    public void Verification(){
        if(CompteurPommeMelange==0 && (CompteurPomme>=10 && CompteurPomme<=20)&& CompteurOeufs==3 &&  CompteurYaourt==1 && CompteurFarine==3
         &&  CompteurSucre==2&&  CompteurLevure==1&&  CompteurSucreVanille==1){
                preparationValide=true;
         } 
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
