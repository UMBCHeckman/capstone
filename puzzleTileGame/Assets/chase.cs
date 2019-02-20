using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;


public class chase : MonoBehaviour
{
    public GameObject tile0; public GameObject tile1; public GameObject tile2; public GameObject tile3;
    public GameObject tile4; public GameObject tile5; public GameObject tile6; public GameObject tile7;
    public GameObject tile8; public GameObject tile9; public GameObject tile10; public GameObject tile11;
    public GameObject tile12; public GameObject tile13; public GameObject tile14; public GameObject tile15;
    public GameObject tile16; public GameObject tile17; public GameObject tile18; public GameObject tile19;
    public GameObject tile20; public GameObject tile21; public GameObject tile22; public GameObject tile23; public GameObject monster;
    Vector3[] locationsChase = {
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}};
    Vector3[] locationsChase2 = {
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}};
    private GameObject[] tiles;
    private static System.Random rng = new System.Random();
    int[] listChase = new int[24];
    int value;
    bool lclick;
    bool rclick;
    float inputLC = 0;
    float inputRC = 0;
    public GameObject canvas2;
    private Vector3 point;
    private GameObject cursorObject;
    private Ray ray;
    private GameObject fullImage;
    bool drag1;
    bool drag2;
    private GameObject currentTileChase;
    private GameObject newTile;
    private Vector3 storedVec;
    private Vector3 newVec;
    private bool hoverBool;
    private bool win = false;
    private GameObject bg;
    private GameObject gameOver;
    private int counter;
    private int monsterNum;
    private int monsterNum2;
    List<int> randRolls = new List<int>();
    bool left = true;
    bool right = true;
    bool up = true;
    bool down = true;
    List<int> monsterHist = new List<int>();
    //private int[] monsterHist = new int[4];
    //private float max = 999999f;
    //private int newRecord;
    // Use this for initialization
    void Start()
    {
        //cursorObject = GameObject.Find("pointer");
        fullImage = GameObject.Find("GameObjectFull");
        tile0 = GameObject.Find("GameObject");
        tile1 = GameObject.Find("GameObject (1)");
        tile2 = GameObject.Find("GameObject (2)");
        tile3 = GameObject.Find("GameObject (3)");
        tile4 = GameObject.Find("GameObject (4)");
        tile5 = GameObject.Find("GameObject (5)");
        tile6 = GameObject.Find("GameObject (6)");
        tile7 = GameObject.Find("GameObject (7)");
        tile8 = GameObject.Find("GameObject (8)");
        tile9 = GameObject.Find("GameObject (9)");
        tile10 = GameObject.Find("GameObject (10)");
        tile11 = GameObject.Find("GameObject (11)");
        tile12 = GameObject.Find("GameObject (12)");
        tile13 = GameObject.Find("GameObject (13)");
        tile14 = GameObject.Find("GameObject (14)");
        tile15 = GameObject.Find("GameObject (15)");
        tile16 = GameObject.Find("GameObject (16)");
        tile17 = GameObject.Find("GameObject (17)");
        tile18 = GameObject.Find("GameObject (18)");
        tile19 = GameObject.Find("GameObject (19)");
        tile20 = GameObject.Find("GameObject (20)");
        tile21 = GameObject.Find("GameObject (21)");
        tile22 = GameObject.Find("GameObject (22)");
        tile23 = GameObject.Find("GameObject (23)");
        monster = GameObject.Find("monster");
        locationsChase[0] = tile0.transform.position;
        locationsChase[1] = tile1.transform.position;
        locationsChase[2] = tile2.transform.position;
        locationsChase[3] = tile3.transform.position;
        locationsChase[4] = tile4.transform.position;
        locationsChase[5] = tile5.transform.position;
        locationsChase[6] = tile6.transform.position;
        locationsChase[7] = tile7.transform.position;
        locationsChase[8] = tile8.transform.position;
        locationsChase[9] = tile9.transform.position;
        locationsChase[10] = tile10.transform.position;
        locationsChase[11] = tile11.transform.position;
        locationsChase[12] = tile12.transform.position;
        locationsChase[13] = tile13.transform.position;
        locationsChase[14] = tile14.transform.position;
        locationsChase[15] = tile15.transform.position;
        locationsChase[16] = tile16.transform.position;
        locationsChase[17] = tile17.transform.position;
        locationsChase[18] = tile18.transform.position;
        locationsChase[19] = tile19.transform.position;
        locationsChase[20] = tile20.transform.position;
        locationsChase[21] = tile21.transform.position;
        locationsChase[22] = tile22.transform.position;
        locationsChase[23] = tile23.transform.position;
        locationsChase2[0] = tile0.transform.position;
        locationsChase2[1] = tile1.transform.position;
        locationsChase2[2] = tile2.transform.position;
        locationsChase2[3] = tile3.transform.position;
        locationsChase2[4] = tile4.transform.position;
        locationsChase2[5] = tile5.transform.position;
        locationsChase2[6] = tile6.transform.position;
        locationsChase2[7] = tile7.transform.position;
        locationsChase2[8] = tile8.transform.position;
        locationsChase2[9] = tile9.transform.position;
        locationsChase2[10] = tile10.transform.position;
        locationsChase2[11] = tile11.transform.position;
        locationsChase2[12] = tile12.transform.position;
        locationsChase2[13] = tile13.transform.position;
        locationsChase2[14] = tile14.transform.position;
        locationsChase2[15] = tile15.transform.position;
        locationsChase2[16] = tile16.transform.position;
        locationsChase2[17] = tile17.transform.position;
        locationsChase2[18] = tile18.transform.position;
        locationsChase2[19] = tile19.transform.position;
        locationsChase2[20] = tile20.transform.position;
        locationsChase2[21] = tile21.transform.position;
        locationsChase2[22] = tile22.transform.position;
        locationsChase2[23] = tile23.transform.position;
        for (int i = 0; i < 24; i++)
            listChase[i] = i;
        int n = listChase.Length;
        /*
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            value = listChase[k];
            listChase[k] = listChase[n];
            listChase[n] = value;
        }
        */
        for (int i = 0; i < 24; i++)
            //print(listChase[i]);
        tile0.transform.position = locationsChase[listChase[0]];
        tile1.transform.position = locationsChase[listChase[1]];
        tile2.transform.position = locationsChase[listChase[2]];
        tile3.transform.position = locationsChase[listChase[3]];
        tile4.transform.position = locationsChase[listChase[4]];
        tile5.transform.position = locationsChase[listChase[5]];
        tile6.transform.position = locationsChase[listChase[6]];
        tile7.transform.position = locationsChase[listChase[7]];
        tile8.transform.position = locationsChase[listChase[8]];
        tile9.transform.position = locationsChase[listChase[9]];
        tile10.transform.position = locationsChase[listChase[10]];
        tile11.transform.position = locationsChase[listChase[11]];
        tile12.transform.position = locationsChase[listChase[12]];
        tile13.transform.position = locationsChase[listChase[13]];
        tile14.transform.position = locationsChase[listChase[14]];
        tile15.transform.position = locationsChase[listChase[15]];
        tile16.transform.position = locationsChase[listChase[16]];
        tile17.transform.position = locationsChase[listChase[17]];
        tile18.transform.position = locationsChase[listChase[18]];
        tile19.transform.position = locationsChase[listChase[19]];
        tile20.transform.position = locationsChase[listChase[20]];
        tile21.transform.position = locationsChase[listChase[21]];
        tile22.transform.position = locationsChase[listChase[22]];
        tile23.transform.position = locationsChase[listChase[23]];
        tiles = GameObject.FindGameObjectsWithTag("tile").OrderBy(go => go.transform.GetSiblingIndex()).ToArray();
        
        //for (int i = 0; i < tiles.Length; i++)
        //    print(tiles[i]);
        //tiles[0] = tile0;
        //tiles[1] = tile1; tiles[2] = tile2; tiles[3] = tile3; tiles[4] = tile4; tiles[5] = tile5; tiles[6] = tile6;
        //tiles[7] = tile7; tiles[8] = tile8; tiles[9] = tile9; tiles[10] = tile10; tiles[11] = tile11; tiles[12] = tile12;
        //tiles[13] = tile13; tiles[14] = tile14; tiles[15] = tile15;
        //tiles[16] = tile16; tiles[17] = tile17; tiles[18] = tile18; tiles[19] = tile19; tiles[20] = tile20; tiles[21] = tile21; tiles[22] = tile22;
        //tiles[23] = tile23;
        //bg = GameObject.Find("bg");
        //bg.SetActive(false);
        counter = 0;
        //print(tile0.transform.position);
        InvokeRepeating("moveTile", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void moveTile()
    {
        up = true;
        down = true;
        right = true;
        left = true;
        if (monsterNum + 4 > 23 || monsterHist.Contains(monsterNum + 4))
        {
            right = false;
        }
        if ((monsterNum % 4) + 1 > 3 || monsterHist.Contains(monsterNum + 1))
        {
            down = false;
        }
        if (monsterNum - 4 < 0 || monsterHist.Contains(monsterNum - 4))
        {
            left = false;
        }
        if ((monsterNum % 4) - 1 < 0 || monsterHist.Contains(monsterNum - 1))
        {
            up = false;
        }
        if (up == false && down == false && left == false && right == false)
        {
            monsterHist.RemoveAt(0);
            print("stuck");
            return;
        }
            //int rando = Random.RandomRange(0, 4);
            randRolls.Clear();
            if (right){ randRolls.Add(0); }
            if (down) { randRolls.Add(1); }
            if (left) { randRolls.Add(2); }
            if (up) { randRolls.Add(3); }
            //int rando = rng.Next(randRolls.Count);
            int randoDex = Random.RandomRange(0, randRolls.Count);
            int rando = randRolls[randoDex];
            print(rando);
            if ((rando == 0) && monsterNum + 4 <= 23 && !monsterHist.Contains(monsterNum + 4))
            {
                monster.transform.position = locationsChase[listChase[monsterNum + 4]];
                if (monsterHist.Count == 3)
                    monsterHist.RemoveAt(0);
                monsterHist.Add(monsterNum);
                monsterNum += 4;
            }
            else if ((rando == 1) && (monsterNum % 4) + 1 <= 3 && !monsterHist.Contains(monsterNum + 1))
            {
                monster.transform.position = locationsChase[listChase[monsterNum + 1]];
                if (monsterHist.Count == 3)
                    monsterHist.RemoveAt(0);
                monsterHist.Add(monsterNum);
                monsterNum += 1;
            }
            else if ((rando == 2) && monsterNum - 4 >= 0 && !monsterHist.Contains(monsterNum - 4))
            {
                monster.transform.position = locationsChase[listChase[monsterNum - 4]];
                if (monsterHist.Count == 3)
                    monsterHist.RemoveAt(0);
                monsterHist.Add(monsterNum);
                monsterNum -= 4;
            }
            else if ((rando == 3) && (monsterNum % 4) - 1 >= 0 && !monsterHist.Contains(monsterNum - 1))
            {
                monster.transform.position = locationsChase[listChase[monsterNum - 1]];
                if (monsterHist.Count == 3)
                    monsterHist.RemoveAt(0);
                monsterHist.Add(monsterNum);
                monsterNum -= 1;
            }
            else
            {
                moveTile();
            }
    }
    void Update()
    {

        //win = true;
    }
 }