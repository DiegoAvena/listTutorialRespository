using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DisplayButtons: MonoBehaviour {

    public RectTransform myPanel;
    public GameObject teleportButtonPrefab;

    private List<string> playerTags;

    public int numberOfPlayers;

    private void Start()
    {

        playerTags = new List<string>();

        for (int i = 0; i < numberOfPlayers; i++) {

            playerTags.Add("player" + i);
            GameObject newButton = Instantiate(teleportButtonPrefab);
            //Button newButton = teleportButtonPrefab;

            /*newButton.GetComponent<Button>().onClick.AddListener(delegate {

                SetButtonClickedText("player" + i.ToString());

            });*/

            newButton.name = "teleportToPlayer" + i.ToString() + "button";
            newButton.SendMessage("AddOnClickMethod");
            newButton.transform.SetParent(myPanel);
            newButton.GetComponentInChildren<Text>().text = "player"+i.ToString();

        }

        //Destroy(GameObject.)

    }

    /*private void SetButtonClickedText(string buttonText) {

        Debug.Log(buttonText);
        buttonClickedText = buttonText;

    }*/

}