using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text starText;
    public TMP_Text coinText;
    public GameObject groomObject;
    public TMP_Text groomText;


    private void Start()
    {
        UpdateUI();
        groomObject.SetActive(false);
    }


    public void UpdateUI()
    {
        starText.text = "x " + GameManager.instance.starCount.ToString();
        coinText.text = "x " + GameManager.instance.coinCount.ToString();
    }

    public void GetGroom()
    {
        groomObject.SetActive(true);
    }

    public void LeaveGroom()
    {
        groomText.text = "x 0";
    }
}
