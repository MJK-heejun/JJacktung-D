using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public EnemyFactory enemyFactory;
    public ItemFactory itemFactory;

    public float spawningRoutineTime;

    public float difficulty; //1.000 ~ 100
    public float itemRegenTime;

    private float LEVEL_1 = 10;
    private float LEVEL_2 = 20;
    private float LEVEL_3 = 30;
    private float LEVEL_4 = 40;
    private float LEVEL_5 = 50;
    private float LEVEL_6 = 60;
    private float LEVEL_7 = 70;
    private float LEVEL_8 = 80;
    private float LEVEL_9 = 90;
    private float LEVEL_10 = 110;

    // Use this for initialization
    void Start () {
        //enemyFactory.generate(0);
        StartCoroutine("SpawnEnemy");
        StartCoroutine("SpawnItem");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {
        difficulty += Time.deltaTime;

        if (difficulty >= LEVEL_1 && difficulty < LEVEL_2)
        {
            enemyFactory.SpeedChange(3.5f);
            spawningRoutineTime = 2.5f;
        } else if (difficulty >= LEVEL_2 && difficulty < LEVEL_3) {
            enemyFactory.SpeedChange(3.5f);
            spawningRoutineTime = 2f;
        }
        else if (difficulty >= LEVEL_3 && difficulty < LEVEL_4)
        {
            enemyFactory.SpeedChange(4f);
            spawningRoutineTime = 1.5f;
        }
        else if (difficulty >= LEVEL_4 && difficulty < LEVEL_5)
        {
            enemyFactory.SpeedChange(4f);
            spawningRoutineTime = 1f;
        }
        else if (difficulty >= LEVEL_5 && difficulty < LEVEL_6)
        {
            enemyFactory.SpeedChange(4.5f);
            spawningRoutineTime = 1f;
        }
        else if (difficulty >= LEVEL_6 && difficulty < LEVEL_7)
        {
            enemyFactory.SpeedChange(5f);
            spawningRoutineTime = 1f;
        }
        else if (difficulty >= LEVEL_7 && difficulty < LEVEL_8)
        {
            enemyFactory.SpeedChange(5.5f);
            spawningRoutineTime = 0.5f;
        }
        else if (difficulty >= LEVEL_8 && difficulty < LEVEL_9)
        {
            enemyFactory.SpeedChange(8f);
            spawningRoutineTime = 0.3f;
        }
        else if (difficulty >= LEVEL_9 && difficulty < LEVEL_10)
        {
            enemyFactory.SpeedChange(8f);
            spawningRoutineTime = 0.15f;
        }
        
    }


    IEnumerator SpawnEnemy()
    {
        int NORMAL_CAR = 0;
        int RAINBOW_CAR = 1;
        int TRUCK_CAR = 2;

        bool lastCarTruck = false;

        while (true) {
            if (lastCarTruck) { 
                yield return new WaitForSeconds(spawningRoutineTime);
                lastCarTruck = false;
            }
            float rNum = Random.Range(0.0F, 3.0F);

            if (rNum < 1)
            {
                enemyFactory.Generate(NORMAL_CAR);
            }
            else if (rNum < 2)
            {
                enemyFactory.Generate(RAINBOW_CAR);
            }
            else
            {
                enemyFactory.Generate(TRUCK_CAR);
                lastCarTruck = true;
            }
            yield return new WaitForSeconds(spawningRoutineTime);
        }
    }

    IEnumerator SpawnItem()
    {
        while (true)
        {
            float rNum = Random.Range(0.0F, 3.0F);

            if (rNum < 1)
            {
                itemFactory.Generate(0);
            }
            else if (rNum < 2)
            {
                itemFactory.Generate(1);
            }
            else
            {
                itemFactory.Generate(2);
            }
            yield return new WaitForSeconds(itemRegenTime);
        }
    }


}
