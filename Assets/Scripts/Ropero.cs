using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropero : MonoBehaviour
{
   // public GameObject menuPanel;

    public GameObject roperoPanel;

   // public bool activeBoton;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       // ExitMenu();
        if (collision.gameObject.name == "Player")
        {
            roperoPanel.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            roperoPanel.gameObject.SetActive(false);

        }
    }


/*
    public void ActiveMenu()
    {

        menuPanel.gameObject.SetActive(true);

    }


    public void ExitMenu()
    {

        menuPanel.gameObject.SetActive(false);

    }

    public void ControlBoton()
    {
        if (!activeBoton)
        {
            ActiveMenu();
            activeBoton = true;
        }
        else
        {
            ExitMenu();
            activeBoton = false;
        }
    }*/

}
