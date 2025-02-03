using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour

 
{

    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;

    //NPC Speed
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //cantidad de vidas
        health = health + level;
        print("Lives" + health);


    }

    // Update is called once per frame
    void Update()
    {
        //screa la variable de nueva posicion
        Vector3 newPosition = transform.position;

        //Cambia la posici�n del NPC en el eje Z seg�n la velocidad del NPC y el tiempo entre fotogramas.
        newPosition.z += speed * Time.deltaTime;

        //Nueva posicion del NPC
        transform.position = newPosition;



    }
}
