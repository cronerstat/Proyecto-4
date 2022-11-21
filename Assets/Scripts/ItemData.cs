using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Data", menuName = "Item Data")]

public class ItemData : ScriptableObject
{
    [SerializeField] private string itemname;
    [SerializeField] private string itemdescription;
    [SerializeField] private int cost;
    [SerializeField] private int speed;

    public string Itemname { get { return itemname; } }
    public string Itemdescription { get { return itemdescription; } }

    public int Cost {get { return cost; } }

    public int Speed { get{ return speed; } }

}
