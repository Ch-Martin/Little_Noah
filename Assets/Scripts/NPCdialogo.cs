using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CircleCollider2D))]

public class NPCdialogo : MonoBehaviour
{
    public string npcName;
    public string[] npcDialogoLines;
    public Sprite npcSprite;

    private DialogoManager dialogoManager;
    private bool playerInTheZone;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {

        dialogoManager = FindObjectOfType<DialogoManager>();
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInTheZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInTheZone = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        //si el player esta en zona y presiona el click izquierdo
        if (playerInTheZone && Input.GetMouseButtonDown(1))
        {

            string[] finalDialogo = new string[npcDialogoLines.Length];

            int i = 0;
            foreach (string line in npcDialogoLines)
            {
                finalDialogo[i++] = ((npcName != null) ? npcName + "\n" : "") + line;
            }

            if (npcSprite != null)
            {
                dialogoManager.ShowDialogue(finalDialogo, npcSprite);
            }
            else
            {
                dialogoManager.ShowDialogue(finalDialogo);
            }

            //avisa que hablando al script de movimiento

            if (gameObject.GetComponentInParent<NPCMovement>() != null)
            {
                gameObject.GetComponentInParent<NPCMovement>().isTalking = true;
            }



        }
    }
}