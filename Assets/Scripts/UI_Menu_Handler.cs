using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Menu_Handler : MonoBehaviour
{
    public TMP_Text inputPlayerName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        if (DataPersistence.Instance.playerName != string.Empty)
            SceneManager.LoadScene(1);
    }

    public void InputPlayerName()
    {
        DataPersistence.Instance.playerName = inputPlayerName.text;
    }
}
