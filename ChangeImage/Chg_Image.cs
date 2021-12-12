using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chg_Image : MonoBehaviour
{
    Image image;
    
    void Start()
    {
        image = this.GetComponent<Image>();
    }
    public void ChangeImage(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
