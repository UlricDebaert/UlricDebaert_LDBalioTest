using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text starText;
    public TMP_Text coinText;
    public Image goomImage;

    private void Start()
    {
        UpdateUI();
    }


    public void UpdateUI()
    {
        starText.text = "x " + GameManager.instance.starCount.ToString();
        coinText.text = "x " + GameManager.instance.coinCount.ToString();
    }
}
