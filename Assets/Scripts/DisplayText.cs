using UnityEngine;
//using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DisplayText: MonoBehaviour {

    public RectTransform myPanel;
    public GameObject teleportButtonPrefab;

    private List<string> playerTags;

    public int numberOfPlayers;

    private void Start()
    {

        playerTags = new List<string>();

        for (int i = 0; i < numberOfPlayers; i++) {

            playerTags.Add("player" + i);
            GameObject newButton = (GameObject)Instantiate(teleportButtonPrefab);
            newButton.transform.SetParent(myPanel);
            newButton.GetComponentInChildren<Text>().text = "player"+i.ToString();

        }

    }

}