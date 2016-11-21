using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

    public GameObject normalCar;
    public GameObject rainBowCar;
    public GameObject truck;

    private const int NORMAL_CAR = 0;
    private const int RAINBOW_CAR = 1;
    private const int TRUCK_CAR = 2;

    private float[] _posArr = new float[] { -3.44f, -1.7f, 0f, 1.7f, 3.44f };

    //generate at random pos
    public void Generate(int enemyType)
    {        
        float rNum = Random.Range(0.0F, 5.0F);
        GenerateAt(enemyType, (int)rNum);        
    }

    public void SpeedChange(float speedVal) {
        normalCar.GetComponent<Enemy>().speed = speedVal;
        rainBowCar.GetComponent<Enemy>().speed = speedVal;
        truck.GetComponent<Enemy>().speed = speedVal;
    }


    //generate at the given pos
    public void GenerateAt(int enemyType, int pos) {
        float myStartPosX = _posArr[pos];

        switch (enemyType)
        {
            case NORMAL_CAR:
                Instantiate(normalCar, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            case RAINBOW_CAR:
                Instantiate(rainBowCar, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            case TRUCK_CAR:
                Instantiate(truck, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
            default:
                Instantiate(normalCar, new Vector2(myStartPosX, 8), Quaternion.identity);
                break;
        }
    }    

}
