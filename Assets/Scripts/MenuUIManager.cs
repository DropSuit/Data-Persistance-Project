using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public TMP_InputField nameText;

    public void SetName()
    {
        SaveManager.Instance.PlayerName = nameText.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
