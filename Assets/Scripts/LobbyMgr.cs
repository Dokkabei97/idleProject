using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyMgr : MonoBehaviour
{
    public Button startBtn, creditBtn, exitBtn;

    // Start is called before the first frame update
    void Start()
    {
        if(startBtn != null){
            startBtn.onClick.AddListener(Start_fuc);
        }

        if(creditBtn != null){
            creditBtn.onClick.AddListener(Credit_fuc);
        }

        if(exitBtn != null){
            exitBtn.onClick.AddListener(Exit_fuc);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start_fuc(){
         UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    void Credit_fuc(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("CreditScene");
    }

    void Exit_fuc(){
        Application.Quit();
    }
}
