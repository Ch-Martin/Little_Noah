using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpeakVendedor : MonoBehaviour
{
    public string npcName;

    public GameObject dialogoPanel;

    public TextMeshProUGUI dialogoText;
    
    public Button comercialButton;

    public GameObject menuPanel;

    public bool activeBoton;

    public Image avatarImage;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        ExitMenu();
        if (collision.gameObject.name == "Player")
        {
            dialogoPanel.gameObject.SetActive(true);

            dialogoText.gameObject.SetActive(true);

            comercialButton.gameObject.SetActive(true);

            avatarImage.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            dialogoPanel.gameObject.SetActive(false);

            dialogoText.gameObject.SetActive(false);

            comercialButton.gameObject.SetActive(false);

            avatarImage.gameObject.SetActive(false);
        }
    }



    public void ActiveMenu()
    {

        menuPanel.gameObject.SetActive(true);

    }


    public void ExitMenu()
    {

        menuPanel.gameObject.SetActive(false);

    }

    public void ControlBoton ()
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
    }

}







