using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldAmount;

    public Sprite[] backgrounds;
    private int curBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 5;
    }


    public void AddGold(int amount)
    {

        gold += amount;
        goldAmount.text = "Gold:  " + gold.ToString();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;
        goldAmount.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;
        if(enemiesUntilBackgroundChange == 0)
        {
            enemiesUntilBackgroundChange = 5;

            curBackground++;
            if(curBackground == backgrounds.Length)
            {
                curBackground = 0;
            }

            backgroundImage.sprite = backgrounds[curBackground];

        }
    }

}
