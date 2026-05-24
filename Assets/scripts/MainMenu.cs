using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Saver SAVE;
    public ButtonControl[] buttons;
    public GameObject Panel;
    void Start()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            if (SAVE.LevelDone[i] == true)
            {
                buttons[i].button.enabled = true;
                buttons[i].krest.SetActive(false);
            }
        }
    }

    public void OnOffPanel(bool isOpen)
    {
        Panel.SetActive(isOpen);
    }
}
[System.Serializable]
public class ButtonControl
{
    public Button button;
    public GameObject krest;
}
