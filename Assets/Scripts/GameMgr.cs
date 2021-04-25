using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum set
{
    start,
    iam,
    vapp,
    qdom,
    gbc,
    nland
}


public class GameMgr : MonoBehaviour
{
    public Button iamBtn, vappBtn, qdomBtn, gbcBtn, nlandBtn, resetBtn, exitBtn;

    GidleCtrl gctrl = null;

    public static set state = set.start;

    GameObject Iam, Vapp, Qdom, Gbc, Nland;

    float cool;


    // Start is called before the first frame update
    void Start()
    {
        if (iamBtn != null)
        {
            iamBtn.onClick.AddListener(iamFuc);
        }
        if (vappBtn != null)
        {
            vappBtn.onClick.AddListener(vappFuc);
        }
        if (qdomBtn != null)
        {
            qdomBtn.onClick.AddListener(qdomFuc);
        }
        if (gbcBtn != null)
        {
            gbcBtn.onClick.AddListener(gbcFuc);
        }
        if (nlandBtn != null)
        {
            nlandBtn.onClick.AddListener(nlandFuc);
        }
        if (resetBtn != null)
        {
            resetBtn.onClick.AddListener(resetFuc);
        }
        if (exitBtn != null)
        {
            exitBtn.onClick.AddListener(exitFuc);
        }

        GameObject gmObj = GameObject.Find("Gidle");
        if (gmObj != null)
            gctrl = gmObj.GetComponent<GidleCtrl>();

        Iam = GameObject.Find("IAM");
        Nland = GameObject.Find("NLAND");
        Vapp = GameObject.Find("VAPP");
        Qdom = GameObject.Find("QDOM");
        Gbc = GameObject.Find("GBC");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void iamFuc()
    {
        state = set.iam;
        btnFalse();
    }

    void vappFuc()
    {
        state = set.vapp;
        btnFalse();
    }
    void qdomFuc()
    {
        state = set.qdom;
        btnFalse();
    }
    void gbcFuc()
    {
        state = set.gbc;
        btnFalse();
    }
    void nlandFuc()
    {
        state = set.nland;
        btnFalse();
    }
    void resetFuc()
    {

        state = set.start;

        iamBtn.interactable = true;
        vappBtn.interactable = true;
        qdomBtn.interactable = true;
        gbcBtn.interactable = true;
        nlandBtn.interactable = true;

        Iam.GetComponent<Image>().fillAmount = 0;
        Nland.GetComponent<Image>().fillAmount = 0;
        Vapp.GetComponent<Image>().fillAmount = 0;
        Qdom.GetComponent<Image>().fillAmount = 0;
        Gbc.GetComponent<Image>().fillAmount = 0;

        gctrl.reset();

    }
    void exitFuc()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LobbyScene");
    }
    void btnFalse()
    {
        iamBtn.interactable = false;
        vappBtn.interactable = false;
        qdomBtn.interactable = false;
        gbcBtn.interactable = false;
        nlandBtn.interactable = false;
    }
    public IEnumerator IAM(float cool)
    {
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            Iam.GetComponent<Image>().fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }
    }

    public IEnumerator NLAND(float cool)
    {
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            Nland.GetComponent<Image>().fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }
    }

    public IEnumerator VAPP(float cool)
    {
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            Vapp.GetComponent<Image>().fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }
    }

    public IEnumerator QDOM(float cool)
    {
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            Qdom.GetComponent<Image>().fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }
    }

    public IEnumerator GBC(float cool)
    {
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            Gbc.GetComponent<Image>().fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }
    }
}
