using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsSucsessLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Sucsess = true");
            GameManeger.isLevelSucsess = true;
        }
    }
}
