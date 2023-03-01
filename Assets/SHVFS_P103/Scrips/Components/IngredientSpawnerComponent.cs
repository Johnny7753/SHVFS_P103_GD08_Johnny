using UnityEngine;

public class IngredientSpawnerComponent : InteractableComponentBase
{
    public bool IsOnDesk = false;
    public GameObject Foodspawn;
    public Transform SpawnPosition;
    public GameObject Food;
    public override void Interact(Transform HandPosition,bool IsOnHand)
    {
        
        if (IsOnDesk == false && IsOnHand == false)
        {
            Foodspawn = Instantiate(Food,SpawnPosition.transform);
            IsOnDesk = true;
        }
        else if (IsOnDesk == false && IsOnHand == true)
        {
            Foodspawn.transform.SetParent(SpawnPosition);
            IsOnDesk= true;
        }
        else if (IsOnDesk == true && IsOnHand == true)
        {

        }
        else if (IsOnDesk == true && IsOnHand == false)
        {
            Foodspawn.transform.SetParent(HandPosition);
            IsOnDesk = false;
        }
    }
}
