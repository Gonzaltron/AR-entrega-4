using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Generación : MonoBehaviour
{
    [SerializeField] List<GameObject> flechas = new List<GameObject>();

    int id;
    [SerializeField] AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < flechas.Count; i++)
        {
            flechas[i].SetActive(false);
            flechas [i].transform.parent = transform;
        }
        id = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate()
    {
        foreach (GameObject obj in flechas)
        {
            obj.transform.parent = null;
        }
        flechas[0].SetActive(true);
    }

    void OnTriggerEnter(Collider obj)
    {
        if(obj.CompareTag("Flecha"))
        {
            obj.enabled = false;
            flechas[id].SetActive(true);
            id++;
            audio.Play();
        }
    }
}
