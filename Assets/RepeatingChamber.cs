using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingChamber : MonoBehaviour
{
    public bool fire = true;
    [SerializeField] private GameObject cannonTip;
    [SerializeField] private GameObject cannonShell;
    [SerializeField] private float firerate;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fire){
            Instantiate(cannonShell, cannonTip.transform.position, Quaternion.identity);
            timer = firerate;
            fire = false;
        };
        if (timer <= 0){
            fire = true;
        };
        timer -= Time.deltaTime;
    }
}
