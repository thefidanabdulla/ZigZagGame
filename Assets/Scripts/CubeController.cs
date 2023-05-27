using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private GameObject _diamond;
    // Start is called before the first frame update


    void Start()
    {
        RandomActivateDiamondPrefab();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomActivateDiamondPrefab()
    {
        int randomValue = Random.Range(0, 3);

        if (randomValue == 1) {
            _diamond.SetActive(true);
        }
    }

    

}
