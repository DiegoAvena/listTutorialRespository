using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DisplayButtons: MonoBehaviour {

    public RectTransform myPanel;
    public GameObject teleportButtonPrefab;

    private List<string> playerTags;

    public int numberOfPlayers;

    private List<Color> usedColors = new List<Color>();

    private void Start()
    {

        playerTags = new List<string>();

        for (int i = 0; i < numberOfPlayers; i++) {

            playerTags.Add("player" + i);

            GameObject newButton = Instantiate(teleportButtonPrefab);

            newButton.name = "teleportToPlayer" + i.ToString() + "button";
            newButton.SendMessage("AddOnClickMethod");
            newButton.transform.SetParent(myPanel);
            newButton.GetComponentInChildren<Text>().text = "player"+i.ToString();

            ColorBlock colorBlock = newButton.GetComponent<Button>().colors;
            Color newColor = SetIndividualPlayerColors();
            newColor[3] = 1;
            colorBlock.normalColor = newColor;
            newButton.GetComponent<Button>().colors = colorBlock;
            Debug.Log(newButton.GetComponent<Button>().colors.normalColor);


        }

        //Destroy(GameObject.)

    }

    private Color SetIndividualPlayerColors() {

        Color potentialPlayerColor;
        bool colorMadeIsValid = false;

        while (true) {

            potentialPlayerColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

            if (usedColors.Count == 0) {

                usedColors.Add(potentialPlayerColor);
                return potentialPlayerColor;

            }

            for (int i = 0; i < usedColors.Count; i++)
            {

                for (int b = 0; b < 3; b++) {

                    Debug.Log((int)usedColors[i][b] + " = " + (int)potentialPlayerColor[b]);
                    if (usedColors[i][b].Equals(potentialPlayerColor[b]) == true)
                    {

                        colorMadeIsValid = false;

                    }
                    else
                    {

                        colorMadeIsValid = true;

                    }

                }

            }

            if (colorMadeIsValid == true) {

                usedColors.Add(potentialPlayerColor);
                return potentialPlayerColor;

            }

        }

    }

    /*private void SetButtonClickedText(string buttonText) {

        Debug.Log(buttonText);
        buttonClickedText = buttonText;

    }*/

}