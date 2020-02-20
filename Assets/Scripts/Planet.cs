using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Planet : MonoBehaviour
{
    #region Variables
    [Header("Variables")]
    [SerializeField]
    private float planetSize = 1;
    private float oldPlanetSize;
    [SerializeField]
    private Color planetColor = Color.white;
    private Color oldPlanetColor;
    [SerializeField]
    private float gravitySize = 2;
    private float oldGravitySize;
    [SerializeField]
    private Color gravityColor = new Color(0, 0, 1, 0.25f);
    private Color oldGravityColor;

    [Header("Constants")]
    [SerializeField]
    private Transform planet;
    [SerializeField]
    private SpriteRenderer planetSprite;
    [SerializeField]
    private Transform gravity;
    [SerializeField]
    private SpriteRenderer gravitySprite;
    #endregion

    private void Awake()
    {
        planetSprite = planet.GetComponent<SpriteRenderer>();
        gravitySprite = gravity.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {


        if (!planetSize.Equals(oldPlanetSize))
        {
            planet.localScale = Vector3.one * planetSize;
            oldPlanetSize = planetSize;
        }
        if (!planetColor.Equals(oldPlanetColor))
        {
            planetSprite.color = planetColor;
            oldPlanetColor = planetColor;
        }
        if (!gravitySize.Equals(oldGravitySize))
        {
            gravity.localScale = Vector3.one * gravitySize;
            oldGravitySize = gravitySize;
        }
        if (!gravityColor.Equals(oldGravityColor))
        {
            gravitySprite.color = gravityColor;
            oldGravityColor = gravityColor;
        }
    }
}
