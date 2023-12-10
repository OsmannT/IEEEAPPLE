using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject basketPrefab;

    public void Start()
    {
        Vector3 spawnPositionBasket = new Vector3(Random.Range(-4.7f, 4.7f), 0, Random.Range(-4.7f, 4.7f));

        Instantiate(basketPrefab, spawnPositionBasket, Quaternion.identity);
    }
}
