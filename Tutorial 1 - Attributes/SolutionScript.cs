using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class SolutionScript : MonoBehaviour
{
    // Public parameters
    [Header("Fire Textures")]
    public Texture2D FireColor;
    public Texture2D FireMetallic;
    public Texture2D FireNormalMap;
    public Texture2D FireEmission;
    [HideInInspector]
    public Color HDRcolorForOtherScript;
    [Header("Water Textures")]
    public Texture2D WaterColor;
    public Texture2D waterMetallic;
    public Texture2D WaterNormalMap;
    public Texture2D WaterEmission;
    [Range(0,100)][Tooltip("Controls the fire to water ratio")]
    public float WaterPercentage = 50.0f;

    // Private parameters
    private Animation ClickedAnim;

    // Start is called before the first frame update
    void Start()
    {
        ClickedAnim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
