using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIStoreManager : MonoBehaviour
{
    [SerializeField] private Text itemNameText;
    [SerializeField] private Text descriptionText;
    [SerializeField] private Text costText;
    [SerializeField] private Text speedText;

    public static UIStoreManager instance;

    public static UIStoreManager Instance 
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIStoreManager>();

            }
            return instance;

        }
    }
    public void UpdateUI(ItemData itemData)
    {
        itemNameText.text = itemData.Itemname;
        descriptionText.text = itemData.Itemdescription;
        costText.text = itemData.Cost.ToString();
        speedText.text = itemData.Speed.ToString();

    }

}
