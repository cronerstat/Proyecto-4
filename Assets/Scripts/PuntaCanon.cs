using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntaCanon : MonoBehaviour
{
    [SerializeField] private GameObject balaPrefab;
    [SerializeField] private List<GameObject> balaList;
    [SerializeField] private int poolSize = 10;


    private static PuntaCanon instance;
    public static PuntaCanon Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        AddBalasToPool(poolSize);
    
    }
    private void AddBalasToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject bala = Instantiate(balaPrefab);
            bala.SetActive(false);
            balaList.Add(bala);
            bala.transform.parent = transform;
        }

    }
    void Update()
    {

    }
    public GameObject Cagada()
    {
        for (int i = 0; i < balaList.Count; i++)
        {
            if (!balaList[i].activeSelf)
            {
                balaList[i].SetActive(true);
                return balaList[i];
            }

        }
        return null;
    }
}
