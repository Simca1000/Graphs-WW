using UnityEngine;

public class PersoClothSwaper : MonoBehaviour
{
    [Header("Vêtements")]
    public SCO_ClothPack ClothPack;

    [Header("Emplacements"), SerializeField]
    private SpriteRenderer head;
    
    //List à edit (ne pas oublie d'edit aussi le SCO)

    [SerializeField] 
    private SpriteRenderer leftArm, rightArm, chest, legs /*,ajout*/;

    void FixedUpdate()
    {
        ChangeCloth(ClothPack);
    }

    public void ChangeCloth(SCO_ClothPack ClothPack)
    {
        //List à edit 
        // ajout.sprite = ClothPack.ajout
        head.sprite = ClothPack.head;
        chest.sprite = ClothPack.chest;
        leftArm.sprite = ClothPack.leftArm;
        rightArm.sprite = ClothPack.rightArm;
        legs.sprite = ClothPack.legs;
    }
}
