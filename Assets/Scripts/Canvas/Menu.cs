using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;  


    public void Jogar(){

        if (Coletaveis.total != 0 ){
            Coletaveis.total = 0;
        }
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Controles(){

        SceneManager.LoadScene("Controles");
    }

    public void Tutorial(){

        SceneManager.LoadScene("Tutorial");
    }

    public void SairJogo(){
        Debug.Log("saiu");
        Application.Quit();
    }
}
