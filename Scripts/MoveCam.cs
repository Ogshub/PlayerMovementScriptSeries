using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform Player;

    void Update()
    {
        transform.position = Player.transform.position;
    }
}
