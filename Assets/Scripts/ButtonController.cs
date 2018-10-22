using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public static string playerToTeleportToName;

    private void Update()
    {

    }

    private void AddOnClickMethod() {

        this.GetComponent<Button>().onClick.AddListener(delegate
        {

            SetPlayerToTeleportToName(this.GetComponentInChildren<Text>().text);

        });

    }

    private void SetPlayerToTeleportToName(string buttonName) {

        playerToTeleportToName = buttonName;

    }

}
