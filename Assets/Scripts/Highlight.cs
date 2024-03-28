using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    // assigning all renderers through our inspector
    [SerializeField]
    private List<Renderer> renderers;

    [SerializeField]
    private Color color = Color.white;

    //helper list to cache all the materials of the object
    private List<Material> materials;

    //Gets all the materials from each renderer

    private void Awake()
    {
        materials = new List<Material>();
        foreach (var renderer in renderers)
        {
            materials.AddRange(new List<Material>(renderer.materials));
        }
    }

    public void ToggleHighlight(bool val)
    {
        if (val)
        {
            foreach (var material in materials)
            {
                //we need to enable the EMISSION
                material.EnableKeyword("_EMISSION");
                //before we set the colour
                material.SetColor("_EmissionColor", color);
            }
        }
        else
        {
            foreach (var material in materials)
            {
                //we can just disable the EMISSION
                //if we don't use emission color anywhere else 
                material.DisableKeyword("_EMISSION");
            }
        }
            
        
    }


}
