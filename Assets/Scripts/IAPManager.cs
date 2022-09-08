using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;



public class IAPManager : MonoBehaviour
{
    private string coin10 = "10_premium";
    private string coin50 = "50_premium";
    private string coin100 = "100_premium";

    private void Awake()
    {
        if(Application.platform != RuntimePlatform.IPhonePlayer)
        {
            //restoreButton.SetActive(false);

        }
    }
    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == coin10)
        {
            Debug.Log("Grant 10 coin");
            PlayerData.instance.PlusMoney(10);
        }

        if (product.definition.id == coin50)
        {
            Debug.Log("Grant 50 coin");
            PlayerData.instance.PlusMoney(50);
        }

        if (product.definition.id == coin100)
        {
            Debug.Log("Grant 100 coin");
            PlayerData.instance.PlusMoney(100);
        }
    }

    public void OnPurchaseFailed( Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + " failed because " + failureReason); 
    }
}
