using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManageer : MonoBehaviour {

    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Text scoreText;
    public int score = 0;
    public Vector3 selectedSize;
    public Vector3 defaultSize;


    private int selectedZombiePosition = 0;

	// Use this for initialization
	void Start () {
        SelectZombie(selectedZombie);
        scoreText.text = "Score:" + score;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("left"))
        {
            GetZombieLeft();
        }
        if(Input.GetKeyDown("right"))
        {
            GetZombieRight();
        }
        if(Input.GetKeyDown("up"))
        {
            GetZombieUp();
        }
	}

    void GetZombieLeft()
    {
        selectedZombiePosition -= 1;
        if (selectedZombiePosition < 0)
            selectedZombiePosition = 3;
        DeSelectZombie(selectedZombie);
        selectedZombie = zombies[selectedZombiePosition];
        SelectZombie(selectedZombie);


    }
    void GetZombieRight()
    {
        selectedZombiePosition += 1;
        if (selectedZombiePosition > 3)
            selectedZombiePosition = 0;

        DeSelectZombie(selectedZombie);
        selectedZombie = zombies[selectedZombiePosition];
        SelectZombie(selectedZombie);
    }
    void GetZombieUp()
    {
        selectedZombie.GetComponent<Rigidbody>().AddForce(0,0,10,ForceMode.Impulse);
    }




    void SelectZombie(GameObject newZombie)
    {
        newZombie.transform.localScale = selectedSize;
    }
    void DeSelectZombie(GameObject oldZombie)
    {
        oldZombie.transform.localScale = defaultSize;
    }


    public void AddPoint()
    {
        score = score + 1;
        scoreText.text = "Score:" + score;
    }


}
