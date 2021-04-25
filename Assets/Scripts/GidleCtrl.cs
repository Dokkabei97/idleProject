using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GidleCtrl : MonoBehaviour
{
    Vector2 startPos;
    float xPoint = 0;
    float yPoint = 0;
    public int count = 0;

    GameMgr gMgr = null;
    IamCtrl iCtrl = null;
    //GidleImgCtrl gCtrl = null;

    public Text endText;

    void Start()
    {
        GameObject gObj = GameObject.Find("GameMgr");
        if (gObj != null)
            gMgr = gObj.GetComponent<GameMgr>();

        GameObject iCObj = GameObject.Find("IAM");
        if (iCObj != null)
            iCtrl = iCObj.GetComponent<IamCtrl>();

        /*  GameObject giObj = GameObject.Find("Gidle");
          if (giObj != null)
              gCtrl = giObj.GetComponent<GidleImgCtrl>();*/
    }
    void Update()
    {
        if (GameMgr.state == set.start)
        {
            xPoint = 0;
            yPoint = 0;
        }

        if (GameMgr.state == set.iam) // IAM 버튼
        {
            if (count == 0 || count == 10 || count == 15)
            {
                xPoint = -0.015f;
                transform.Translate(xPoint, 0, 0);
            }

            if (count == 0 && transform.position.x < -4.8f)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.IAM(2f));
                count = 1;
                btnTrue();
            }
            else if (count == 10 && transform.position.x < -4.8f)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.IAM(2f));
                count = 11;
                btnTrue();
            }
            else if (count == 15 && transform.position.x < -4.8f)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.IAM(2f));
                count = 16;
                btnTrue();
            }
            else if (count != 0 && count != 10 && count != 15)
            {
                count = 99;
                btnTrue();
            }
        }
        else if (GameMgr.state == set.nland) // NLand 버튼
        {
            if (count == 1)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.NLAND(2f));
                count = 2;
                btnTrue();
                iCtrl.Imade();
            }
            else if (count == 6)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.NLAND(2f));
                count = 7;
                btnTrue();
                iCtrl.Uhoh();
            }
            else if (count == 0)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.NLAND(2f));
                count = 10;
                btnTrue();
            }
            else if (count == 16)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.NLAND(2f));
                count = 17;
                btnTrue();
            }
            else if (count != 1 && count != 6 && count != 0 && count != 16)
            {
                count = 99;
                btnTrue();
            }
        }
        else if (GameMgr.state == set.vapp) // Vapp버튼
        {
            if (count == 2 || count == 1 || count == 11)
            {
                xPoint = 0.015f;
                yPoint = 0.015f;
                transform.Translate(xPoint, yPoint, 0);
            }

            if (count == 2 && (transform.position.x >= -2.5f || transform.position.y >= -2.0f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.VAPP(2f));
                count = 3;
                btnTrue();
                iCtrl.Uhoh();
                //gCtrl.Senorita();
            }
            else if (count == 1 && (transform.position.x >= -2.5f || transform.position.y >= -2.0f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.VAPP(2f));
                count = 6;
                btnTrue();
                iCtrl.Imade();
            }
            else if (count == 11 && (transform.position.x >= -2.5f || transform.position.y >= -2.0f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.VAPP(2f));
                count = 12;
                btnTrue();
                iCtrl.Imade();
            }
            else if (count == 0)
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.VAPP(2f));
                count = 15;
                btnTrue();
            }
            else if (count != 0 && count != 2 && count != 1 && count != 11)
            {
                count = 99;
                btnTrue();
            }
        }
        else if (GameMgr.state == set.qdom) // Qdom 버튼
        {
            if (count == 3 || count == 7 || count == 12)
            {
                xPoint = 0.015f;
                transform.Translate(xPoint, 0, 0);
            }
            else if (count == 17)
            {
                if (xPoint == 0)
                {
                    yPoint = 0.015f;
                    transform.Translate(0, yPoint, 0);
                }

                if (transform.position.y >= -2.0f)
                {
                    yPoint = 0.0f;
                    xPoint = 0.015f;
                    transform.Translate(xPoint, 0, 0);
                }
                
            }

            if (count == 3 && (transform.position.x > 2.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.QDOM(2f));
                count = 4;             
                btnTrue();
                iCtrl.Itrust();
            }
            else if (count == 7 && (transform.position.x > 2.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.QDOM(2f));
                count = 8;
                btnTrue();
                iCtrl.Itrust();
            }
            else if (count == 12 && (transform.position.x > 2.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.QDOM(2f));
                count = 13;
                btnTrue();
                iCtrl.Uhoh();
            }
            else if (count == 17 && (transform.position.x > 2.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.QDOM(2f));
                count = 18;
                btnTrue();
                iCtrl.Imade();
            }
            else if (count != 3 && count != 7 && count != 12 && count != 17)
            {
                count = 99;
                btnTrue();
            }
        }
        else if (GameMgr.state == set.gbc) // gbc버튼
        {
            if (count == 4 || count == 8 || count == 13 || count == 18)
            {
                xPoint = 0.015f;
                yPoint = -0.015f;
                transform.Translate(xPoint, yPoint, 0);
            }

            if (count == 4 && (transform.position.x >= 3.3f && transform.position.y <= -3.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.GBC(2f));
                count = 5;          
                btnTrue();
                iCtrl.Dumdi();
            }
            else if (count == 8 && (transform.position.x >= 3.3f && transform.position.y <= -3.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.GBC(2f));
                count = 9;
                btnTrue();
                iCtrl.Dumdi();
            }
            else if (count == 13 && (transform.position.x >= 3.3f && transform.position.y <= -3.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.GBC(2f));
                count = 14;
                btnTrue();
                iCtrl.Itrust();
            }
            else if (count == 18 & (transform.position.x >= 3.3f && transform.position.y <= -3.5f))
            {
                GameMgr.state = set.start;
                StartCoroutine(gMgr.GBC(2f));
                count = 19;
                btnTrue();
                iCtrl.Uhoh();
            }
            else if (count != 4 && count != 8 && count != 13 && count != 18)
            {
                count = 99;
                btnTrue();
            }
        }
    }

    public void reset()
    {
        transform.position = new Vector3(-0.14f, -2.62f, 0);
        count = 0;
        iCtrl.Iam();
        endText.text = "";
        // gCtrl.Latata();
    }

    void btnTrue()
    {
        if (count == 1)
        {
            gMgr.vappBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
            gMgr.nlandBtn.interactable = true;
        }
        else if (count == 2)
        {
            gMgr.vappBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 3)
        {
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 4)
        {
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("CreditScene");
        }
        else if (count == 6)
        {
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
            gMgr.nlandBtn.interactable = true;
        }
        else if (count == 7)
        {
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 8)
        {
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 9)
        {
            string str = "엔딩 - 2\n";
            str += "진짜 엔딩은 바로 크레딧 으로 넘아갑니다!";
            endText.text = str;
        }
        else if (count == 10)
        {
            gMgr.iamBtn.interactable = true;
            gMgr.vappBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 11)
        {
            gMgr.vappBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 12)
        {
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 13)
        {
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 14)
        {
            string str = "엔딩 - 3\n";
            str += "진짜 엔딩은 바로 크레딧 으로 넘아갑니다!";
            endText.text = str;
        }
        else if (count == 15)
        {
            gMgr.iamBtn.interactable = true;
            gMgr.nlandBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 16)
        {
            gMgr.nlandBtn.interactable = true;
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 17)
        {
            gMgr.qdomBtn.interactable = true;
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 18)
        {
            gMgr.gbcBtn.interactable = true;
        }
        else if (count == 19)
        {
            string str = "엔딩 - 4\n";
            str += "진짜 엔딩은 바로 크레딧 으로 넘아갑니다!";
            endText.text = str;
        }
        else if (count == 99)
        {
            string str = "엔딩 - 99\n";
            str += "죄송합니다 미구현 구간 입니다";
            endText.text = str;
        }

    }
}
