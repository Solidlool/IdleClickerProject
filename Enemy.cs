using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public Image healthBarFill;
    public int curHp;
    public int maxHp;
    public int goldToGive;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        curHp--;
       
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;
        anim.Stop();
        anim.Play();

        if (curHp <= 0)
        {
            Defeated();
        }
        
    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
