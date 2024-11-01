using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float moveSpeed;

    private float offset;
    public Material material;

    void Update()
    {
        offset += (Time.deltaTime * moveSpeed) / 10f;
        material.SetTextureOffset("_MainTex",new Vector2 (0,offset));
    }
}
