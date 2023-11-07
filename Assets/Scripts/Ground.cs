using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 3f;
    
    private void Awake()
    {
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }
    }
    
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0f); 
    }
}
