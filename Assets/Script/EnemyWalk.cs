using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public GameObject DownCamera;
    public GameObject UpCamera;
    public GameObject Enemy;
    void Update()
    {
        DownCamera.SetActive(true);
        UpCamera.SetActive(false);
        if(Enemy.transform.position.z < 225)
        {
            transform.Translate(0, 0, 10 * Time.deltaTime);
            DownCamera.SetActive(false);
            UpCamera.SetActive(true);
        }
    }
}
