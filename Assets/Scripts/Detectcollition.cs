using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectcollition : MonoBehaviour
{
      private int counter = 0;
    private int objective = 10;
    void Update()
    {
        
    }

 

    private void OnTriggerEnter(Collider otherCollider) //cuando se choque con algo en su collider
    {

        if (gameObject.CompareTag("Player") && otherCollider.gameObject.CompareTag ("diamante"))
        {
            Destroy(otherCollider.gameObject);
            counter += 1;
            Debug.Log($"Diamantes {counter}/{objective}");
            if (counter >= objective)
            {
                Debug.Log("CONGRATULATIONS! YOU WIN!!");
                Time.timeScale = 0;
            }
        }

        if (gameObject.CompareTag("Player") && otherCollider.gameObject.CompareTag("bomba"))
        {
            Destroy(gameObject); //destruimos el proyectil
            Destroy(otherCollider.gameObject);
            Debug.Log("HAS MUERTO! GameOver");
            Time.timeScale = 0;
        }

        if (gameObject.CompareTag("Misil") && otherCollider.gameObject.CompareTag("bomba"))
        {
            Destroy(otherCollider.gameObject);
            Debug.Log("Buen tiro!");
        }

       else
        {

        }

    }

}
