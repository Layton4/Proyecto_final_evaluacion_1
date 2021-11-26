using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float HorizontalInput;
    private float VerticalInput;
    public float speed = 15;
    private float turnspeed = 25;

    private float xMax = 200; //max horizontal
    private float yMax = 200; //max vertical
    private float yMin = 0; //min Vertocal
    private float zMax = 200; //max z
  
    private int objective = 10;
    public GameObject municionprefab;
    private Vector3 offset = new Vector3(0,0,10);


    void Start()
    {

    }


    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); //asociamos el float HorizontalInput a la presion sobre las teclas A y D del teclado A negativa y D positiva
        VerticalInput = Input.GetAxis("Vertical"); //asociamos la variable VerticalInput a la presion sobre las teclas W y S del teclado W positiva y S negativa


        //movimiento hacia adelante automática
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime * HorizontalInput); //con A y D rotaremos en eje Y
        transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime * VerticalInput); //Con W y S rotaremos en eje X

        if (transform.position.x > xMax) //si sobrepasa el limite horizontal por la derecha
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xMax) //si sobrepasa el limite horizontal por la izquierda
        {
            transform.position = new Vector3(-xMax, transform.position.y, transform.position.z);
        }

        if (transform.position.y > yMax) //si sobrepasa el límite vertical por arriba
        {
            transform.position = new Vector3(transform.position.x, yMax, transform.position.z);
        }

        if (transform.position.y < yMin) //si sobrepasa el límite vertical por abajo
        {
            transform.position = new Vector3(transform.position.x, yMin, transform.position.z);
        }

        if (transform.position.z > zMax) //si sobrepasa el límite de z por delante
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        if (transform.position.z < -zMax) //si sobrepasa el límite de z por detrás
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zMax);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(municionprefab, transform.position + offset, gameObject.transform.rotation);
        }

      
    }

    
}
