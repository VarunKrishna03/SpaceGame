using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    [System.Serializable]
    public class PrefabPool
    {
        public GameObject prefabname;
        public int number;
    
    }
    public static Objectpool singleton;
    public List<PrefabPool> items;
    public List<GameObject>poolitems;
    private void Awake()
    {
        singleton = this;
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
