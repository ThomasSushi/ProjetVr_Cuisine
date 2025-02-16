using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanPomme : MonoBehaviour
{

    [SerializeField] private PommeSliderScripte nombreDePommeAFaireApparaite;
    [SerializeField] private Button btn;

    [SerializeField] GameObject Pomme;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDePommeAFaireApparaite.nbrPomme;i++){
        Instantiate(Pomme,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
