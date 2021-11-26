using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectcollition : MonoBehaviour
{
      private int counter;
    void Update()
    {
        
    }

 

    private void OnTriggerEnter(Collider otherCollider) //cuando se choque con algo en su collider
    {

        if (otherCollider.gameObject.tag == "diamante")
        {
            Debug.Log($"Diamantes {counter}/5");
            counter += counter;
            if (counter >= 5)
            {
                Debug.Log("CONGRATULATIONS! YOU WIN!!");
                Time.timeScale = 0;
            }
        }

        else
        {
            Destroy(gameObject); //destruimos el proyectil
            Destroy(otherCollider.gameObject);
        }

    }

}
