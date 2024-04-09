using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class DeadZones : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Target" || collision.tag == "Player") {
            UI.instance.OpenEndScreen(); // this will end the game
        }
    }
}
