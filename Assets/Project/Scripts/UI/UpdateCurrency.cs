﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCurrency : MonoBehaviour {

    Transform currencyText;

	// Use this for initialization
	void Start () {
        currencyText = gameObject.transform.Find("CurrencyAmount").transform;
        EventManager.StartListening("UpdateCurrency", UpdateCurrencyUI);
	}
	
    public void UpdateCurrencyUI()
    {
        currencyText.GetComponent<Text>().text = PlayerController.player.Currency.ToString();
    }
}
