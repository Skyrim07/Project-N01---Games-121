using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Switch : MonoBehaviour
{
    public GameObject g1, g2;

    public void G1()
    {
        g1.SetActive(true);
        g2.SetActive(false);
    }

    public void G2()
    {
        g1.SetActive(false);
        g2.SetActive(true);
    }
}
