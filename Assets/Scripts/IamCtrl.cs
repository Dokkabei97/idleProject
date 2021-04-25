using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IamCtrl : MonoBehaviour
{
    GameObject imgObj;
    Image imgAlbum;

    private void Start()
    {
        imgObj = GameObject.Find("IAM");
        imgAlbum = imgObj.GetComponent<Image>();
    }

    public void Iam()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/IAM") as Sprite;
    }

    public void Hann()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/HANN") as Sprite;
    }
    
    public void Imade()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/IMADE") as Sprite;
    }

    public void Uhoh()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/UHOH") as Sprite;
    }

    public void Itrust()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/ITRUST") as Sprite;
    }

    public void Trend()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/ITTREND") as Sprite;
    }

    public void Dumdi()
    {
        imgAlbum.sprite = Resources.Load<Sprite>("Album/DUMDI") as Sprite;
    }
}
