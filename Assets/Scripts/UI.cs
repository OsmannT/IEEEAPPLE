using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text health;
    [SerializeField] private int appleCount;
    [SerializeField] private int healthBar = 3;
    public Canvas restartCanvas;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Basket"))
    //    {
    //        appleCount++;
    //        score.text = "Score : " + appleCount;
    //        Destroy(gameObject);

    //    }

    //    if (other.CompareTag("Ground"))
    //    {
    //        healthBar--;
    //        health.text = "Health : " + healthBar;
    //        Destroy(gameObject);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Basket"))
    //    {
    //        appleCount++;
    //        score.text = "Score : " + appleCount;
    //        Destroy(gameObject);

    //    }

    //    if (other.CompareTag("Ground"))
    //    {
    //        healthBar--;
    //        health.text = "Health : " + healthBar;
    //        Destroy(gameObject);
    //    }
    //}

    private void Start()
    {
        restartCanvas.enabled = false;
    }
    public void Update()
    {
        if (healthBar == 0)
        {
            restartCanvas.enabled = true;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            appleCount++;
            score.text = "Score : " + appleCount;

        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            healthBar--;
            health.text = "Health : " + healthBar;
        }
    }

}