using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public sealed class get : MonoBehaviour
{
    public GameObject g;
    private void OnEnable()
    {
        if (!g)
            return;

        for (int i = 0; i < 10; i++)
        {
            GameObject a = Instantiate(g);
            a.GetComponent<SpriteRenderer>().color = new Color(1, .9f, .7f, Random.Range(.1f, .9f));
        }
    }
}
