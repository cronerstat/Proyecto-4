using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botas : MonoBehaviour
{
    [SerializeField] ItemData itemData;

    private void OnMouseDown()
    {
        UIStoreManager.Instance.UpdateUI(itemData);
    }

}
