using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class IsFalling : MonoBehaviour
{
    public Rigidbody myRigidbody;  //rigdi setado
public float Tacaindo = -10f;  
[HideInInspector]
public bool Caindo = false;  
 
 
void Update()
{
    if (myRigidbody.velocity.y < Tacaindo)
    {
        Caindo = true;
    }
    else
    {
        Caindo = false;
    }
 
    if (Caindo)
    {
        doSomethingWhenFalling();
    }
}
 
private void doSomethingWhenFalling()
{
     SceneManager.LoadScene("Bug");
}
    // versão antiga do ta caindo
    /*public void tacaindo()
    {
        if (GetComponent<Rigidbody> ().velocity.y >= 0.15f){
            SceneManager.LoadScene("Menu");
        }
        
    }

    void Update(){
    tacaindo();
    } */
}
