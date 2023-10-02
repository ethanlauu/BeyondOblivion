using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static BGSounds instance = null;
    public static BGSounds Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        
    }
}
