using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    //Is temporary, will be replaced later.
    [SerializeField]
    public GameObject towerPrefab;

    //public static object Instance { get; internal set; }

    public GameObject TowerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
