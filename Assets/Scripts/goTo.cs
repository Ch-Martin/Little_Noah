using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goTo : MonoBehaviour
{
    public string newPlaceName = "New Scene Name Here!!!";
    public string uuid;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            FindObjectOfType<PlayerController>().nextUuid = uuid;
            SceneManager.LoadScene(newPlaceName);
        }
    }

}
