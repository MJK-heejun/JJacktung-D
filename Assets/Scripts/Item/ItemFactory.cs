using UnityEngine;
using System.Collections;

public class ItemFactory : MonoBehaviour
{

    public GameObject itemShield;
    public GameObject itemHeart;
    public GameObject itemBomb;

    private const int ITEM_SHIELD = 0;
    private const int ITEM_HEART = 1;
    private const int ITEM_BOMB = 2;

    private float[] _posArr = new float[] { -3.44f, -1.7f, 0f, 1.7f, 3.44f };

    //generate at random pos
    public void Generate(int enemyType)
    {
        float rNum = Random.Range(0.0F, 5.0F);
        GenerateAt(enemyType, (int)rNum);
    }

    public void SpeedChange(float speedVal)
    {
        itemShield.GetComponent<Enemy>().speed = speedVal;
        itemHeart.GetComponent<Enemy>().speed = speedVal;
        itemBomb.GetComponent<Enemy>().speed = speedVal;
    }


    //generate at the given pos
    public void GenerateAt(int itemType, int pos)
    {
        float myStartPosX = _posArr[pos];

        switch (itemType)
        {
            case ITEM_SHIELD:
                Instantiate(itemShield, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            case ITEM_HEART:
                Instantiate(itemHeart, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            case ITEM_BOMB:
                Instantiate(itemBomb, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            default:
                Instantiate(itemShield, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
        }
    }

}
