using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]
    Sprite[] mySprites;
    public int brickLife;
    public int touchCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = mySprites[brickLife];
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            touchCounter++;
            if (touchCounter == brickLife)
            {
                Destroy(this.gameObject);
            }
        }
    }


}
