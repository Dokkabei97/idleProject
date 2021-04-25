using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditCtrl : MonoBehaviour
{
    public Button exitBtn;
    // Start is called before the first frame update
    void Start()
    {
        if (exitBtn != null)
            exitBtn.onClick.AddListener(Back);
    }

    void Back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LobbyScene");
    }
}
