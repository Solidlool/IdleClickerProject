using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickersLastTime = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI quantityText;

    private void Update()
    {
        for (int i = 0; i < autoClickersLastTime.Count; i++)
        {
            if (Time.time - autoClickersLastTime[i] >= 1.0f)
            {
                autoClickersLastTime[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        // if we have enough gold to buy the autoclicker,
        if (GameManager.instance.gold >= autoClickerPrice)
        {
            // subtract the amount from our gold and add a new auto clicker to the list.
            GameManager.instance.TakeGold(autoClickerPrice);
            autoClickersLastTime.Add(Time.time);

            quantityText.text = "x " + autoClickersLastTime.Count.ToString();
        }
    }
}
