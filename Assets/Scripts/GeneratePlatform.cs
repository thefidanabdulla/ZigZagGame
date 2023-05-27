using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    Vector3 lastPos;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;
        
        StartGeneratePlatforms();
        
    }
    public void StartGeneratePlatforms()
    {
        
        InvokeRepeating("GeneratePlatforms", 2f, .2f);
    }
    public void StopGeneratePlatforms()
    {
        CancelInvoke("GeneratePlatforms");
    }
    void GeneratePlatforms()
    {
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            Spawn(true);
        }else if(random == 1){
            Spawn(false);
        }
    }

    void Spawn(bool X)
    {
        Vector3 pos = lastPos;
        if (X)
        {
            pos.x += size;

        }
        else
        {
            pos.z += size;

        }
        Instantiate(platform, pos, Quaternion.identity);
        lastPos = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
