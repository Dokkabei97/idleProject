using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GidleImgCtrl : MonoBehaviour
{
    GameObject imgObj;
    Image imgIdle;

    void Start()
    {
        imgObj = GameObject.Find("Gidle");
        imgIdle = imgObj.GetComponent<Image>();
    }

    public void Latata()
    {
        imgIdle.sprite = Resources.Load<Sprite>("Resource/IDLE/Latata") as Sprite;
    }

    public void Senorita()
    {
        imgIdle.sprite = Resources.Load<Sprite>("Senorita") as Sprite;
    }

    public void Uhoh()
    {
        imgIdle.sprite = Resources.Load<Sprite>("IDLE/Iuhoh") as Sprite;
    }
}
