using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPM : MonoBehaviour
{
    public int numberOfItems, score; // Ints represent WHOLE NUMBERS
    public float health, weight, speed, dollars; // Floats represent DECIMAL NUMBERS
    public string actualFavoriteStudent, menuLabel, dialogue, characterName; // Strings represent WORDS/PHRASES/TEXT
    public bool isEnemyDead, isEffectActive, isGrounded, isPlayerDead; // Bools represnt values that are TRUE OR FALSE
    public Vector2 size, playerLocation; //Vector2s represent 2-DIMENSIONAL DECIMALS 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Derek's favorite student is " + characterName); 

        if (isGrounded) // Will execute the below code IF THE STATEMENT IN PARENTHESEES BELOW IS CURRENTLY TRUE
        {
            Debug.Log("On the floor crying");
        }
        else // Code in the ELSE will execute if the previous code in the IF did NOT EXECUTE
        {
            Debug.Log("Just kidding it's actually " + actualFavoriteStudent); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
