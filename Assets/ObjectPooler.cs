using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bulletpooldictionary = new Dictionary<string, Queue<GameObject>>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
