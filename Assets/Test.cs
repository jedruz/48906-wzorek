using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;

    private void Awake()
    {
        var count = 20;
        for (int i = 0; i< count; i++)
        {
            var position = new Vector3(i, (Mathf.Sin(i)*1.2f), 0f);
            var renderer = Instantiate(cubePrefab, position, Quaternion.identity).GetComponent<MeshRenderer>();
        }
    }
}