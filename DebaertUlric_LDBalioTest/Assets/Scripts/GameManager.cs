using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton Pattern
    public static GameManager instance;

    //UI Ref
    public UIManager uiManager;

    //Currency Count
    public int starCount;
    public int coinCount;
    public bool groomFound;

    void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);    

        instance = this;
    }

    public void AddCoin()
    {
        coinCount++;
        uiManager.UpdateUI();
    }

    public void AddStar()
    {
        starCount++;
        uiManager.UpdateUI();
    }

    public void GetGroom()
    {
        groomFound = true;
        uiManager.GetGroom();
    }

    public void LeaveGroom()
    {
        groomFound = false;
        uiManager.LeaveGroom();
    }
}
