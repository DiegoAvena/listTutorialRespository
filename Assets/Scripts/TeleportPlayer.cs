using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportPlayer : MonoBehaviour {

    public void Teleport() {

        Debug.Log("Telport to:" + ButtonController.playerToTeleportToName);
        //Vector3 newPosition = GameObject.FindGameObjectWithTag(ButtonController.playerToTeleportToName).transform.position;
        //this.transform.position = newPosition;

    }

}
