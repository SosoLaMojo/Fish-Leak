using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO_Repulsif : ScriptableObject
{
    [SerializeField] GameObject prefabRepulsif;
    //[SerializeField] float WaveSpeed;
    [SerializeField] float delay;
    [SerializeField] Sprite sprite;

    //[SerializeField] float dispertion;
    [SerializeField] int numb;  

    public Sprite Sprite => sprite;

    public float Delay => delay;

    //public float BulletSpeed => WaveSpeed;

    public GameObject PrefabRepulsif => prefabRepulsif;

    //public float Dispertion => dispertion;

    public int Numb => numb;
}
