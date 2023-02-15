using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GestionBol : MonoBehaviour
{
    public float necessaryTime = 5f;
    float elapsed;
    private bool melanger=false;
    public GameManager gamemanager;
    public int nbrElement;
    public bool mixture=false;
    

    void Start(){
        nbrElement=0;
    }
    void Update()
    {
        if (nbrElement>15 && !mixture){
            Debug.Log("nbr d'element trop important fin de la mixture");
            mixture=true;
        }
    }
     private void OnTriggerEnter(Collider collision){
        if(!mixture && !melanger){
            if (collision.tag == "egg")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseOeufs();
                nbrElement++;
            }
            if (collision.tag == "apple")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreasePommeMelange();
                nbrElement++;
            }
            if (collision.tag == "yogurt")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseYaourt();
                nbrElement++;
            }
            if (collision.tag == "flour")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseFarine();
                nbrElement++;
            }
            if (collision.tag == "sugar")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseSucre();
                nbrElement++;
            }
            if (collision.tag == "yeast")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseLevure();
                nbrElement++;
            }
            if (collision.tag == "vanillaSugar")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreaseSucreV();
                nbrElement++;
            }
        }
        if(melanger){
            if (collision.tag == "apple")
            {
                Destroy(collision.gameObject);
                gamemanager.IncreasePomme();
            }
        }
      
}


 void OnTriggerStay(Collider other)
 {
     if (other.tag == "fouet" && !melanger)
     {
         elapsed += Time.fixedDeltaTime;
         if (elapsed > necessaryTime)
         {
             melanger=true;
             gamemanager.Verification();
         }
     }
 }
 void OnTriggerExit(Collider other)
 {
     if (other.tag == "fouet")
     {
         elapsed = 0;
     }
 }
}
