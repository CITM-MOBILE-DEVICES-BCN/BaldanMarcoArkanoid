using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Brick : MonoBehaviour
{

    public int HP;
    public TextMeshProUGUI hpLabel;

    public Tuple<Score, Score> scoreDisplays;

    private Score score1;
    private Score score2;
    public void ReceiveDamage(int damage = 1)
    {
        hp -= 1;
    }

    private int hp
    {
        set
        {

            HP = value;
            hpLabel.text = HP.ToString();

            

            if (HP <= 0)
            {

                Invoke("Destroy", 0.01f);
                
                
            }

            AddPoints();

        }
        get => HP;
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }

    private void AddPoints()
    {


            scoreDisplays.Item1.AddPoints(100);
        
      
            scoreDisplays.Item2.AddPoints(100);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ReceiveDamage(100);
    }

}
