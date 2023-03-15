using UnityEngine;

[CreateAssetMenu(fileName ="IngredientConfiguration_Base",menuName ="UnderCooked/IngredientConfiguration")]
public class IngredientConfiguration : ScriptableObject
{
    //public IngredientComponent Ingredient;
    public Vector3 Scale;
    public float ScaleFactor;
    public int HP;
    public string TestText;
}
