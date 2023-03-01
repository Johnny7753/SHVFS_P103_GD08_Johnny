using UnityEngine;

public class IngredientDestoryComponent : InteractableComponentBase
{
    public GameObject Player;
    public override void Interact(Transform HandPosition, bool IsOnHand)
    {
        if (IsOnHand == true)
        {
            Destroy(Player.GetComponentInChildren<FoodComponent>().gameObject);
        }
    }
}
