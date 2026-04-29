using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Generación : MonoBehaviour
{
    [SerializeField] List<GameObject> flechas = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < flechas.Count; i++)
        {
            flechas[i].SetActive(false);
            flechas [i].transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate()
    {
        for (int i = 0; i < flechas.Count; i++)
        {
            flechas[i].SetActive(true);
            flechas[i].transform.parent = null;
        }
    }
}
